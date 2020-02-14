using System;
using System.IO;
using System.Threading.Tasks;

namespace TypedJsonSerialization.Serializers {
	class Utf8JsonSerializer: ISerializer {
		public async Task<TResult> Deserialize<TResult> (string jsonFileFullPath) {
			byte[] jsonDataBytes = await File.ReadAllBytesAsync(jsonFileFullPath);
			return Utf8Json.JsonSerializer.Deserialize<TResult>(
				jsonDataBytes
			);
		}

		public async Task Serialize (string jsonFileFullPath, object obj) {
			byte[] jsonData = Utf8Json.JsonSerializer.Serialize(obj);
			await File.WriteAllBytesAsync(jsonFileFullPath, jsonData);
		}
	}
}
