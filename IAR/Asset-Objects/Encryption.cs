using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IAR {

    public class Encryption {

        [JsonProperty("cipher")]
        public string Cipher { get; set; }

        [JsonProperty("keylength")]
        public int Keylength { get; set; }

        public Encryption(string Cipher, int Keylength) {
            this.Cipher = Cipher;
            this.Keylength = Keylength;
        }
    }
}