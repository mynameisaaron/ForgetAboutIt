using ForgetAboutIt.Models;
using ForgetAboutIt.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ForgetAboutIt.Controllers
{
    public class ToDosController : Controller
    {
        private ApplicationDbContext _context;

        public ToDosController()
        {
            _context = new ApplicationDbContext();
        }

        

        // GET: ToDos
        public ActionResult Index()
        {
            var viewModel = new ToDoViewModel()
            {
                ToDoList = _context.ToDos.ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Add(ToDoViewModel viewModel)
        {



            _context.ToDos.Add(ToDo.ParseTodo(viewModel));
            _context.SaveChanges();


            
            return RedirectToAction("Index");


        }

        public IEnumerable<ToDo> GetEverything()
        {
            return _context.ToDos.ToList();
        }
    }
}