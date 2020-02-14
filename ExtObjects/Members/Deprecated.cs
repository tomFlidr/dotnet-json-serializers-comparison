using Newtonsoft.Json;

namespace TypedJsonReading.ExtObjects.Members {
	public class Deprecated {
        [System.Runtime.Serialization.DataMember(Name = "text")]
		[Newtonsoft.Json.JsonProperty("text")]
        public string Text { get; set; }

        [System.Runtime.Serialization.DataMember(Name = "version")]
		[Newtonsoft.Json.JsonProperty("version")]
        public string Version { get; set; }
	}
}
