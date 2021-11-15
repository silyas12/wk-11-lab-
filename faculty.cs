using System;

//inheritance by putting Person
class Faculty : Person //will get everything from person class
{
public string Id {get; set;}
public string Title {get;set;}
public double YearlySalary {get;set;}
public string Employer {get;set;}
public bool Tenured {get;set;}
public DateTime DateOfEmployment {get;set;}

public Faculty() : base()
{Title = "instructor"; }

public Faculty(string fname, string lname) : base( fname, lname)
{
Title ="instructor";

}

public bool GrantTenure()
      {
        int yearsworked = 0;
         if ((DateTime.Today.Month == DateOfEmployment.Month) &&
        (DateTime.Today.Day == DateOfEmployment.Day))
       {yearsworked = DateOfEmployment.Year - DateTime.Today.Year;}
       else 
       yearsworked = ((DateOfEmployment.Year - DateTime.Today.Year) - 1);
        if (yearsworked >= 5 )
       Tenured = true;
       else
       Tenured = false;
       return Tenured;

      }

       public void Promote()
      {
        int experience = 0 ;
       
         if ((DateTime.Today.Month == DateOfEmployment.Month) &&
        (DateTime.Today.Day == DateOfEmployment.Day))
       {experience = DateOfEmployment.Year - DateTime.Today.Year;}
       else 
       experience = ((DateOfEmployment.Year - DateTime.Today.Year) - 1); 
        if ( Title.Equals("Instructor") && experience > 2 ){
      Title = "Assistant Professor";
        Console.WriteLine("Faculty promoted to Assistant Professor rank.");}
        
        if ( Title.Equals("Assistant Professor") && experience > 5 ){
      Title = "Associate Professor";
        Console.WriteLine("Faculty promoted to Associate Professor rank.");}
        
        if (Title.Equals("Associate Professor" ) && experience > 10 ){
     Title = " Professor";
       Console.WriteLine("Faculty promoted to Professor rank");}
       
      if  (Title.Equals("Professor" )){
        Console.WriteLine("No more promotion possible.");}
       

      }
      
     public override void Intro()
{
  base.Intro();
  Console.WriteLine("I work as " + Title + " at " + Employer + " since " + DateOfEmployment.Year +".");
} 

}

