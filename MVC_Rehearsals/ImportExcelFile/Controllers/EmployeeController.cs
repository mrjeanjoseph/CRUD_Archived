using System.Threading.Tasks;
using System.Web.Mvc;

namespace ImportExcelFile.Controllers {
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _dbContext;

        public EmployeeController() {
            _dbContext = new EmployeeDbContext();
        }

        // GET: Student  
        public ActionResult Index() {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> ImportFile() {
            return View("Index");
        }
    }
}