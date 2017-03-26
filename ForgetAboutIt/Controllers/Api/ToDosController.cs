using ForgetAboutIt.Models;
using System.Linq;
using System.Web.Http;

namespace ForgetAboutIt.Controllers.Api
{
    public class ToDosController : ApiController
    {

        private ApplicationDbContext _context;

        public ToDosController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpDelete]
        public IHttpActionResult RemoveTask(int id)
        {
            var todo = _context.ToDos.SingleOrDefault(d => d.Id == id);
            if(todo == null)
                return BadRequest();

            _context.ToDos.Remove(todo);
            _context.SaveChanges();
            return Ok();
        }
    }
}
