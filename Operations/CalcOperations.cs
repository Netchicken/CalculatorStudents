namespace CalculatorStudents.Operations
{
    public class CalcOperations
    {

        //this is a pure method!
        public double Calculation(double NumberAd, double NumberBd, EnumOperationType OperationType)
        {
            if (OperationType == EnumOperationType.Addition)
            {
                return NumberAd + NumberBd;
            }
            else if (OperationType == EnumOperationType.Subtraction)
            {
                return NumberAd - NumberBd;
            }
            else if (OperationType == EnumOperationType.Division)
            {
                return NumberAd / NumberBd;
            }
            else if (OperationType == EnumOperationType.Multiplication)
            {
                return NumberAd * NumberBd;
            }
            return 0;
        }

    }
}
