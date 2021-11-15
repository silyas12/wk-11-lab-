  using System;
  
  class Person
  {
        //Auto-implemented properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string SocialSecurity { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
        public Address PermanentAddress;

        public Person()
        {
         
        }

        public Person(string fname, string lname) 
        {
         FirstName = fname;
         LastName = lname;
          PermanentAddress = new Address();
          
        }

        public virtual void Intro()
        // virtual to overwrite by the student class
        {
            Console.WriteLine("Hello my name is "+ FirstName +" "+ LastName);
            PermanentAddress.Display();
        }

      public void IsBirthday()
      {
        if ((DateTime.Today.Month == DateOfBirth.Month) &&
        (DateTime.Today.Day == DateOfBirth.Day))
        Console.WriteLine("Happy Birthday!");
        else
        Console.WriteLine("Today is not your birthday.");

      }
      
    }