
using System.IO;


namespace HttpParser {

	public delegate void HttpErrorCallback (HttpParser parser, string mesage, MemoryStream buffer, int initial_position);
}


