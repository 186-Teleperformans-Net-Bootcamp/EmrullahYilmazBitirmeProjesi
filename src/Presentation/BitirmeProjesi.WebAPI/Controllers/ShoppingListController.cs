﻿using BitirmeProjesi.Domain.Entities;
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
            try
            {
                var itemname = _context.ShoppingLists.Include(x => x.Items).ToList();
                var users = _context.ShoppingLists.ToList();



                return itemname;
            }
            catch(Exception e)
            {
                throw e;
            }
            


        }

        [HttpGet("GetById")]
        public ShoppingList Get(int id)
        {
            try
            {
                var user = _context.ShoppingLists.Find(id);
                return user;
            }
            catch(Exception e)
            {
                throw e;

            }

        }
        [HttpPost]
        public void Post(string categoryname, string title, ICollection<Item> Items)
        {

            try
            {
                ShoppingList sl = new ShoppingList()
                {
                    CategoryName = categoryname,
                    Title = title,
                    Items = Items,
                    CreatedDate = DateTime.Now,
                    UserId = User.Identity.Name,


                };
                _context.ShoppingLists.Add(sl);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }




        }
        [HttpPut]
        public void Put(ShoppingList user)
        {
            try
            {
                var result = _context.ShoppingLists.Find(user.Id);
                if (result != null)
                {
                    _context.Entry(result).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
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