using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDL_Test.DBContext
{
    public class Products
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int Id { get; set; }
        [Column("Products", TypeName ="Varchar(250)")]
        public string Name { get; set; }
        public string Code { get; set; }
        public int Rate { get; set; }
    }
}
