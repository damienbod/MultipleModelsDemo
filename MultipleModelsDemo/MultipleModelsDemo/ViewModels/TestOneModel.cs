using System.ComponentModel.DataAnnotations;

namespace MultipleModelsDemo.ViewModels
{
    public class TestOneModel
    {
        [Required]
        public string PropertyOne { get; set; }

        [Required]
        public string PropertyTwo { get; set; }
    }
}