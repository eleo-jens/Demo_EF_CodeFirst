using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("Role")]
    public class Role
    {
        [Column("id")]
        public int RoleId { get; set; }
        //[MaxLength(50)]
        [Column("Nom")]
        public string Name { get; set; }
    }
}
