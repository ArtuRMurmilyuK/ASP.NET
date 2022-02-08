using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SneakerShop.Data.Models
{
    public class SizeSneaker
    {
        public int Id { get; set; }
        public int SneakerId { get; set; }
        public int Size { get; set; }
        public int Amount { get; set; }
    }
}