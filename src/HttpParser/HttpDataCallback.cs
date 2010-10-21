
using System.IO;

namespace HttpParser {

	public delegate int HttpDataCallback (HttpParser parser, MemoryStream data, int pos, int len);

}

