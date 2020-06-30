using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IAR {

    public class JSONFile {

        [JsonProperty("staff")]
        public IList<string> Staff { get; set; }

        [JsonProperty("assets")]
        public IList<string> Assets { get; set; }

        public JSONFile(IList<string> Staff, IList<string> Assets) {
            this.Staff = Staff;
            this.Assets = Assets;
        }
    }
}