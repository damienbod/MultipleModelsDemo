using System.ComponentModel.DataAnnotations;

namespace MultipleModelsDemo.ViewModels
{
    public class TestTwoModel
    {
        [Required]
        public string PropertyThree { get; set; }

        [Required]
        public string PropertyFour { get; set; }
    }
}