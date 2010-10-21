
using System;
using System.IO;


namespace HttpParser {
	public class ParserSettings {
	
		public HttpCallback       OnMessageBegin;
		public HttpDataCallback   OnPath;
		public HttpDataCallback   OnQueryString;
		public HttpDataCallback   OnUrl;
		public HttpDataCallback   OnFragment;
		public HttpDataCallback   OnHeaderField;
		public HttpDataCallback   OnHeaderValue;
		public HttpCallback       OnHeadersComplete;
		public HttpDataCallback   OnBody;
		public HttpCallback       OnMessageComplete;
		public HttpErrorCallback  OnError;

		public void RaiseOnMessageBegin (HttpParser p)
		{
			Raise (OnMessageBegin, p);
		}

		public void RaiseOnMessageComplete (HttpParser p)
		{
			Raise (OnMessageComplete, p);
		}
  
		// this one is a little bit different:
		// the current `position` of the buffer is the location of the
		// error, `ini_pos` indicates where the position of
		// the buffer when it was passed to the `execute` method of the parser, i.e.
		// using this information and `limit` we'll know all the valid data
		// in the buffer around the error we can use to print pretty error
		// messages.

		public void RaiseOnError (HttpParser p, string message, MemoryStream buf, int ini_pos)
		{
			if (null != OnError)
				OnError (p, message, buf, ini_pos);

			
			// if on_error gets called it MUST throw an exception, else the parser 
			// will attempt to continue parsing, which it can't because it's
			// in an invalid state.
			throw new HttpException (message);
		}

		public void RaiseOnHeaderField (HttpParser p, MemoryStream buf, int pos, int len)
		{
			Raise (OnHeaderField, p, buf, pos, len);
		}

		public void RaiseOnQueryString (HttpParser p, MemoryStream buf, int pos, int len)
		{
			Raise (OnQueryString, p, buf, pos, len);
		}

		public void RaiseOnFragment (HttpParser p, MemoryStream buf, int pos, int len)
		{
			Raise (OnFragment, p, buf, pos, len);
		}

		public void RaiseOnPath (HttpParser p, MemoryStream buf, int pos, int len)
		{
			Raise (OnPath, p, buf, pos, len);
		}

		public void RaiseOnHeaderValue (HttpParser p, MemoryStream buf, int pos, int len)
		{
			Raise (OnHeaderValue, p, buf, pos, len);
		}

		public void RaiseOnUrl (HttpParser p, MemoryStream buf, int pos, int len)
		{
			Raise (OnUrl, p, buf, pos, len);
		}

		public void RaiseOnBody(HttpParser p, MemoryStream buf, int pos, int len)
		{
			Raise (OnBody, p, buf, pos, len);
		}

		public void RaiseOnHeadersComplete (HttpParser p)
		{
			Raise (OnHeadersComplete, p);
		}

		private void Raise (HttpCallback cb, HttpParser p)
		{
			if (null != cb)
				cb (p);
		}

		private void Raise (HttpDataCallback cb, HttpParser p, MemoryStream buf, int pos, int len)
		{
			if (null != cb && -1 != pos)
				cb (p,buf,pos,len);
		}
	}
}
