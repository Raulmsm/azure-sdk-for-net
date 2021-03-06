// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;

namespace Microsoft.WindowsAzure.Management.Network.Models
{
    /// <summary>
    /// A reserved IP associated with your subscription.
    /// </summary>
    public partial class NetworkReservedIPGetResponse : AzureOperationResponse
    {
        private string _address;
        
        /// <summary>
        /// Optional. The IP address of the reserved IP.
        /// </summary>
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }
        
        private string _deploymentName;
        
        /// <summary>
        /// Optional. The name of the deployment the IP belongs to, if used.
        /// </summary>
        public string DeploymentName
        {
            get { return this._deploymentName; }
            set { this._deploymentName = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Optional. A unique string identifier that represents the reserved
        /// IP.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private bool _inUse;
        
        /// <summary>
        /// Optional. The indicator of whether the reserved IP is used.
        /// </summary>
        public bool InUse
        {
            get { return this._inUse; }
            set { this._inUse = value; }
        }
        
        private string _label;
        
        /// <summary>
        /// Optional. The friendly identifier of the site.
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// Optional. Location where the virtual network exists.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Name of the reserved IP.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _serviceName;
        
        /// <summary>
        /// Optional. The name of the service the IP belongs to, if used.
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Optional. Current status of the reserved IP. (Created, Creating,
        /// Updating, Deleting, or Unavailable.)
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the NetworkReservedIPGetResponse
        /// class.
        /// </summary>
        public NetworkReservedIPGetResponse()
        {
        }
    }
}
