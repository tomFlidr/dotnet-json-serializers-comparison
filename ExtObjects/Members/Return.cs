using TypedJsonReading.ExtObjects.Members.Returns;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace TypedJsonReading.ExtObjects.Members {
	public class Return {
		[System.Runtime.Serialization.DataMember(Name = "type")]
		[Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "name")]
		[Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [System.Runtime.Serialization.DataMember(Name = "doc")]
		[Newtonsoft.Json.JsonProperty("doc")]
        public string Doc { get; set; }

        [System.Runtime.Serialization.DataMember(Name = "properties")]
		[Newtonsoft.Json.JsonProperty("properties")]
        public IList<Property> Properties { get; set; }

        [System.Runtime.Serialization.DataMember(Name = "html_type")]
		[Newtonsoft.Json.JsonProperty("html_type")]
        public string HtmlType { get; set; }
	}
}
