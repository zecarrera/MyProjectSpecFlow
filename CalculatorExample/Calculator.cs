namespace CalculatorExample
{
    public class Calculator
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        

        public double Add()
        {
            return FirstNumber + SecondNumber;
        }

        public double Multiply()
        {
            return FirstNumber * SecondNumber;
        }

    }
}
