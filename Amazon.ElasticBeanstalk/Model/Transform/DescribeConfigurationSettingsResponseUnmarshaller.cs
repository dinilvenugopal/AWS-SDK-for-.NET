/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Net;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticBeanstalk.Model.Transform
{
    /// <summary>
    ///    Response Unmarshaller for DescribeConfigurationSettings operation
    /// </summary>
    internal class DescribeConfigurationSettingsResponseUnmarshaller : IResponseUnmarshaller<DescribeConfigurationSettingsResponse, UnmarshallerContext> {

        public DescribeConfigurationSettingsResponse Unmarshall(UnmarshallerContext context) 
        {
            DescribeConfigurationSettingsResponse response = new DescribeConfigurationSettingsResponse();

            while (context.Read())
            {
                if (context.IsStartElement)
                {
                    if(context.TestExpression("DescribeConfigurationSettingsResult", 2))
                    {
                        response.DescribeConfigurationSettingsResult = DescribeConfigurationSettingsResultUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResponseMetadata", 2))
                    {
                        response.ResponseMetadata = ResponseMetadataUnmarshaller.GetInstance().Unmarshall(context);
                    }
                }
            }

            return response;
        }
        
        
        public AmazonServiceException UnmarshallException(UnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            
            return new AmazonElasticBeanstalkException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static DescribeConfigurationSettingsResponseUnmarshaller instance;

        public static DescribeConfigurationSettingsResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new DescribeConfigurationSettingsResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
