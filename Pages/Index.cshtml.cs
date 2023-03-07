

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

        public CalcOperations calc { get; set; }

        public void OnGet()
        {

        }

        public void OnPostAsync()
        {
            double NumberAd = Convert.ToDouble(NumberA);
            double NumberBd = Convert.ToDouble(NumberB);

            Result = calc.Calculation(NumberAd, NumberBd, OperationType);


            //357.345
            //  Result = Calculation(123, 234.345, EnumOperationType.Addition);

        }

        //this is a pure method!
        //private double Calculation(double NumberAd, double NumberBd, EnumOperationType OperationType)
        //{
        //    if (OperationType == EnumOperationType.Addition)
        //    {
        //        return NumberAd + NumberBd;
        //    }
        //    else if (OperationType == EnumOperationType.Subtraction)
        //    {
        //        return NumberAd - NumberBd;
        //    }
        //    else if (OperationType == EnumOperationType.Division)
        //    {
        //        return NumberAd / NumberBd;
        //    }
        //    else if (OperationType == EnumOperationType.Multiplication)
        //    {
        //        return NumberAd * NumberBd;
        //    }
        //    return 0;
        //}


    }
}