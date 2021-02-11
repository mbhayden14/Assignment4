using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment4FoodApp.Models
{
    public class ApplicationResponse
    {
        [Required(ErrorMessage = "Please enter a ranking.")]
        public int RestRanking { get; set; }
        [Required(ErrorMessage = "Please enter a name.")]
        public string RestName { get; set; }
        public string FavDish { get; set; } = "It's all tasty!";

        [RegularExpression("((\\(\\d{3}\\))|(\\d{3}-))\\d{3}-\\d{4}")]
        public string RestPhone { get; set; }
    }
}

