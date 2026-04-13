namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 박싱
            // 값 타입을 객체로 변환하여 관리되는 힙 영역에 새로운 객체를
            // 만들고 복사하는 과정입니다.
            //
            //int count = 8;
            //object clone = count;
            //
            //Console.WriteLine("count : " + count);
            //Console.WriteLine("clone : " + clone);            
            #endregion

            #region 언박싱
            // 관리되는 힙에 있는 박싱되어있는 객체에서 값을 꺼내
            // 값타입으로 복사하는 과정입니다.
            //
            //long experience = 2000;
            //object adress = experience;
            //
            //long data = (long)adress;
            //
            //Console.WriteLine("experience : " + experience);
            //Console.WriteLine("adress : " + adress);
            //Console.WriteLine("data : " + data);
            #endregion
        }
    }
}