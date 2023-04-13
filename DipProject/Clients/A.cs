using DipProject.Contracts;

namespace DipProject.Clients
{
    public class A
    {
        public IS Service { get; set; }

        public A(IS service)
        {
            Service = service;
        }
    }
}