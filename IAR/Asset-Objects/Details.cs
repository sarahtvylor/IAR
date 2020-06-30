using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IAR 
{
    public class Details 
    {

        // Variables to store security details, retention, and location of an asset.
        [JsonProperty("security")]
        public Security SecurityDetails { get; set; }

        [JsonProperty("retention")]
        public float Retention { get; set; }

        [JsonProperty("location")]
        public Location LocationDetails { get; set; }


        // Constructor for Details specific to a File Asset.
        public Details(Security SecurityDetails, float Retention) 
        {
            this.SecurityDetails = SecurityDetails;
            this.Retention = Retention;
        }

        // Constructor for Details specific to a Server Asset.
        public Details(Security SecurityDetails, Location LocationDetails) 
        {
            this.SecurityDetails = SecurityDetails;
            this.LocationDetails = LocationDetails;
        }

        // Constructor for Details specific to a PhysicalMedia Asset.
        public Details(Security SecurityDetails, float Retention, Location LocationDetails) 
        {
            this.SecurityDetails = SecurityDetails;
            this.Retention = Retention;
            this.LocationDetails = LocationDetails;
        }
    }
}