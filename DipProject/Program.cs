using DipProject.Clients;
using DipProject.Contracts;
using DipProject.Services;

A a = new A(new List<DipProject.Contracts.IS>
{
    new S1(),
    new S2(),
    new S3()
});

a.Services[0].M();
a.Services[1].M();
a.Services[2].M();