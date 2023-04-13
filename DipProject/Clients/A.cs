using DipProject.Contracts;

namespace DipProject.Clients
{
    public class A
    {
        public List<IS> Services { get; set; }

        public A(List<IS> services)
        {
            Services = services;
        }
    }
}