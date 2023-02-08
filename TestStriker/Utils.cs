namespace TestStriker
{
    public class Utils
    {
        public int Sum(int a, int b)
        {
            Log("Sum");
            return a + b;
        }

        public int Increment(int a)
        {
            Log("Increment");
            a += 1;
            return a;
        }

        public bool Compare(int a, int b)
        {
            if(a == b) return true;
            
            return false;
        }

        public int LastItem(IList<int> list)
        {
            return list.Last();
        }

        public void Log(string message)
        {

            if(string.IsNullOrWhiteSpace(message)) throw new ArgumentNullException("Null value");

            Console.WriteLine(message);
        }
    }
}