
using System;
using System.IO;
using System.Text;

namespace HttpParser {

	public class Util {

		public static String DumpParser (HttpParser p)
		{
			StringBuilder builder = new StringBuilder();
    
			// the stuff up to the break is ephermeral and only meaningful
			// while the parser is parsing. In general, this method is 
			// probably only useful during debugging.

			/*
			builder.Append("state :"); builder.Append(p.state); builder.Append("\n");
			builder.Append("header_state :"); builder.Append(p.header_state); builder.Append("\n");
			builder.Append("strict :"); builder.Append(p.strict); builder.Append("\n");
			builder.Append("index :"); builder.Append(p.index); builder.Append("\n");
			builder.Append("flags :"); builder.Append(p.flags); builder.Append("\n");
			builder.Append("nread :"); builder.Append(p.nread); builder.Append("\n");
			builder.Append("content_length :"); builder.Append(p.content_length); builder.Append("\n");


			builder.Append("type :"); builder.Append(p.type); builder.Append("\n");
			builder.Append("http_major :"); builder.Append(p.http_major); builder.Append("\n");
			builder.Append("http_minor :"); builder.Append(p.http_minor); builder.Append("\n");
			builder.Append("status_code :"); builder.Append(p.status_code); builder.Append("\n");
			builder.Append("method :"); builder.Append(p.method); builder.Append("\n");
			builder.Append("upgrade :"); builder.Append(p.upgrade); builder.Append("\n");
			*/

			return builder.ToString();

		}

		public static String Error (String mes, MemoryStream buffer, int begining) {
			// the error message should look like this:
			//
			// Bla expected something, but it's not there (mes)
			// GEt / HTTP 1_1
			// ............^.
			//
			// |----------------- 72 -------------------------|

			// This is ridiculously complicated and probably riddled with
			// off-by-one errors, should be moved into high level interface.
			// TODO.
      
			// also: need to keep track of the initial buffer position in
			// execute so that we don't screw up any `mark()` that may have
			// been set outside of our control to be nice.

			StringBuilder builder = new StringBuilder();

			/*
			int mes_width = 72;
			int p   = b.position();      // error position
			int end = b.limit();         // this is the end
			int m   = end - begining;    // max mes length  
      
			
			int p_adj = p;

			byte [] orig = new byte[0];
			if (m <= mes_width) {
				orig = new byte[m];
				b.position(begining);
				b.get(orig, 0, m);
				p_adj = p-begining;
        
        
			} else {
				// we'll need to trim bit off the beginning and/or end
				orig = new byte[mes_width];
				// three possibilities:
				// a.) plenty of stuff around p
				// b.) plenty of stuff in front of p
				// c.) plenty of stuff behind p
				// CAN'T be not enough stuff aorund p in total, because 
				// m>meswidth (see if to this else)

				int before = p-begining;
				int after  = end - p;
				if ( (before > mes_width/2) && (after > mes_width/2)) {
					// plenty of stuff in front of and behind error
					p_adj = mes_width/2;
					b.position(p - mes_width/2);
					b.get(orig, 0, mes_width);
				} else if  (before <= mes_width/2) {
					// take all of the begining.
					b.position(begining);
					// and as much of the rest as possible
          
					b.get(orig, 0, mes_width);

				} else {
					// plenty of stuff before
					before = end-mes_width;
					b.position(before);
					p_adj = p - before;
					b.get(orig, 0, mes_width);
				}
			}

			builder.Append(new String(orig));
			builder.Append("\n");
			for (int i = 0; i!= p_adj; ++i) {
				builder.Append(".");
			}
			builder.Append ("^");


			b.position(p); // restore position
			*/
			
			return builder.ToString();

		}
	}
}
