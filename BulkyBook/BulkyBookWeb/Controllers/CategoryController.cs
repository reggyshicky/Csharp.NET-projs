using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        //declares a private field named _db that holds an instance of the ApplicationDbContext class.
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            //var objCategoryList = _db.Categories.ToList();
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }

        //GET action method
        public IActionResult Create()
        {
            //var objCategoryList = _db.Categories.ToList();
            
            return View();
        }

        //Post action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
/*
 * _db.Categories:
_db is an instance of the ApplicationDbContext class, which represents the database context for your application.
.Categories is a property or DbSet defined in your ApplicationDbContext class. It represents a table or collection 
of data in your database related to the "Category" model.
Data Retrieval:
_db.Categories essentially represents all the records (rows) in the "Categories" table in your database.
It's a queryable collection that allows you to interact with the data in that table.
Data Type:
IEnumerable<Category> declares a variable named objCategoryList that can hold a collection of objects of type Category.
In this case, Category likely refers to a model class that represents the structure of the data in the "Categories" table.
IEnumerable is an interface in C# that represents a collection of objects that can be enumerated (iterated) one at a time. 
It's part of the .NET framework and is commonly used for working with sequences of data, such as lists, arrays, or collections. 
*/