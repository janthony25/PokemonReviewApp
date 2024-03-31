﻿namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int PokemonId { get; set;}
        public ICollection<Review> Reviews { get; set; }
    }
}
