using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dashboard.server.Models
{
    [Table("ApiAccess")]
    public class ApiAccess
    {
        [Key]
        public long SysId { get; set; }
        public DateTime CreatedAt { get; set; }
        public String ApiKey { get; set; }
        public String User {  get; set; }
        public String Type { get; set; }
        public Boolean IsActive { get; set; }
    }
}
