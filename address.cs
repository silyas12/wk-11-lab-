using System;

class Address{
  
  private string zipCode;
  private string state;

  public string AddressLine1 {get;set;}
  public string AddressLine2 {get;set;}
  public string City {get;set;}
  public string State {
    get{
      return state.ToUpper(); //toupper means uppercase
    }
    set{
      if (value.Length==2)
      state = value;
      else
      Console.WriteLine("State can only be 2 characters.");
    }
  }

  public string Zipcode {
    get {
      return zipCode;
    }
    set{
      if (value.Length <= 5)
      zipCode = value;
      else
      Console.WriteLine("Invalid Length");
    }
    
  }

  public void Display(){
    Console.WriteLine("Here's the Address:");
    Console.WriteLine(AddressLine1);
    Console.WriteLine(AddressLine2);
    Console.WriteLine(City);
    Console.WriteLine(State);
    Console.WriteLine(Zipcode);

  }
  

}