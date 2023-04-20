using System.ComponentModel.DataAnnotations;

namespace KinKanMai.Models
{
    public class Kinkanmai
    {
        [Key]
        public int GroupID { get; set; }
        public int OrderID { get; set; }
        [Required]
        public string SenderName { get; set; }
        [Required]
        public string CanteenName { get; set; }
        [Required]
        public string FoodName { get; set; }
        public string Detail { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public int Cost { get; set; }
        [Required]
        public string ReceiveName { get; set; }
        public bool OrderStatus { get; set; }
    }
}
