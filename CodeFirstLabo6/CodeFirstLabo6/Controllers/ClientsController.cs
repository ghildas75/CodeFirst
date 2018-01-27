using Microsoft.AspNetCore.Mvc;
using CodeFirstLabo6.Models;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeFirstLabo6.Controllers
{
    public class ClientsController : Controller
    {
        private IClientRepository _repository;

        public ClientsController(IClientRepository repository)
        {
            _repository = repository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IEnumerable<Client> ClienList = _repository.Clients();
            return View(ClienList);
        }
    }
}
