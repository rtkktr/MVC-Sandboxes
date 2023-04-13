using DipProject.Contracts;

namespace DipProject.Clients
{
    public class C
    {
        public List<IS> Services { get; set; }

        public C(List<IS> services)
        {
            Services = services;
        }
    }
}
