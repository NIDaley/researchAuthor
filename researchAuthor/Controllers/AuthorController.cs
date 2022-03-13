using Microsoft.AspNetCore.Mvc;
using researchAuthor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace researchAuthor.Controllers
{
    public class AuthorController : Controller
    {
        private readonly pubsContext _db;

        public AuthorController(pubsContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            // Strongly Typed
            IEnumerable<Author> objAuthorList = _db.Authors;
            return View(objAuthorList);

            // Weak Typed
            //var objAuthorList = _db.Authors.ToList();
            //return View();
        }
    }
}
