using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using smartwallet1.web.Data;
using smartwallet1.web.Data.Entities;
using smartwallet1.web.Data.Repository;
using smartwallet1.web.Data.Repository.Interface;

namespace SmartWallet.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IRepository<Customer, Guid> _customerRepository;

        public CustomerController(IRepository<Customer, Guid> customerRepository)
        {
            _customerRepository = customerRepository;
        }
    

        public async Task<IActionResult> Index()
        {
            var customers = await _customerRepository.Get("");

            return View(customers);
        }

        public IActionResult Create()
        {
            var model = new Customer { BirthDate = DateTime.Now, Active = true };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer model)
        {
            if (ModelState.IsValid)
            {
                await _customerRepository.Add(model);

                return RedirectToAction("Index", "Customer");
            }

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var model = await _customerRepository.Get(id);

            return View(model);
        }

        //[ HttpPost]
        public async Task<IActionResult> Edit(Guid id, Customer model)
        {
            if (ModelState.IsValid)
            {
                await _customerRepository.Update(model);

                return RedirectToAction("Index", "Customer");
            }

            return View(model);
        }

        //[HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _customerRepository.Delete(id);

            return RedirectToAction("Index", "Customer");
        }
    }
}