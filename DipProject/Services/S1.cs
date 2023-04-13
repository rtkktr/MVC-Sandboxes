
using DipProject.Contracts;

namespace DipProject.Services
{
    public class S1 : IS
    {
        public void M1()
        {
            Console.WriteLine("S1.M1");
        }

        public void M2()
        {
            Console.WriteLine("M2");
        }

        public void M3()
        {
            Console.WriteLine("M3");
        }
    }
}