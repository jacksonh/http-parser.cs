

using System;
using System.Text;
using System.Collections.Generic;


namespace HttpParser {
	
	public enum HttpMethod {
		ERROR = -1,
		
		HTTP_DELETE,
		HTTP_GET,
		HTTP_HEAD,
		HTTP_POST,
		HTTP_PUT,
		HTTP_CONNECT,
		HTTP_OPTIONS,
		HTTP_TRACE,
		HTTP_COPY,
		HTTP_LOCK,
		HTTP_MKCOL,
		HTTP_MOVE,
		HTTP_PROPFIND,
		HTTP_PROPPATCH,
		HTTP_UNLOCK,
		HTTP_REPORT,
		HTTP_MKACTIVITY,
		HTTP_CHECKOUT,
		HTTP_MERGE,
	}

	public static class HttpMethodBytes {

		private static object lock_obj = new object ();
		private static Dictionary<HttpMethod,byte[]> methods = new Dictionary<HttpMethod,byte[]> ();

		static HttpMethodBytes ()
		{
			lock (lock_obj) {
				foreach (HttpMethod m in Enum.GetValues (typeof (HttpMethod))) {
					Init (m);
				}
			}
		}

		public static void Init (HttpMethod method)
		{
			methods [method] = Encoding.ASCII.GetBytes (method.ToString ().Substring (5));
		}

		// TODO: This is good enough for now, but we shouldn't be allocing
		public static byte [] GetBytes (HttpMethod method)
		{
			byte [] bytes;
			if (!methods.TryGetValue (method, out bytes))
				return null;
			return bytes;
		}

	}
}

