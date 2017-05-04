using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example1;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Example1.Controllers
{

    public class CustomerController : Controller
    {
        //public CustomerRepositoryReadOnly customerRepo = new CustomerRepositoryReadOnly();
        public Customer cstmr = new Customer();
        public ErrorMessege errormsgclass = new ErrorMessege();
        private readonly ICustomerRepositoryReadOnly _repo;

        public CustomerController(ICustomerRepositoryReadOnly repo)
        {
            _repo = repo;
            _repo.PopulateCustomer();
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult JsonView()
        {
            return View();
        }
        public IActionResult IsCustomerValid(int id)
        {

            _repo.PopulateCustomer();

            if (_repo.CustomerExist(id))
            {
                var getCustomer = _repo.GetById(id);
                return View("Customer", getCustomer);
            }

            errormsgclass.ErrorMsg = $"The id {id} does not exist in our database";
            return View("UnknownIdPage", errormsgclass);

            

        }

        public IActionResult IsJsonCustomerValid(int id)
        {
            _repo.PopulateCustomer();
            if (_repo.CustomerExist(id))
            {
                var getJsonCustomer = _repo.GetById(id);


                return Ok(getJsonCustomer);
            }
            errormsgclass.ErrorMsg = $"The id {id} does not exist in our database";
            return View("UnknownIdPage", errormsgclass);
        }
    }
}
