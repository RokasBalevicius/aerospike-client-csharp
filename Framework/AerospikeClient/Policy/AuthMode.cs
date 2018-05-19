/* 
 * Copyright 2012-2018 Aerospike, Inc.
 *
 * Portions may be licensed to Aerospike, Inc. under one or more contributor
 * license agreements.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 */
namespace Aerospike.Client
{
	/// <summary>
	/// Authentication mode when user/password is defined.
	/// </summary>
	public enum AuthMode
	{
		/// <summary>
		/// Use internal authentication only.  Hashed password is stored on the server.
		/// Do not send clear password. This is the default.
		/// </summary>
		INTERNAL,

		/// <summary>
		/// Use external authentication (like LDAP).  Specific external authentication is
		/// configured on server.  If TLS defined, send clear password on node login via TLS.
		/// Throw exception if TLS is not defined.
		/// </summary>
		EXTERNAL,

		/// <summary>
		/// Use external authentication (like LDAP).  Specific external authentication is
		/// configured on server.  Send clear password on node login whether or not TLS is defined.
		/// This mode should only be used for testing purposes because it is not secure
		/// authentication.
		/// </summary>
		EXTERNAL_INSECURE
	}	
}