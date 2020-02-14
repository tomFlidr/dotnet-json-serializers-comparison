using TypedJsonReading.ExtObjects;
using TypedJsonReading.ExtObjects.Members;
using System.Collections.Generic;

namespace TypedJsonReading
{
    public class ExtObject {
        [System.Runtime.Serialization.DataMember(Name = "tagname")]
		[Newtonsoft.Json.JsonProperty("tagname")]
		public string Tagname { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "name")]
		[Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "autodetect")]
		[Newtonsoft.Json.JsonProperty("autodetect")]
        public object Autodetect { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "files")]
		[Newtonsoft.Json.JsonProperty("files")]
        public IList<File> Files { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "doc")]
		[Newtonsoft.Json.JsonProperty("doc")]
        public string Doc { get; set; }

        [System.Runtime.Serialization.DataMember(Name = "aliases")]
		[Newtonsoft.Json.JsonProperty("aliases")]
        public Aliases Aliases { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "alternateClassNames")]
		[Newtonsoft.Json.JsonProperty("alternateClassNames")]
        public IList<string> AlternateClassNames { get; set; }

        [System.Runtime.Serialization.DataMember(Name = "extends")]
		[Newtonsoft.Json.JsonProperty("extends")]
        public string Extends { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "mixins")]
		[Newtonsoft.Json.JsonProperty("mixins")]
        public IList<object> Mixins { get; set; }

        [System.Runtime.Serialization.DataMember(Name = "requires")]
		[Newtonsoft.Json.JsonProperty("requires")]
        public IList<string> Requires { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "uses")]
		[Newtonsoft.Json.JsonProperty("uses")]
        public IList<object> Uses { get; set; }
		
		[System.Runtime.Serialization.DataMember(Name = "singleton")]
		[Newtonsoft.Json.JsonProperty("singleton")]
        public bool? Singleton { get; set; }
		
		[System.Runtime.Serialization.DataMember(Name = "private")]
		[Newtonsoft.Json.JsonProperty("private")]
        public bool? Private { get; set; }
		
		[System.Runtime.Serialization.DataMember(Name = "enum")]
		[Newtonsoft.Json.JsonProperty("enum")]
        public object Enum { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "members")]
		[Newtonsoft.Json.JsonProperty("members")]
        public List<Member> Members { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "code_type")]
		[Newtonsoft.Json.JsonProperty("code_type")]
        public string CodeType { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "id")]
		[Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }

        [System.Runtime.Serialization.DataMember(Name = "component")]
		[Newtonsoft.Json.JsonProperty("component")]
        public bool Component { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "short_doc")]
		[Newtonsoft.Json.JsonProperty("short_doc")]
        public string ShortDoc { get; set; }

		[System.Runtime.Serialization.DataMember(Name = "deprecated")]
		[Newtonsoft.Json.JsonProperty("deprecated")]
        public Deprecated Deprecated { get; set; }
    }
}
