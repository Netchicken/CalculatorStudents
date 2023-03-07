

using CalculatorStudents.DTO;
using CalculatorStudents.Operations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculatorStudents.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        //This calls in the calculations from the CalcOperations.cs
        public CalcOperations calc { get; set; }

        //This calls in the properties from the Calculator.cs
        public Calculator calculator { get; set; }

        public void OnPostAsync()
        {
            //convert the string numbers to doubles for processing 
            double NumberAd = Convert.ToDouble(calculator.NumberA);
            double NumberBd = Convert.ToDouble(calculator.NumberB);

            //run the calculation and return back the result
            calculator.Result = calc.Calculation(NumberAd, NumberBd, calculator.OperationType);

        }
    }
}