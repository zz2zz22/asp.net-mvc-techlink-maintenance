using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace aspdotnet_webapp_techlink_maintenance.Models
{
    [Table("Device_Info")]
    public class Device_Info
    {
        [Key]
        [Required]
        public string device_uuid { get; set; }
        public string device_code { get; set; }
        public string device_name { get; set; }
        public string device_location { get; set; }
        public string device_floor { get; set; }
        public string device_manager { get; set; }
        public string device_group_uuid { get; set; }
        public string device_STT { get; set; }
        public string device_type_uuid { get; set; }
        public string device_type_name { get; set; }
        public string maximum_exp_date { get; set; }
        public string newest_maintenance_info { get; set; }
        public string newest_maintenance_date { get; set; }
        public string expire_date { get; set; }
        public int isNearExpDate { get; set; }
        public int isOverExpDate { get; set; }
    }
}