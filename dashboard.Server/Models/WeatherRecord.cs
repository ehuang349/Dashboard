using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dashboard.server.Models
{
    [Table("vw_WeatherRecords")]
    public class WeatherRecord
    {
        [Key]
        public long SysId { get; set; }
        public String City { get; set; }
        public float Temperature { get; set; }
        public String WeatherDescription { get; set; }
        public DateTime Date { get; set; }
    }
}
