using InterfaceProject.Contracts;
using InterfaceProject.Services;

namespace InterfaceProject.Clients
{
    public class C : IService
    {
        public S1? S1 { get; set; }

        public S2? S2 { get; set; }

        public S3? S3 { get; set; }

        public C(S1? s1, S2? s2, S3? s3)
        {
            S1 = s1;
            S2 = s2;
            S3 = s3;
        }
    }
}
