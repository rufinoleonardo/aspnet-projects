﻿namespace SnackStore.Models
{
    public class Snack
    {
        public int SnackId { get; set; }
        public string Name { get; set;}
        public string ShortDescription { get; set;}
        public string FullDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbnailUrlImage { get; set; }
        public bool IsFavoriteSnack { get; set; }
        public bool InStock { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
