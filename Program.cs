using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using TypedJsonReading;
using TypedJsonSerialization.Serializers;

namespace TypedJsonSerialization {
	class Program {
		protected static Program instance;
		protected static Dictionary<string, SerializerType> providerTypes = new Dictionary<string, SerializerType>() {
			{ "dotnet-core", SerializerType.DotNetCore },
			{ "utf8json", SerializerType.Utf8Json },
			{ "newtonsoft", SerializerType.NewtonSoft }
		};
		protected string dataDirSources = "~/data/sources";
		protected string dataDirTargets = "~/data/targets";
		protected SerializerType serializerType;
		protected ISerializer serializer;
		protected int itemsTotalCount = 0;
		protected int processedItems = 0;
		protected Dictionary<string, ExtObject> store;
		protected List<Exception> exceptions;
		static void Main (params string[] args) {
#if DEBUG
			Program.instance = new Program(SerializerType.DotNetCore);
#else
			string providerParam = null;
			List<string> serializers = Program.providerTypes.Keys.ToList<string>();
			if (args.Length == 1 && serializers.Contains(args[0])) 
				providerParam = args[0];
			if (String.IsNullOrEmpty(providerParam)) {
				Console.WriteLine(
					$"Please provide serializer type: `{String.Join(" | ", serializers.ToArray<string>())}`."
				);
				Environment.Exit(0);
			}
			Program.instance = new Program(
				Program.providerTypes[providerParam]	
			);
#endif
			Console.ReadLine();
		}
		public Program (SerializerType serializerType) {
			this.init(serializerType);
			Task.Run(async () => {
				Stopwatch sw = new Stopwatch();
				
				sw.Start();
				await this.readAndDeserializeAll();
				await this.serializeAndWriteAll();
				sw.Stop();

				Console.Clear();
				Console.WriteLine(
					$"Store has {Program.instance.store.Count} JSON files deserialized/serialized in {sw.ElapsedMilliseconds} miliseconds."
				);
				Console.WriteLine(
					Program.instance.exceptions.Count == 0
						? "Reading/writing with no error."
						: $"Reading/writing with {Program.instance.exceptions.Count} error(s)."
				);
#if !DEBUG
				Environment.Exit(0);
#endif
			});
		}
		protected void init (SerializerType serializerType) {
			this.serializerType = serializerType;
			this.exceptions = new List<Exception>();
			this.initDataDirs();
			if (this.serializerType == SerializerType.DotNetCore) {
				this.serializer = new DotNetCoreSerializer();
			} else if (this.serializerType == SerializerType.Utf8Json) {
				this.serializer = new Utf8JsonSerializer();
			} else if (this.serializerType == SerializerType.NewtonSoft) {
				this.serializer = new NewtonSoftSerializer();
			}
		}
		protected async Task readAndDeserializeAll () {
			DirectoryInfo dataDirInfo = new DirectoryInfo(this.dataDirSources);
			FileInfo[] jsonFilesInfos = dataDirInfo.GetFiles();
			this.itemsTotalCount = jsonFilesInfos.Length;
			this.processedItems = 0;
			this.store = new Dictionary<string, ExtObject>(this.itemsTotalCount);
			List<Task> listOfTasks = new List<Task>();
			foreach (FileInfo jsonFileInfo in jsonFilesInfos) {
				listOfTasks.Add(
					Task.Run(async () => {
						try {
							ExtObject extObject = await this.serializer.Deserialize<ExtObject>(
								jsonFileInfo.FullName
							);
							this.store.Add(jsonFileInfo.Name, extObject);
						} catch (Exception ex) {
							this.exceptions.Add(ex);
						}
						this.processedItems = Interlocked.Increment(ref this.processedItems);
						Console.Clear();
						Console.WriteLine(
							"Deserialization: " + ((double)this.processedItems / (double)this.itemsTotalCount * 100.0).ToString("0.00") + "%"
						);
					})
				);
			}
			await Task.WhenAll(listOfTasks.ToArray());
		}
		protected async Task serializeAndWriteAll () {
			List<Task> listOfTasks = new List<Task>();
			this.processedItems = 0;
			foreach (var item in this.store) {
				listOfTasks.Add(
					Task.Run(async () => {
						try {
							await this.serializer.Serialize(
								this.dataDirTargets + "/" + item.Key, item.Value
							);
						} catch (Exception e) {
							this.exceptions.Add(e);
						}
						this.processedItems = Interlocked.Increment(ref this.processedItems);
						Console.Clear();
						Console.WriteLine(
							"Serialization: " + ((double)this.processedItems / (double)this.itemsTotalCount * 100.0).ToString("0.00") + "%"
						);
					})
				);
			}
			await Task.WhenAll(listOfTasks.ToArray());
		}
		protected void initDataDirs () {
			string asmLoc = this.GetType().Assembly.Location.Replace('\\', '/');
			int lastSlashPos = asmLoc.LastIndexOf('/');
			if (lastSlashPos != -1)
				asmLoc = asmLoc.Substring(0, lastSlashPos);
			this.dataDirSources = this.dataDirSources.Replace("~", asmLoc);
			this.dataDirTargets = this.dataDirTargets.Replace("~", asmLoc);
			if (!Directory.Exists(this.dataDirTargets))
				Directory.CreateDirectory(this.dataDirTargets);
			DirectoryInfo di = new DirectoryInfo(this.dataDirTargets);
			foreach (FileInfo file in di.EnumerateFiles()) 
				file.Delete();
		}
	}
}
