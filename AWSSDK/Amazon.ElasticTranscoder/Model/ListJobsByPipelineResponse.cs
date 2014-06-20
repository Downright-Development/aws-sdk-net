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
using Amazon.Runtime;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Returns information about the ListJobsByPipelineResult response and response metadata.
    /// </summary>
    public class ListJobsByPipelineResponse : AmazonWebServiceResponse
    {
        private ListJobsByPipelineResult _listJobsByPipelineResult;

        /// <summary>
        /// Gets and sets the ListJobsByPipelineResult property.
        /// Represents the output of a ListJobsByPipeline operation.
        /// </summary>
        public ListJobsByPipelineResult ListJobsByPipelineResult
        {
            get
            {
                if(this._listJobsByPipelineResult == null)
                {
                    this._listJobsByPipelineResult = new ListJobsByPipelineResult();
                }
                return this._listJobsByPipelineResult;
            }
            set { this._listJobsByPipelineResult = value; }
        }
    }
}