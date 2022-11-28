

using LinqLibrary;
using System.Net;

List<Person> people = ListManager.LoadSampleData();

people = people.OrderByDescending(x => x.LastName).ToList();
// people = people.OrderBy(x => x.LastName).ToList();

foreach(var person in people)
{
    Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Birthday.ToShortDateString()}): Experience {person.YearsExperience}");
}

Console.ReadLine();