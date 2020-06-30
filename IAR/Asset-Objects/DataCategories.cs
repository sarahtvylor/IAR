using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IAR {

    public class DataCategories {

        [JsonProperty("Personal")]
        public bool Personal { get; set; }

        [JsonProperty("Personal Sensitive")]
        public bool PersonalSensitive { get; set; }

        [JsonProperty("Customer Sensitive")]
        public bool CustomerSensitive { get; set; }

        public DataCategories(bool Personal, bool PersonalSensitive, bool CustomerSensitive) {
            this.Personal = Personal;
            this.PersonalSensitive = PersonalSensitive;
            this.CustomerSensitive = CustomerSensitive;
        }
    }
}