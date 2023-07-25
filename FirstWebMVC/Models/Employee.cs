using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FirstWebMVC.Models;

public class Employee
{
    [Key]
    public string EmpID {get;set;}
    public string EmpName {get;set;}
    public string Address {get;set;}
}
