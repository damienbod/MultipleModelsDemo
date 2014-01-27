using System.ComponentModel.DataAnnotations;

namespace MultipleModelsDemo.ViewModels
{
    public class IndexViewModel
    {
        public string HeaderText { get; set; }

        public TestOneModel TestOne { get; set; }

        public TestTwoModel TestTwo { get; set; }
    }
}