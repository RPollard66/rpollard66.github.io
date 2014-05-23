using System.ComponentModel.DataAnnotations;

namespace AppLabsMVC.Models.Level2
{
    public class PalindromeRequest
    {
        [Required(ErrorMessage = "You must enter a word")]
        public string UserChoice { get; set; }
        

    }
}