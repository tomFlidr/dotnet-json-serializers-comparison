using System;
using System.IO;
using System.Threading.Tasks;

namespace TypedJsonSerialization.Serializers {
	class DotNetCoreSerializer: ISerializer {
		public async Task<TResult> Deserialize<TResult> (string jsonFileFullPath) {
			string jsonDataText = await File.ReadAllTextAsync(jsonFileFullPath);
			return System.Text.Json.JsonSerializer.Deserialize<TResult>(
				jsonDataText, new System.Text.Json.JsonSerializerOptions {
					IgnoreNullValues = true
				}
			);
		}

		public async Task Serialize (string jsonFileFullPath, object obj) {
			string jsonData = System.Text.Json.JsonSerializer.Serialize(
				obj, new System.Text.Json.JsonSerializerOptions {
					IgnoreNullValues = true
				}
			);
			await File.WriteAllTextAsync(jsonFileFullPath, jsonData);
		}
	}
}
