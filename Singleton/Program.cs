using System;

namespace Singleton
{
    public class Administrator
    {
        static Administrator administrator;
        protected Administrator()
        {
            Console.WriteLine("Администратор зашёл на сайт ");
        }
        public static Administrator Instance()
        {
            if (administrator == null)
                administrator = new Administrator();
            else
                Console.WriteLine("Администратор уже в сети ");
            return administrator;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Administrator a = Administrator.Instance();
            Administrator b = Administrator.Instance();
        }
    }
}
