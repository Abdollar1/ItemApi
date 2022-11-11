using System.ComponentModel.DataAnnotations;

namespace firstApi.DTO
{
    public record createItemDTO
    {
        [Required]
        public string name { get; set; }
        [Required]
        [Range(1, 100000)]   
        public int price { get; set; }

    }
}
