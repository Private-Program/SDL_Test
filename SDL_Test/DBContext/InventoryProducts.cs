using System.ComponentModel.DataAnnotations;

namespace SDL_Test.DBContext
{
    public class InventoryProducts
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public int Rate { get; set; }
        public int Qty { get; set; }
        public int Discount { get; set; }
    }
}
