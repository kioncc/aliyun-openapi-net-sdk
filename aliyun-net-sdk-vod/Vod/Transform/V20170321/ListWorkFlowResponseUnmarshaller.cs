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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class ListWorkFlowResponseUnmarshaller
    {
        public static ListWorkFlowResponse Unmarshall(UnmarshallerContext context)
        {
			ListWorkFlowResponse listWorkFlowResponse = new ListWorkFlowResponse();

			listWorkFlowResponse.HttpResponse = context.HttpResponse;
			listWorkFlowResponse.RequestId = context.StringValue("ListWorkFlow.RequestId");

			List<ListWorkFlowResponse.ListWorkFlow_WorkFlowInfo> listWorkFlowResponse_workFlowInfoList = new List<ListWorkFlowResponse.ListWorkFlow_WorkFlowInfo>();
			for (int i = 0; i < context.Length("ListWorkFlow.WorkFlowInfoList.Length"); i++) {
				ListWorkFlowResponse.ListWorkFlow_WorkFlowInfo workFlowInfo = new ListWorkFlowResponse.ListWorkFlow_WorkFlowInfo();
				workFlowInfo.WorkFlowId = context.StringValue("ListWorkFlow.WorkFlowInfoList["+ i +"].WorkFlowId");
				workFlowInfo.Name = context.StringValue("ListWorkFlow.WorkFlowInfoList["+ i +"].Name");
				workFlowInfo.ActionList = context.StringValue("ListWorkFlow.WorkFlowInfoList["+ i +"].ActionList");
				workFlowInfo.CreationTime = context.StringValue("ListWorkFlow.WorkFlowInfoList["+ i +"].CreationTime");
				workFlowInfo.ModifyTime = context.StringValue("ListWorkFlow.WorkFlowInfoList["+ i +"].ModifyTime");

				listWorkFlowResponse_workFlowInfoList.Add(workFlowInfo);
			}
			listWorkFlowResponse.WorkFlowInfoList = listWorkFlowResponse_workFlowInfoList;
        
			return listWorkFlowResponse;
        }
    }
}