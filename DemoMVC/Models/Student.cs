using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models;

public class Student
{
    [Key]
    public string StudentID { get; set; }

    public string SinhVien { get; set; }
    public String Lop { get; set; }
}