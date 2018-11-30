/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class CreateUploadAttachedMediaResponse : AcsResponse
	{

		private string requestId;

		private string mediaId;

		private string mediaURL;

		private string uploadAddress;

		private string uploadAuth;

		private string fileURL;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string MediaId
		{
			get
			{
				return mediaId;
			}
			set	
			{
				mediaId = value;
			}
		}

		public string MediaURL
		{
			get
			{
				return mediaURL;
			}
			set	
			{
				mediaURL = value;
			}
		}

		public string UploadAddress
		{
			get
			{
				return uploadAddress;
			}
			set	
			{
				uploadAddress = value;
			}
		}

		public string UploadAuth
		{
			get
			{
				return uploadAuth;
			}
			set	
			{
				uploadAuth = value;
			}
		}

		public string FileURL
		{
			get
			{
				return fileURL;
			}
			set	
			{
				fileURL = value;
			}
		}
	}
}