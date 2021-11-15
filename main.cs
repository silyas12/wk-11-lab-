using System;

class Program {
  public static void Main (string[] args) {
    
   /* Address addr1 = new Address();
    addr1.AddressLine1="1234 Main St";
    addr1.AddressLine2="Apt 102";
    addr1.City="Cleveland";
    addr1.State ="OH";
    addr1.Zipcode = "44143";

    addr1.Display();

    //addr1.Zipcode="99999999";
    //addr1.State = "o";
    */
   
  /*Person p1 = new Person();
  p1.FirstName = "John";
  p1.LastName ="Smith";
  p1.PermanentAddress.AddressLine1 = "1234 Main St ";
  p1.PermanentAddress.City = "Cleveland";
  p1.PermanentAddress.State ="OH";
  p1.PermanentAddress.Zipcode ="44143";
  p1.DateOfBirth = Convert.ToDateTime( "11/11/1994");
  p1.Intro();
  p1.IsBirthday();*/

 /*Console.WriteLine("Testing Student 1");
  Student s1 = new Student();

 s1.FirstName = "Kara";
  s1.LastName = "Smoke";
  s1.DateOfBirth = Convert.ToDateTime("01/01/1989");
  s1.PermanentAddress.AddressLine1 = "999 Mailard St ";
  s1.PermanentAddress.City = "Parma";
  s1.PermanentAddress.State ="OH";
  s1.PermanentAddress.Zipcode ="44146";
  s1.GPA = 2.5;
  s1.School = "Tri-C";
  s1.Intro();
  s1.IsBirthday();
  s1.SetAcademicStanding();
  Console.WriteLine(s1.AcademicStanding);*/
  
  Console.WriteLine("Testing Student 2");
  Student s2= new Student("Andrew", "Pegg");
  s2.DateOfBirth = Convert.ToDateTime("01/01/1989");
  s2.PermanentAddress.AddressLine1 = "999 Mailard St ";
  s2.PermanentAddress.City = "Parma";
  s2.PermanentAddress.State ="OH";
  s2.PermanentAddress.Zipcode ="44146";
  s2.GPA = 2.75;
  s2.School = "Prii-C";
  s2.Intro();
  s2.IsBirthday();
  s2.SetAcademicStanding();
  Console.WriteLine(s2.AcademicStanding);

    Console.WriteLine("Testing Faculty 1");
    Faculty f1 = new Faculty("Joe","Don");
    f1.DateOfBirth = Convert.ToDateTime("06/14/1997");
    f1.PermanentAddress.AddressLine1 = "2568 main St.";
    f1.PermanentAddress.City = "Cleveland";
    f1.PermanentAddress.State = "OH";
    f1.PermanentAddress.Zipcode ="44125";

    f1.Id ="F1234";
    f1.DateOfEmployment = Convert.ToDateTime("06/10/2010");
    f1.YearlySalary= 100000;
    f1.Employer = "Penn State";
    f1.Title= "Assistant Proffessor";
  
    f1.GrantTenure();
   
      f1.Promote();
      f1.Intro();
    
     
    

  }
}