using Newtonsoft.Json;

namespace TypedJsonReading.ExtObjects {
	public class File {
        [System.Runtime.Serialization.DataMember(Name = "filename")]
		[Newtonsoft.Json.JsonProperty("filename")]
        public string filename { get; set; }
        [System.Runtime.Serialization.DataMember(Name = "linenr")]
		[Newtonsoft.Json.JsonProperty("linenr")]
        public int Line { get; set; }
	}
}
