// See https://aka.ms/new-console-template for more information
using linq;
using System;
using System.Collections.Generic;
using System.Linq;

Util.Heading();
var list = Student.GetStudents();

Util.SubHeading("Where");
Util.SubSubHeading("Get all students older than 20.");
list.Where(s => s.Alder > 20).ToList().ForEach(s => Console.WriteLine(s));

Util.SubSubHeading("Get all students with more than 80 points.");
list.Where(s => s.Poang > 80).ToList().ForEach(s =>Console.WriteLine(s));
list.Where(s => s.Poang > 80).ToList().ForEach(s =>Console.WriteLine(s));


Util.SubHeading("Select");
Util.SubSubHeading("Show only the names of all students.");
list.Select(s => s.Namn).ToList().ForEach(n => Console.WriteLine(n));
Util.SubSubHeading("Show name and points in a new anonymous type.");
list.Select(s => new { s.Namn, s.Poang }).ToList().ForEach(n => Console.WriteLine(n));


Util.SubHeading("OrderBy");
Util.SubSubHeading("Sort students by age.");
list.OrderBy(s => s.Alder).ToList().ForEach(s => Console.WriteLine(s));
Util.SubSubHeading("Sort students by points, highest first.");
list.OrderByDescending(s => s.Poang).ToList().ForEach(s => Console.WriteLine(s));


Util.SubHeading("Count");
Util.SubSubHeading("Count how many students there are.");
Console.WriteLine(list.Count());
Util.SubSubHeading("Count how many are in class A.");
Console.WriteLine(list.Count(s => s.Klass == "A"));


Util.SubHeading("Take");
Util.SubSubHeading("Take the first three students.");
list.Take(3).ToList().ForEach(s => Console.WriteLine(s));
Util.SubSubHeading("Take the two best scores after sorting.");
list.OrderByDescending(s => s.Poang).Take(2).ToList().ForEach(s => Console.WriteLine(s));


Util.SubHeading("Distinct");
Util.SubSubHeading("Show all unique class names.");
list.Select(s => s.Klass).Distinct().ToList().ForEach(c => Console.WriteLine(c));
Util.SubSubHeading("Show all unique ages.");
list.Select(s => s.Alder).Distinct().ToList().ForEach(a => Console.WriteLine(a));


Util.SubHeading("Any / All");
Util.SubSubHeading("Is there any student with 100 points?");
Console.WriteLine(list.Any(s => s.Poang == 100));
Util.SubSubHeading("Do all students have at least 50 points?");
Console.WriteLine(list.All(s => s.Poang >= 50));


Util.SubHeading("FirstOrDefault / Last / Single");
Util.SubSubHeading("Get the first student in class B.");
Console.WriteLine(list.FirstOrDefault(s => s.Klass == "B"));
Util.SubSubHeading("Get the last student in the list.");
Console.WriteLine(list.LastOrDefault());
Util.SubSubHeading("Get the student with a specific Id.");
Console.WriteLine(list.SingleOrDefault(s => s.Id == 1));


Util.SubHeading("GroupBy");
Util.SubSubHeading("Group students by class.");
var groupedByClass = list.GroupBy(s => s.Klass);
Util.SubSubHeading("Print each class and the names in the group.");
groupedByClass.Count();


Util.SubHeading("Sum / Average / Min / Max");
Util.SubSubHeading("Sum all points.");
var sumPoints = list.Sum(s => s.Poang);


Util.SubHeading("Calculate the average points.");
var averagePoints = list.Average(s => s.Poang);

Util.SubHeading("Find the minimum and maximum points.");
var minPoints = list.Min(s => s.Poang);
var maxPoints = list.Max(s => s.Poang);
Console.WriteLine($"Sum of points: {sumPoints}, Average points: {averagePoints}, Min points: {minPoints}, Max points: {maxPoints}");







