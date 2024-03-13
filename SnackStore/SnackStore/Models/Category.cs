namespace SnackStore.Models
{
    public class Category
    {
        public int CatogoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public List<Snack> Snacks { get; set; }
    }
}
