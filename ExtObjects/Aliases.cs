using Newtonsoft.Json;
using System.Collections.Generic;

namespace TypedJsonReading.ExtObjects {
	public class Aliases {
        [System.Runtime.Serialization.DataMember(Name = "widget")]
		[Newtonsoft.Json.JsonProperty("widget")]
        public IList<string> Widget { get; set; }
        [System.Runtime.Serialization.DataMember(Name = "request")]
		[Newtonsoft.Json.JsonProperty("request")]
        public IList<string> Request { get; set; }
	}
}
