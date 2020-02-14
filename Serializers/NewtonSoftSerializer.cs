using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TypedJsonSerialization.Serializers {
	class NewtonSoftSerializer: ISerializer {
		public async Task<TResult> Deserialize<TResult> (string jsonFileFullPath) {
			string jsonDataStr = await File.ReadAllTextAsync(jsonFileFullPath);
			JsonSerializerSettings jsonSettings = new JsonSerializerSettings();
			jsonSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
			return (TResult)JsonConvert.DeserializeObject(
				jsonDataStr, typeof(TResult), jsonSettings
			);
		}

		public async Task Serialize (string jsonFileFullPath, object obj) {
			string jsonData = JsonConvert.SerializeObject(obj);
			await File.WriteAllTextAsync(jsonFileFullPath, jsonData);
		}
	}
}
