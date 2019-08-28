using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace GameStore.Domain.Entities
{
    public class Game
    {
        [HiddenInput(DisplayValue = false)]
        public int GameID { get; set; }

        [Display(Name = "Назва")]
        [Required(ErrorMessage = "Будь ласка, введіть назву гри")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Опис")]
        [Required(ErrorMessage = "Будь ласка, введіть опис для гри")]
        public string Description { get; set; }

        [Display(Name = "Категорія")]
        [Required(ErrorMessage = "Будь ласка, введіть категорію для гри")]
        public string Category { get; set; }

        [Display(Name = "Ціна (грн)")]
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Будь ласка, введіть додатнє значення для ціни")]
        public decimal Price { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
    }
}
