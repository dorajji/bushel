using System;
using System.ComponentModel.DataAnnotations;

namespace bushel.Models
{
    public class Wishlist
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public DateTime DateAdded { get; set; }
        
        public virtual Product Product { get; set; }
    }
} 