using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SDL_Test.DBContext
{
    public class Customers
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int Id { get; set; }
        [Column("Customers", TypeName = "Varchar(250)")]
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
