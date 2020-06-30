using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IAR {

    public class Location {

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("place")]
        public string Place { get; set; }

        [JsonProperty("address")]
        public IList<string> Address { get; set; }

        public Location(string Category, string Place, IList<string> Address) {
            this.Category = Category;
            this.Place = Place;
            this.Address = Address;
        }
    }
}