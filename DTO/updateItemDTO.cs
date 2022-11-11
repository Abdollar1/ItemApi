using System.ComponentModel.DataAnnotations;

namespace firstApi.DTO
{
    public record updateItemDTO
    {
        [Required]
        public string name { get; set; }
        [Required]
        [Range(1, 100000)]   
        public int price { get; set; }

    }
}
