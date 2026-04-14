using System.Transactions;

namespace Program
{
    public class Circle
    {
        public int x;
        public int y;
        public float radius;
        public Circle()
        {
            Console.WriteLine("Created Circle");
        }
    }
    internal class Program
    {
        static void Collide(Circle origin, Circle other)
        {
            float deltaX = origin.x - other.x;
            float deltaY = origin.y - other.y;

            float radius = (origin.radius + other.radius) * (origin.radius + other.radius);

            if (deltaX * deltaX + deltaY * deltaY <= radius)
            {
                Console.WriteLine("충돌O");
            }
            else
            {
                Console.WriteLine("충돌X");
            }
        }

        static void Main(string[] args)
        {
            #region 매개 변수 한정
            // 인수가 함수에 전달되는 방식과 사용 규칙을 제어하는 한정자입니다.

            Circle circle = new Circle(); // Circle circle = new();

            circle.x=5;
            circle.y=5;
            circle.radius=1.0f;

            Circle quadrant = new Circle();

            quadrant.x = 1;
            quadrant.y = 2;;
            quadrant.radius = 1.0f;

            Collide(circle, quadrant);

            #endregion
        }
    }
}