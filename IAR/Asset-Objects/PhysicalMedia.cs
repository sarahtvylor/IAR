using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IAR
{
    public class PhysicalMedia : Asset 
    {
        
        // Variables to store media type and encryption details specific to a physical media asset.
        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("encryption")]
        public Encryption Encryption { get; set; }


        // Constructor for a physical media asset without encryption details.
        public PhysicalMedia(string Name, string AssetType, string Owner, Details AssetDetails, 
            string MediaType) : base(Name, AssetType, Owner, AssetDetails) 
        {
            this.MediaType = MediaType;
        }

        // Constructor for a physical media asset with encryption details.
        public PhysicalMedia(string Name, string AssetType, string Owner, Details AssetDetails, 
            string MediaType, Encryption Encryption) : base(Name, AssetType, Owner, AssetDetails) 
        {
            this.MediaType = MediaType;
            this.Encryption = Encryption;
        }
    }
}