using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IAR {

    public class Server : Asset {

        [JsonProperty("network_address")]
        public NetworkAddress NetworkAddress { get; set; }

        public Server(string Name, string AssetType, string Owner, Details Details, NetworkAddress NetworkAddress) 
                : base(Name, AssetType, Owner, Details) {
            this.NetworkAddress = NetworkAddress;
        }
    }
}