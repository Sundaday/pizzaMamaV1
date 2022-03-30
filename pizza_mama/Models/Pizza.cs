using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;

namespace pizza_mama.Models
{
    public class Pizza
    {
        [JsonIgnore]
        public int PizzaId { get; set; }
        [Display(Name = "Nom")]
        public string name { get; set; }
        [Display(Name = "Price")]
        public float price { get; set; }
        [Display(Name = "Veggy")]
        public bool vegan { get; set; }
        [JsonIgnore]
        [Display(Name = "Ingredients")]
        public string ingredients { get; set; }
        [NotMapped]
        [JsonPropertyName("ingredients")]
        public string[] listIngredients
        {
            get
            {
                if((ingredients == null) || (ingredients.Count() == 0))
                {
                    return null;
                }
                return ingredients.Split(", ");
            }
        }
    }
}
