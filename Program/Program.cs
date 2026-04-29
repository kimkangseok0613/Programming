

namespace Program
{  
    internal class Program
    {
        delegate float Operation(float x, float y);
        static float Add(float x, float y)
        {
            return x + y;
        }
        static float Subtract(float x, float y)
        {
            return x - y;
        }
        static float Multifly(float x, float y)
        {
            return x * y;
        }
        static float Divide(float x, float y)
        {
            return x / y;
        }
        void Execute(Operation operation)
        {
            int result <- operation;
        }
        static void Main(string[] args)
        {
            #region 대리자
            // 특정한 함수를 가진 함수를 참조할 수 있는 참조 타입입니다.

            Operation operation;

            operation = Add;
            Console.WriteLine(operation(5, 5));

            operation = Subtract;
            Console.WriteLine(operation(5, 5));

            operation = Multifly;
            Console.WriteLine(operation(5, 5));

            operation = Divide;
            Console.WriteLine(operation(5, 5));

            #endregion
        }

        
    }
}