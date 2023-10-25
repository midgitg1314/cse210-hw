Student student = new Student();

student.INumber = "91-911-911";
student.FirstName = "Gage";
student.LastName = "Smith";

student.Walk();

Console.WriteLine($"{student.FirstName} {student.LastName}: {student.INumber}");