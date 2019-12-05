using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var customer = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customer);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound("Customer details not available");
            }

            return View(customer);
        }

        public ActionResult Create()
        {
            var membershiptype = _context.MembershipTypes.ToList();
            var customerMembership = new CustomerMembershipViewModel() { Memberships = membershiptype };
            return View(customerMembership);
        }

        [HttpPost]
        public ActionResult Create(CustomerMembershipViewModel customerMembershipView)
        {
            var membershiptype = _context.MembershipTypes.ToList();
            var customerMembership = new CustomerMembershipViewModel() { Memberships = membershiptype };
            if (ModelState.IsValid)
            {
                _context.Customers.Add(customerMembershipView.Customer);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }

            return View(customerMembership);
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer ==null)
            {
                return HttpNotFound();
            }
            var viewModel = new CustomerMembershipViewModel()
            {
                Customer = customer,Memberships = _context.MembershipTypes.ToList()
            };
            
            return View("Create", viewModel);
        }
       [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            var viewModel = new CustomerMembershipViewModel()
            {
                Customer = customer,
                Memberships = _context.MembershipTypes.ToList()
            };
            if (ModelState.IsValid)
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.MembershipId = customer.MembershipId;
                customerInDb.Name = customer.Name;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Create", viewModel);
        }
    }
}