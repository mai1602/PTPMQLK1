namespace DemoMVC.Controllers
{
    Public class StudentsController : Controller
    {
        Public IActionResult Index()
        {
            return View()
        }
        [HttpPost]
        public IActionResult Index(Students st)
        {
            string strOutput= "Xin chao"+st.Students
        }
    }
}