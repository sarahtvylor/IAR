using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IAR 
{
    public class NetworkAddress 
    {

        // Variables to store IPv4 and/or IPv6 address of an asset.
        [JsonProperty("ipv4")]
        public IList<int> IPv4 { get; set; }

        [JsonProperty("ipv6")]
        public IList<string> IPv6 { get; set; }


        // Constructor for an asset with a IPv4 address only.
        public NetworkAddress(IList<int> IPv4) 
        {
            this.IPv4 = IPv4;
        }

        // Constructor for an asset with a IPv6 address only.
        public NetworkAddress(IList<string> IPv6) 
        {
            this.IPv6 = IPv6;
        }

        // Constructor for an asset with both a IPv4 and IPv6 address.
        public NetworkAddress(IList<int> IPv4, IList<string> IPv6) 
        {
            this.IPv4 = IPv4;
            this.IPv6 = IPv6;
        }
    }
}