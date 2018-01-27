using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LABO6.Models;
using System.Collections;

namespace LABO6.Properties.Controllers
{
    public class ClientsController : Controller
    {
        private IClientRepository _repository;

        public ClientsController(IClientRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            IEnumerable<Client> clientList = _repository.Clients(); 
            return View(clientList);
        }
    }
}