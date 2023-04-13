using DipProject.Contracts;

namespace DipProject.Clients
{
    public class B
    {
        public List<IS> Services { get; set; }

        public B(List<IS> services)
        {
            Services = services;
        }
    }
}
