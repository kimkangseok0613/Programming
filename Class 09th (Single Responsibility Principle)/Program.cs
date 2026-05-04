using Program;

namespace Class_09th__Single_Responsibility_Principle_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 단일 책임 원칙
            // 클래스는 하나의 기능으로 수정될 수 있도록 설계해야 하는 원칙입니다.

            User user = new User("ks0006131@gmail.com", "qwerasdf");
            Persistence persistence = new Persistence();
            Authenticate authenticate = new Authenticate(persistence);

            persistence.Save(user);

            Console.WriteLine(user.email);

            // 로그인 시도
            bool result = authenticate.Execute(user);
            // 로그인 성공
            if (result)
            {
                Console.WriteLine("Login Success");
            }
            // 로그인 실패
            else
            {
                Console.WriteLine("Login Failure");
            }
            #endregion
        }
    }
}
