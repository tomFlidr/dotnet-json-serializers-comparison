using Newtonsoft.Json;

namespace TypedJsonReading.ExtObjects.Members {
	public class InheritDoc {
        [System.Runtime.Serialization.DataMember(Name = "tagname")]
		[Newtonsoft.Json.JsonProperty("tagname")]
        public string Tagname { get; set; }

        [System.Runtime.Serialization.DataMember(Name = "doc")]
		[Newtonsoft.Json.JsonProperty("doc")]
        public object Doc { get; set; }
	}
}
