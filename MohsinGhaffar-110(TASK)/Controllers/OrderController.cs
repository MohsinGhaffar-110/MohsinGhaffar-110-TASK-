using Microsoft.AspNetCore.Mvc;
using MohsinGhaffar_110_TASK_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MohsinGhaffar_110_TASK_.Controllers
{
    public class OrderController : Controller
    {
      
      

        [HttpGet]
        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(OrderModel cf)
        {

            return View();
        }

        public IActionResult ViewOrder()
        {
            return View();
        }

        public IActionResult DeleteOrder()
        {
            return View();
        }
    }
}
