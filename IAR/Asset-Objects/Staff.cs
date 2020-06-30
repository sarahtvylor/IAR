using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IAR {

    public class Staff {

        [JsonProperty("id")]
        public string EmployeeID { get; set; }

        [JsonProperty("name")]
        public IList<string> EmployeeName { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("server_admin")]
        public bool IsServerAdmin { get; set; }

        public Staff(string EmployeeID, IList<string> EmployeeName, string Department, bool IsServerAdmin) {
            this.EmployeeID = EmployeeID;
            this.EmployeeName = EmployeeName;
            this.Department = Department;
            this.IsServerAdmin = IsServerAdmin;
        }
    }
}