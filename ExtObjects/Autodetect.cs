using Newtonsoft.Json;

namespace TypedJsonReading.ExtObjects {
	public class Autodetect {
		[System.Runtime.Serialization.DataMember(Name = "aliases")]
		[Newtonsoft.Json.JsonProperty("aliases")]
        public bool? Aliases { get; set; }
        [System.Runtime.Serialization.DataMember(Name = "alternateClassNames")]
		[Newtonsoft.Json.JsonProperty("alternateClassNames")]
        public bool? AlternateClassNames { get; set; }
        [System.Runtime.Serialization.DataMember(Name = "extends")]
		[Newtonsoft.Json.JsonProperty("extends")]
        public bool? Extends { get; set; }
        [System.Runtime.Serialization.DataMember(Name = "mixins")]
		[Newtonsoft.Json.JsonProperty("mixins")]
        public bool? Mixins { get; set; }
        [System.Runtime.Serialization.DataMember(Name = "requires")]
		[Newtonsoft.Json.JsonProperty("requires")]
        public bool? Requires { get; set; }
        [System.Runtime.Serialization.DataMember(Name = "uses")]
		[Newtonsoft.Json.JsonProperty("uses")]
        public bool? Uses { get; set; }
        [System.Runtime.Serialization.DataMember(Name = "members")]
		[Newtonsoft.Json.JsonProperty("members")]
        public bool? Members { get; set; }
        [System.Runtime.Serialization.DataMember(Name = "code_type")]
		[Newtonsoft.Json.JsonProperty("code_type")]
        public bool? CodeType { get; set; }
	}
}
