/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StepExecutionStatusDetail Object
    /// </summary>  
    public class StepExecutionStatusDetailUnmarshaller : IUnmarshaller<StepExecutionStatusDetail, XmlUnmarshallerContext>, IUnmarshaller<StepExecutionStatusDetail, JsonUnmarshallerContext>
    {
        StepExecutionStatusDetail IUnmarshaller<StepExecutionStatusDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public StepExecutionStatusDetail Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            
            var unmarshalledObject = new StepExecutionStatusDetail();
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                    context.Read();
                    context.Read();
                    if (context.TestExpression("CreationDateTime", targetDepth))
                    {
                        unmarshalledObject.CreationDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EndDateTime", targetDepth))
                    {
                        unmarshalledObject.EndDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LastStateChangeReason", targetDepth))
                    {
                        unmarshalledObject.LastStateChangeReason = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StartDateTime", targetDepth))
                    {
                        unmarshalledObject.StartDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("State", targetDepth))
                    {
                        unmarshalledObject.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return unmarshalledObject;
                }
            }          
            return unmarshalledObject;
        }


        private static StepExecutionStatusDetailUnmarshaller instance;
        public static StepExecutionStatusDetailUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new StepExecutionStatusDetailUnmarshaller();
            }
            return instance;
        }

    }
}