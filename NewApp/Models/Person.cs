namespace NewApp.Models
{
    public class Person {
        public string FullName {get;set;}
        public string Address {get;set;}
        public int Age { get;set;}

    public void EnterData()
    {
        
       System.Console.Write("FullName =");
       FullName = Console.ReadLine();
       System.Console.Write("Address =");
       Address = Console.ReadLine();
       System.Console.Write("Age = ");
       Age = Convert.ToInt16(Console.ReadLine());
    }
    public void Display()
    {
        System.Console.WriteLine("{0} - {1} - {2} tuoi", FullName, Address, Age);
    }
    
    public Person ()
    {
        FullName = "Nguyen Thi B";
        Address = "Ninh Binh";
        Age = 20;//tuoi mac dinh 
    }
    public void Display2(string ten , int tuoi)
    {
        System.Console.WriteLine("Sinh vien {0} - {1} tuoi", ten, tuoi);
    }
    public int GetYearOfBirth(int age) {
        int YearOfBirth = 2023 - age;
        return YearOfBirth;

    }
    }
}
