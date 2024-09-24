using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class LopHoc
    {
        [Key]
        public string MaLopHoc { get; set; }
        public string TenLopHoc { get; set; }
        
    }
}