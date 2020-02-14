using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TypedJsonSerialization.Serializers {
	interface ISerializer {
		public Task<TResult> Deserialize<TResult> (string jsonFileFullPath);
		public Task Serialize (string jsonFileFullPath, object obj);
	}
}
