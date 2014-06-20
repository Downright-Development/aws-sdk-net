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
    /// A section of the response body that provides information about the job that is   
    ///         created.
    /// </summary>
    public partial class Job
    {
        private string _arn;
        private string _id;
        private JobInput _input;
        private JobOutput _output;
        private string _outputKeyPrefix;
        private List<JobOutput> _outputs = new List<JobOutput>();
        private string _pipelineId;
        private List<Playlist> _playlists = new List<Playlist>();
        private string _status;


        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the job.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }


        /// <summary>
        /// Sets the Arn property
        /// </summary>
        /// <param name="arn">The value to set for the Arn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Job WithArn(string arn)
        {
            this._arn = arn;
            return this;
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }


        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The identifier that Elastic Transcoder assigned to the job. You use this value to
        /// get settings for the            job or to delete the job. 
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }


        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Job WithId(string id)
        {
            this._id = id;
            return this;
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }


        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        ///  A section of the request or response body that provides information about the file
        /// that            is being transcoded.
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
        public Job WithInput(JobInput input)
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
        /// <para>
        /// If you specified one output for a job, information about that output. If you specified
        ///            multiple outputs for a job, the Output object lists information about the
        /// first output.            This duplicates the information that is listed for the first
        /// output in the Outputs            object.
        /// </para>
        ///         
        /// <para>
        /// <important>Outputs recommended instead.</important> A section of the request or response
        ///            body that provides information about the transcoded (target) file. 
        /// </para>
        /// </summary>
        public JobOutput Output
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
        public Job WithOutput(JobOutput output)
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
        /// files that this job            creates, including output files, thumbnails, and playlists.
        /// We recommend that you add a            / or some other delimiter to the end of the
        /// <code>OutputKeyPrefix</code>.
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
        public Job WithOutputKeyPrefix(string outputKeyPrefix)
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
        /// Information about the output files. We recommend that you use the <code>Outputs</code>
        ///            syntax for all jobs, even when you want Elastic Transcoder to transcode
        /// a file into only            one format. Do not use both the <code>Outputs</code> and
        /// <code>Output</code> syntaxes in            the same request. You can create a maximum
        /// of 30 outputs per job. 
        /// </para>
        ///         
        /// <para>
        ///  If you specify more than one output for a job, Elastic Transcoder creates the files
        /// for            each output in the order in which you specify them in the job.
        /// </para>
        /// </summary>
        public List<JobOutput> Outputs
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
        public Job WithOutputs(params JobOutput[] outputs)
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
        public Job WithOutputs(IEnumerable<JobOutput> outputs)
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
        ///  The <code>Id</code> of the pipeline that you want Elastic Transcoder to use for transcoding.
        /// The            pipeline determines several settings, including the Amazon S3 bucket
        /// from which Elastic Transcoder gets the            files to transcode and the bucket
        /// into which Elastic Transcoder puts the transcoded files. 
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
        public Job WithPipelineId(string pipelineId)
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
        /// <important>Outputs in MPEG-TS format only.</important>If you specify a preset in 
        ///               <code>PresetId</code> for which the value of <code>Container</code>
        /// is ts (MPEG-TS),                <code>Playlists</code> contains information about
        /// the master playlists that you want            Elastic Transcoder to create.
        /// </para>
        ///         
        /// <para>
        /// We recommend that you create only one master playlist. The maximum number of master
        ///            playlists in a job is 30. 
        /// </para>
        /// </summary>
        public List<Playlist> Playlists
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
        public Job WithPlaylists(params Playlist[] playlists)
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
        public Job WithPlaylists(IEnumerable<Playlist> playlists)
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


        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the job: <code>Submitted</code>, <code>Progressing</code>, <code>Complete</code>,
        ///                <code>Canceled</code>, or <code>Error</code>. 
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }


        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Job WithStatus(string status)
        {
            this._status = status;
            return this;
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}