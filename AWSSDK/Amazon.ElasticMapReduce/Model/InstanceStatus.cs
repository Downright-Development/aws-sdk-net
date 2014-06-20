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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The instance status details.
    /// </summary>
    public partial class InstanceStatus
    {
        private string _state;
        private InstanceStateChangeReason _stateChangeReason;
        private InstanceTimeline _timeline;


        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the instance.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }


        /// <summary>
        /// Sets the State property
        /// </summary>
        /// <param name="state">The value to set for the State property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceStatus WithState(string state)
        {
            this._state = state;
            return this;
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }


        /// <summary>
        /// Gets and sets the property StateChangeReason. 
        /// <para>
        /// The details of the status change reason for the instance.
        /// </para>
        /// </summary>
        public InstanceStateChangeReason StateChangeReason
        {
            get { return this._stateChangeReason; }
            set { this._stateChangeReason = value; }
        }


        /// <summary>
        /// Sets the StateChangeReason property
        /// </summary>
        /// <param name="stateChangeReason">The value to set for the StateChangeReason property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceStatus WithStateChangeReason(InstanceStateChangeReason stateChangeReason)
        {
            this._stateChangeReason = stateChangeReason;
            return this;
        }

        // Check to see if StateChangeReason property is set
        internal bool IsSetStateChangeReason()
        {
            return this._stateChangeReason != null;
        }


        /// <summary>
        /// Gets and sets the property Timeline. 
        /// <para>
        /// The timeline of the instance status over time.
        /// </para>
        /// </summary>
        public InstanceTimeline Timeline
        {
            get { return this._timeline; }
            set { this._timeline = value; }
        }


        /// <summary>
        /// Sets the Timeline property
        /// </summary>
        /// <param name="timeline">The value to set for the Timeline property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceStatus WithTimeline(InstanceTimeline timeline)
        {
            this._timeline = timeline;
            return this;
        }

        // Check to see if Timeline property is set
        internal bool IsSetTimeline()
        {
            return this._timeline != null;
        }

    }
}