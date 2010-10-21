
using System;


namespace HttpParser {

	public class HttpException : Exception {

		public HttpException (string error)
		{
		}

		public HttpException (string error, Exception cause) : base (error, cause)
		{
		}
	}
}


