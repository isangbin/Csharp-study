namespace oop_prac1
{

    public class User
    {
        public int budget = 5000;
        
        public void BuyItem()
        {
            Console.WriteLine("돈을 넣었습니다.");
        }
    }

    public class Machine()
    {
        public int paid;

        public void DropItem()
        {
            Console.WriteLine("음료가 나왔습니다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            Machine machine1 = new Machine();
        }
    }
}
