using TypedJsonReading.ExtObjects.Members;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace TypedJsonReading.ExtObjects {
	public class Member {
        [System.Runtime.Serialization.DataMember(Name = "tagname")]
		[Newtonsoft.Json.JsonProperty("tagname")]
		public string Tagname { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "name")]
		[Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "autodetected")]
		[Newtonsoft.Json.JsonProperty("autodetected")]
        public object Autodetected { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "files")]
		[Newtonsoft.Json.JsonProperty("files")]
        public object Files { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "doc")]
		[Newtonsoft.Json.JsonProperty("doc")]
        public string Doc { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "params")]
		[Newtonsoft.Json.JsonProperty("params")]
        public IList<MemberParam> Params { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "return")]
		[Newtonsoft.Json.JsonProperty("return")]
        public Return Return { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "type")]
		[Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "throws")]
		[Newtonsoft.Json.JsonProperty("throws")]
        public object Throws { get; set; }

        [System.Runtime.Serialization.DataMember(Name = "default")]
		[Newtonsoft.Json.JsonProperty("default")]
        public string Default { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "properties")]
		[Newtonsoft.Json.JsonProperty("properties")]
        public IList<object> Properties { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "private")]
		[Newtonsoft.Json.JsonProperty("private")]
        public bool? Private { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "protected")]
		[Newtonsoft.Json.JsonProperty("protected")]
        public bool? Protected { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "chainable")]
		[Newtonsoft.Json.JsonProperty("chainable")]
        public bool? Chainable { get; set; }

        [System.Runtime.Serialization.DataMember(Name = "since")]
		[Newtonsoft.Json.JsonProperty("since")]
        public string Since { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "inheritdoc")]
		[Newtonsoft.Json.JsonProperty("inheritdoc")]
        public InheritDoc Inheritdoc { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "static")]
		[Newtonsoft.Json.JsonProperty("static")]
        public bool? Static { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "deprecated")]
		[Newtonsoft.Json.JsonProperty("deprecated")]
        public Deprecated Deprecated { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "inheritable")]
		[Newtonsoft.Json.JsonProperty("inheritable")]
        public object Inheritable { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "linenr")]
		[Newtonsoft.Json.JsonProperty("linenr")]
        public object Linenr { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "fires")]
		[Newtonsoft.Json.JsonProperty("fires")]
        public object Fires { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "method_calls")]
		[Newtonsoft.Json.JsonProperty("method_calls")]
        public object MethodCalls { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "readonly")]
		[Newtonsoft.Json.JsonProperty("readonly")]
        public bool? Readonly { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "required")]
		[Newtonsoft.Json.JsonProperty("required")]
		public bool? Required { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "template")]
		[Newtonsoft.Json.JsonProperty("template")]
        public bool? Template { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "id")]
		[Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "owner")]
		[Newtonsoft.Json.JsonProperty("owner")]
        public string Owner { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "overrides")]
		[Newtonsoft.Json.JsonProperty("overrides")]
        public IList<Override> Overrides { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "short_doc")]
		[Newtonsoft.Json.JsonProperty("short_doc")]
        public string ShortDoc { get; set; }
		
        [System.Runtime.Serialization.DataMember(Name = "html_type")]
		[Newtonsoft.Json.JsonProperty("html_type")]
        public string HtmlType { get; set; }
	}
}
