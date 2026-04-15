using System.Diagnostics.Tracing;

namespace Program
{    
    public class Puzzle
    {
        public string word;
        public Puzzle()
        {
            word = "apple";
        }        
        public void Render(in int index)
        {
            for(int i = 0; i < word.Length; i++)
            {
                if(i == index)
                {
                    Console.Write("_ ");
                }
                else
                {
                    Console.Write(word[i] + " ");
                }
            }
        }
        public void Enter(ref int health)
        {
            health--;
        }
        public void Validate(string input, out string index)
        {
            bool state = false;

            if(index == input)
            {
                state=true;
            }
        }
    }
    internal class Program
    {      
        static void Main(string[] args)
        {
            #region 매개 변수 한정
            // 인수가 함수에 전달되는 방식과 사용 규칙을 제어하는 한정자입니다.

            Puzzle puzzle = new();

            int life = 5;

            Console.WriteLine("life : " + life);

            puzzle.Enter(ref life);

            Console.WriteLine("life : " + life);

            Random random = new();

            int index = random.Next(0, puzzle.word.Length);

            puzzle.Render(in index);

            #endregion
        }
    }
}