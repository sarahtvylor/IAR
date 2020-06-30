using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IAR {

    public class Asset {

        [JsonProperty("asset_name")]
        public string Name { get; set; }

        [JsonProperty("asset_type")]
        public string AssetType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("details")]
        public Details AssetDetails { get; set; }

        public Asset(string Name, string AssetType, string Owner, Details AssetDetails) {
            this.Name = Name;
            this.AssetType = AssetType;
            this.Owner = Owner;
            this.AssetDetails = AssetDetails;
        }
    }
}