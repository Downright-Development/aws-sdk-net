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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Container for the parameters to the CreateJob operation.
    /// When you create a job, Elastic Transcoder returns JSON data that includes the values
    ///            that you specified plus information about the job that is created. 
    /// 
    ///         
    /// <para>
    /// If you have specified more than one output for your jobs (for example, one output
    /// for the            Kindle Fire and another output for the Apple iPhone 4s), you currently
    /// must use the            Elastic Transcoder API to list the jobs (as opposed to the
    /// AWS Console).
    /// </para>
    /// </summary>
    public partial class CreateJobRequest : AmazonWebServiceRequest
    {
        private JobInput _input;
        private CreateJobOutput _output;
        private string _outputKeyPrefix;
        private List<CreateJobOutput> _outputs = new List<CreateJobOutput>();
        private string _pipelineId;
        private List<CreateJobPlaylist> _playlists = new List<CreateJobPlaylist>();


        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// A section of the request body that provides information about the file that is being
        ///            transcoded.
        /// </para>
        /// </summary>
        public JobInput Input
        {
            get { return this._input; }
            set { this._input = value; }
        }


        /// <summary>
        /// Sets the Input property
        /// </summary>
        /// <param name="input">The value to set for the Input property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobRequest WithInput(JobInput input)
        {
            this._input = input;
            return this;
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }


        /// <summary>
        /// Gets and sets the property Output.
        /// </summary>
        public CreateJobOutput Output
        {
            get { return this._output; }
            set { this._output = value; }
        }


        /// <summary>
        /// Sets the Output property
        /// </summary>
        /// <param name="output">The value to set for the Output property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobRequest WithOutput(CreateJobOutput output)
        {
            this._output = output;
            return this;
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null;
        }


        /// <summary>
        /// Gets and sets the property OutputKeyPrefix. 
        /// <para>
        /// The value, if any, that you want Elastic Transcoder to prepend to the names of all
        /// files            that this job creates, including output files, thumbnails, and playlists.
        /// </para>
        /// </summary>
        public string OutputKeyPrefix
        {
            get { return this._outputKeyPrefix; }
            set { this._outputKeyPrefix = value; }
        }


        /// <summary>
        /// Sets the OutputKeyPrefix property
        /// </summary>
        /// <param name="outputKeyPrefix">The value to set for the OutputKeyPrefix property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobRequest WithOutputKeyPrefix(string outputKeyPrefix)
        {
            this._outputKeyPrefix = outputKeyPrefix;
            return this;
        }

        // Check to see if OutputKeyPrefix property is set
        internal bool IsSetOutputKeyPrefix()
        {
            return this._outputKeyPrefix != null;
        }


        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        ///  A section of the request body that provides information about the transcoded (target)
        ///            files. We recommend that you use the <code>Outputs</code> syntax instead
        /// of the                <code>Output</code> syntax. 
        /// </para>
        /// </summary>
        public List<CreateJobOutput> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        /// <summary>
        /// Sets the Outputs property
        /// </summary>
        /// <param name="outputs">The values to add to the Outputs collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobRequest WithOutputs(params CreateJobOutput[] outputs)
        {
            foreach (var element in outputs)
            {
                this._outputs.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Outputs property
        /// </summary>
        /// <param name="outputs">The values to add to the Outputs collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobRequest WithOutputs(IEnumerable<CreateJobOutput> outputs)
        {
            foreach (var element in outputs)
            {
                this._outputs.Add(element);
            }
            return this;
        }
        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && this._outputs.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property PipelineId. 
        /// <para>
        /// The <code>Id</code> of the pipeline that you want Elastic Transcoder to use for  
        ///          transcoding. The pipeline determines several settings, including the Amazon
        /// S3 bucket            from which Elastic Transcoder gets the files to transcode and
        /// the bucket into which            Elastic Transcoder puts the transcoded files.
        /// </para>
        /// </summary>
        public string PipelineId
        {
            get { return this._pipelineId; }
            set { this._pipelineId = value; }
        }


        /// <summary>
        /// Sets the PipelineId property
        /// </summary>
        /// <param name="pipelineId">The value to set for the PipelineId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobRequest WithPipelineId(string pipelineId)
        {
            this._pipelineId = pipelineId;
            return this;
        }

        // Check to see if PipelineId property is set
        internal bool IsSetPipelineId()
        {
            return this._pipelineId != null;
        }


        /// <summary>
        /// Gets and sets the property Playlists. 
        /// <para>
        /// If you specify a preset in <code>PresetId</code> for which the value of          
        ///      <code>Container</code> is ts (MPEG-TS), Playlists contains information about
        /// the            master playlists that you want Elastic Transcoder to create.
        /// </para>
        ///         
        /// <para>
        /// We recommend that you create only one master playlist. The maximum number of master
        ///            playlists in a job is 30.
        /// </para>
        /// </summary>
        public List<CreateJobPlaylist> Playlists
        {
            get { return this._playlists; }
            set { this._playlists = value; }
        }

        /// <summary>
        /// Sets the Playlists property
        /// </summary>
        /// <param name="playlists">The values to add to the Playlists collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobRequest WithPlaylists(params CreateJobPlaylist[] playlists)
        {
            foreach (var element in playlists)
            {
                this._playlists.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Playlists property
        /// </summary>
        /// <param name="playlists">The values to add to the Playlists collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobRequest WithPlaylists(IEnumerable<CreateJobPlaylist> playlists)
        {
            foreach (var element in playlists)
            {
                this._playlists.Add(element);
            }
            return this;
        }
        // Check to see if Playlists property is set
        internal bool IsSetPlaylists()
        {
            return this._playlists != null && this._playlists.Count > 0; 
        }

    }
}