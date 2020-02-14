using System;
using System.Collections.Generic;
using System.Text;

namespace TypedJsonSerialization {
	[Flags]
	enum SerializerType {
		None		= 0,
		DotNetCore	= 1,
		Utf8Json	= 2,
		NewtonSoft	= 4
	}
}
