

namespace HttpParser {

	enum State {

		dead               

		, start_res_or_res
		, res_or_resp_H
		, start_res
		, res_H
		, res_HT
		, res_HTT
		, res_HTTP
		, res_first_http_major
		, res_http_major
		, res_first_http_minor
		, res_http_minor
		, res_first_status_code
		, res_status_code
		, res_status
		, res_line_almost_done
		
		, start_req
		
		, req_method
		, req_spaces_before_url
		, req_schema
		, req_schema_slash
		, req_schema_slash_slash
		, req_host
		, req_port
		, req_path
		, req_query_string_start
		, req_query_string
		, req_fragment_start
		, req_fragment
		, req_http_start
		, req_http_H
		, req_http_HT
		, req_http_HTT
		, req_http_HTTP
		, req_first_http_major
		, req_http_major
		, req_first_http_minor
		, req_http_minor
		, req_line_almost_done

		, header_field_start
		, header_field
		, header_value_start
		, header_value

		, header_almost_done

		, headers_almost_done

		, chunk_size_start
		, chunk_size
		, chunk_size_almost_done
		, chunk_parameters
		, chunk_data
		, chunk_data_almost_done
		, chunk_data_done

		, body_identity
		, body_identity_eof
	}

}

