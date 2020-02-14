using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypedJsonReading.ExtObjects.Members.Returns {
	public class Property {
		[System.Runtime.Serialization.DataMember(Name = "tagname")]
		[Newtonsoft.Json.JsonProperty("tagname")]
        public string Tagname { get; set; }

        [System.Runtime.Serialization.DataMember(Name = "type")]
		[Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }

        [System.Runtime.Serialization.DataMember(Name = "name")]
		[Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [System.Runtime.Serialization.DataMember(Name = "doc")]
		[Newtonsoft.Json.JsonProperty("doc")]
        public string Doc { get; set; }

        [System.Runtime.Serialization.DataMember(Name = "html_type")]
		[Newtonsoft.Json.JsonProperty("html_type")]
        public string HtmlType { get; set; }
	}
}
