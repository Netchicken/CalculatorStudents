

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

        public IndexModel()
        {


        }

        public void OnGet()
        {
            //  calc = new CalcOperations();
            //       calculator = new Calculator();

        }


        //Calculator calculator
        public void OnPostAsync()
        {
            // double NumberAd = 0;
            // double NumberBd = 0;
            try
            {
                /*  calculator.ErrorMessage = "Try is running";*/
                //convert the string numbers to doubles for processing 
                double NumberAd = Convert.ToDouble(calculator.NumberA);
                double NumberBd = Convert.ToDouble(calculator.NumberB);
                //run the calculation and return back the result
                calculator.Result = calc.Calculation(NumberAd, NumberBd, calculator.OperationType);


            }
            catch (Exception e)
            {
                calculator.ErrorMessage += " Catch is running .We have an error and it is ..." + e.ToString();


            }



        }
    }
}