using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IAR {

    public class Security {

        [JsonProperty("cia")]
        public IList<string> CIA { get; set; }

        [JsonProperty("data_categories")]
        public DataCategories DataCategories { get; set; }

        public Security(IList<string> CIA, DataCategories DataCategories) {
            this.CIA = CIA;
            this.DataCategories = DataCategories;
        }
    }
}