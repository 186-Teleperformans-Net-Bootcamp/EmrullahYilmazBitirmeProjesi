using BitirmeProjesi.Domain.Entitiess;
using BitirmeProjesi.Domain.Entities;
using BitirmeProjesi.Persistence.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace BitirmeProjesi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ItemController : ControllerBase
    {
        private ApplicationDbContext applicationDbContext = null;

        public ItemController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public IEnumerable<Item> Get()
        {
            var users = applicationDbContext.Items.ToList();
            return users;
        }
        [HttpDelete]
        public void Delete(int id)
        {
            try
            {

                var ıtem = applicationDbContext.Items.FirstOrDefault(f => f.Id == id);
                applicationDbContext.Remove(ıtem);
                applicationDbContext.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        [HttpPost]
        public void Post(string name, int quantity,int shoplistid,Domain.Entitiess.Type type)
        {
            Item sl = new Item()
            {
               Name = name,
               Quantity = quantity,
               ShoppingListId = shoplistid,
               UserId = "string",
               Type = type
              
               
            };
            applicationDbContext.Items.Add(sl);
            applicationDbContext.SaveChanges();
        }
        [HttpPut]
        public void Put(Item user)
        {
            var result = applicationDbContext.ShoppingLists.Find(user.Id);
            if (result != null)
            {
                applicationDbContext.Entry(result).CurrentValues.SetValues(user);
                applicationDbContext.SaveChanges();
            }
        }
    }
}
