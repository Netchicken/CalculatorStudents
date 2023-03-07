

using CalculatorStudents.Operations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.ComponentModel.DataAnnotations;

namespace CalculatorStudents.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
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

        public void OnGet()
        {

        }

        public void OnPostAsync()
        {
            double NumberAd = Convert.ToDouble(NumberA);
            double NumberBd = Convert.ToDouble(NumberB);

            if (OperationType == EnumOperationType.Addition)
            {
                Result = NumberAd + NumberBd;
            }
            else if (OperationType == EnumOperationType.Subtraction)
            {
                Result = NumberAd - NumberBd;
            }
            else if (OperationType == EnumOperationType.Division)
            {
                Result = NumberAd / NumberBd;
            }
            else if (OperationType == EnumOperationType.Multiplication)
            {
                Result = NumberAd * NumberBd;
            }


        }
    }
}