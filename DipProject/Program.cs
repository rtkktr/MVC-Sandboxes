using DipProject.Clients;
using DipProject.Contracts;
using DipProject.Services;

A a = new A(new S1());
a.Service.M1();

a.Service = new S2();
a.Service.M1();