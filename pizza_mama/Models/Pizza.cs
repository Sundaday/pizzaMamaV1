namespace pizza_mama.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public bool vegan { get; set; }
        public string ingredients { get; set; }
    }
}
