using System.ComponentModel.DataAnnotations;

namespace APICreation1.Model
{
    public class Product
    {
        [Key]
        public int pid { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int stock { get; set; }

    }
}
