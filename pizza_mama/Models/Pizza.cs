using System.ComponentModel.DataAnnotations;

namespace pizza_mama.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        [Display(Name = "Nom")]
        public string name { get; set; }
        [Display(Name = "Price")]
        public float price { get; set; }
        [Display(Name = "Veggy")]
        public bool vegan { get; set; }
        [Display(Name = "Ingredients")]
        public string ingredients { get; set; }
    }
}
