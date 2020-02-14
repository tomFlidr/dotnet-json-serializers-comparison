using Newtonsoft.Json;

namespace TypedJsonReading.ExtObjects.Members {
	public class Override {
		[System.Runtime.Serialization.DataMember(Name = "name")]
		[Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [System.Runtime.Serialization.DataMember(Name = "owner")]
		[Newtonsoft.Json.JsonProperty("owner")]
        public string Owner { get; set; }

        [System.Runtime.Serialization.DataMember(Name = "link")]
		[Newtonsoft.Json.JsonProperty("link")]
        public string Link { get; set; }
	}
}
