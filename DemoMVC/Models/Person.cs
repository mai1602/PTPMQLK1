using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models;

public class Person
{
    [Key]
    public string CanCuocCongDan { get; set; }

    public string HoTen { get; set; }
    public String QueQuan { get; set; }
}
