using Serialize_Sample.Dtos;
using Serialize_Sample.Services;

XmlSerializeService<Person>.Serialize(new Person
{
    FName = "r",
    LName = "t",
    Age = 22
}, "xmlPerson.xml");

Person person = XmlSerializeService<Person>.Deerialize("xmlPerson.xml");

Console.WriteLine($"Person [FName: {person.FName}, LName: {person.LName}, Age: {person.Age}]");