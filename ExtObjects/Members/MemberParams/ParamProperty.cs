using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypedJsonReading.ExtObjects.Members.Params {
	public class ParamProperty {
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
		
		[System.Runtime.Serialization.DataMember(Name = "default")]
		[Newtonsoft.Json.JsonProperty("default")]
        public string Default { get; set; }
		
		[System.Runtime.Serialization.DataMember(Name = "required")]
		[Newtonsoft.Json.JsonProperty("required")]
        public bool? Required { get; set; }
		
		[System.Runtime.Serialization.DataMember(Name = "deprecated")]
		[Newtonsoft.Json.JsonProperty("deprecated")]
        public Deprecated Deprecated { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "html_type")]
		[Newtonsoft.Json.JsonProperty("html_type")]
        public string HtmlType { get; set; }

		// Example:Ext.form.Basic.doAction
        [System.Runtime.Serialization.DataMember(Name = "properties")]
		[Newtonsoft.Json.JsonProperty("properties")]
        public IList<ParamProperty> Properties { get; set; }
	}
}
