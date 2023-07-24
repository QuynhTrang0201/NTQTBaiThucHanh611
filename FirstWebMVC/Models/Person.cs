using System.ComponentModel.DataAnnotations;
public class Person 
{
    [KeyAttribute]
    public int ID {get; set;}
    public string FullName {get; set;}
    public string Address {get; set;}
   
}