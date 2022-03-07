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

        public AuthorController(pubsContext pubs)
        {
            _db = pubs;
        }
        public IActionResult Index()
        {
            IEnumerable<Author> objAuthorList = _db.Authors;
            return View(objAuthorList);
        }
    }
}
