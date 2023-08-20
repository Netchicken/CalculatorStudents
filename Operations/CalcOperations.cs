namespace CalculatorStudents.Operations
{

    public class CalcOperations : CalcOperationsAllMethods
    {

        //this is a pure method!
        public double Calculation(double NumberAd, double NumberBd, EnumOperationType OperationType)
        {
            if (OperationType == EnumOperationType.Addition)
            {
                return Add(NumberAd, NumberBd);
            }
            else if (OperationType == EnumOperationType.Subtraction)
            {
                return Subtract(NumberAd, NumberBd);
            }
            else if (OperationType == EnumOperationType.Division)
            {
                return Division(NumberAd, NumberBd);
            }
            else if (OperationType == EnumOperationType.Multiplication)
            {
                return Multiply(NumberAd, NumberBd);
            }
            return 0;
        }
    }
}
