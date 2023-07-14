using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SDL_Test.DBContext
{
    public class Inventories
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int BillNo { get; set; }
        public int CustomerId { get; set; }
        public int TotalDiscount { get; set; }
        public int TotalBillAmount { get; set; }
        public int DueAmount { get; set; }
        public int PaidAmount { get; set; }
    }
}
