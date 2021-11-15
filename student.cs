using System;

//inheritance by putting Person
class Student : Person //will get everything from person class
{
public string Id{get; set;}
public string School {get;set;}
public double GPA {get;set;}
public string Major {get;set;}
public string AcademicStanding {get;set;}

public Student(string fname, string lname) : base(fname, lname)
{
Console.WriteLine("Student Constructor");
AcademicStanding = "Good";
}

public void SetAcademicStanding()
{
if (GPA >= 2.25)
AcademicStanding = "Good";
else
AcademicStanding = "Not Good";
}
public override void Intro()
{
  base.Intro();
  Console.WriteLine("I am a student studying in " + School);
}
}