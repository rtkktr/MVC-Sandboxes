using Serialize_Sample.Dtos;
using Serialize_Sample.Services;

PersonService.Serialize(new Person
{
    FName = "r",
    LName = "t",
    Age = 22
});

Person person = PersonService.Deerialize();

Console.WriteLine(person.FName);
Console.WriteLine(person.LName);
Console.WriteLine(person.Age);