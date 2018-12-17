using MemoEngine.Models;
using System.Web.Mvc;

namespace MemoEngine.Controllers
{
    public class ListOfCategoryController : Controller
    {
        // GET: ListOfCategory
        public ActionResult Index()
        {
            var categoryRepository = new CategoryRepositoryInMemory();

            var categories = categoryRepository.GetCategories();

            return View(categories);
        }
    }
}
