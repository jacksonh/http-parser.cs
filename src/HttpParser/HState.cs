

namespace HttpParser {

	enum HState {
		general
		, C
		, CO
		, CON
		
		, matching_connection
		, matching_proxy_connection
		, matching_content_length
		, matching_transfer_encoding
		, matching_upgrade
		
		, connection
		, content_length
		, transfer_encoding
		, upgrade
		
		, matching_transfer_encoding_chunked
		, matching_connection_keep_alive
		, matching_connection_close
		
		, transfer_encoding_chunked
		, connection_keep_alive
		, connection_close
	}
}
