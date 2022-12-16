using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspdotnet_webapp_techlink_maintenance.Models
{
    [Table("PCCC_Record")]
    public class PCCC_Record
    {
        [Key]
        [Required]
        public string uuid { get; set; }
        [Required]
        public string barcode { get; set; }
        public string maintenance_type { get; set; }
        public string maintenance_type_name { get; set; }
        public string remark { get; set; }
        public string update_date { get; set; }
    }
}