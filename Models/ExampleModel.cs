using System.ComponentModel.DataAnnotations;
using System;

namespace tdg_demo.Models
{
    public class ExampleModel
    {
        [Required(ErrorMessage = "Enter the Surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Enter the Forename")]
        public string Forename { get; set; }

        [Required(ErrorMessage = "Enter the Place of Birth")]
        public string PlaceOfBirth { get; set; }

        [Required(ErrorMessage = "Date of Birth must include a Day")]
        public int? DateOfBirth_Day { get; set; }

        [Required(ErrorMessage = "Date of Birth must include a Month")]
        public int? DateOfBirth_Month { get; set; }

        [Required(ErrorMessage = "Date of Birth must include a Year")]
        public int? DateOfBirth_Year { get; set; }

        [Required(ErrorMessage = "Answer yes if you were born in Northern Ireland")]
        public bool? BornInNI { get; set; }
    }
}