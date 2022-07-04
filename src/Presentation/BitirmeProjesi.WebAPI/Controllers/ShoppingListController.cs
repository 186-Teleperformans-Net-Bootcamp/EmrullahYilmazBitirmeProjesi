using BitirmeProjesi.Domain.Entities;
using BitirmeProjesi.Domain.Entitiess;
using BitirmeProjesi.Persistence.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BitirmeProjesi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ShoppingListController : ControllerBase
    {
        private ApplicationDbContext _context = null;

        public ShoppingListController(ApplicationDbContext applicationDbContext)
        {
            this._context = applicationDbContext;
        }
        [HttpGet]
        public IEnumerable<ShoppingList> Get()
        {
            //var users = _context.ShoppingLists.ToList();

            var itemname = _context.ShoppingLists.Include(x => x.Items).ToList();
            var users = _context.ShoppingLists.ToList();



            return itemname;


        }

        [HttpGet("GetById")]
        public ShoppingList Get(int id)
        {
            var user = _context.ShoppingLists.Find(id);
            return user;
        }
        [HttpPost]
        public void Post(string categoryname, string title, ICollection<Item> Items)
        {


            ShoppingList sl = new ShoppingList()
            {
                CategoryName = categoryname,
                Title = title,
                Items = Items,
                CreatedDate = DateTime.Now,
                UserId = "user",


            };
            _context.ShoppingLists.Add(sl);
            _context.SaveChanges();
            
            

        }
        [HttpPut]
        public void Put(ShoppingList user)
        {
            var result = _context.ShoppingLists.Find(user.Id);
            if (result != null)
            {
                _context.Entry(result).CurrentValues.SetValues(user);
                _context.SaveChanges();
            }
        }
        [HttpDelete]
        public void Delete(int id)
        {
            try
            {

                var user = _context.ShoppingLists.Find(id);
                _context.ShoppingLists.Remove(user);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        



    }
}
