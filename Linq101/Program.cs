

using LinqLibrary;
using System.Net;

List<Person> people = ListManager.LoadSampleData();

people = people.OrderByDescending(x => x.LastName).ThenByDescending(x => x.YearsExperience).ToList();
// people = people.OrderBy(x => x.LastName).ToList();

// people = people.Where(x => x.LastName.StartsWith("B")).ToList();
//people = people.Where(x => x.YearsExperience > 2 && x.Birthday.Month > 2).ToList();



//foreach(var person in people)
//{
//    Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Birthday.ToShortDateString()}): Experience {person.YearsExperience}");
//}

int yearsTotal = 0;

//people.Sum(x => x.YearsExperience);
yearsTotal = people.Where(x => x.Birthday.Month > 2).Sum(x => x.YearsExperience);

//.Where.OrderBy ... 

Console.WriteLine($"Total years experience for folks born after February: {yearsTotal}");

Console.ReadLine();