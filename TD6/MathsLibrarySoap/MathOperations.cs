namespace MathsLibrary
{
    public class MathOperations : IMathsOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public float Div(int a, int b)
        {
            return (float) a / (float) b;
        }
    }
}
