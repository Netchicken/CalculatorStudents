using CalculatorStudents.Operations;

using System.ComponentModel.DataAnnotations;

namespace CalculatorStudents.DTO
{
    public class Calculator
    {
        [Display(Name = "Enter First Number")]
        public string? NumberA { get; set; }
        [Display(Name = "Enter Second Number")]
        public string? NumberB { get; set; }
        [Display(Name = "Your Answer is...")]
        public double Result { get; set; }

        [Display(Name = "Choose and Operation")]
        public string? Operation { get; set; }

        public EnumOperationType OperationType { get; set; }


    }
}
