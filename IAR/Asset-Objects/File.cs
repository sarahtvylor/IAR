using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IAR {

    public class File : Asset {

        [JsonProperty("file_type")]
        public string FileType { get; set; }

        public Location Location { get; set; }

        public File(string Name, string AssetType, string Owner, Details Details, string FileType, Location Location) 
                : base(Name, FileType, Owner, Details) {
            
            this.FileType = FileType;
            this.Location = Location;
        }
    }
}