using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.db.Data.Models
{
    public class WebUsers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id", TypeName = "int")]
        public int id { get; set; }
        public string CompanyCode { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
        public string EmailID { get; set; }
        public int Status { get; set; }
    }
}
