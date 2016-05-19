namespace CalculatorExample
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public double Multiply()
        {
            return FirstNumber * SecondNumber;
        }

    }
}
