using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest_Rafat.Controllers
{
    public class APIController : Controller
    {
        public ActionResult Index() { return null; }

    }
}


/* 
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using ToDoListWebApi;

namespace ToDoListWebApi.Controllers
{
   [EnableCors(origins: "*", headers: "*", methods: "*")]
   public class ToDoListsController : ApiController
   {
       private TropicalServerEntities1 db = new TropicalServerEntities1();

       // GET: api/ToDoLists
       public IQueryable<ToDoList> GetToDoLists()
       {
           return db.ToDoLists;
       }

       // GET: api/ToDoLists/5
       [ResponseType(typeof(ToDoList))]
       public IHttpActionResult GetToDoList(int id)
       {
           ToDoList toDoList = db.ToDoLists.Find(id);
           if (toDoList == null)
           {
               return NotFound();
           }

           return Ok(toDoList);
       }

       // PUT: api/ToDoLists/5
       [ResponseType(typeof(void))]
       public IHttpActionResult PutToDoList(int id, ToDoList toDoList)
       {
           if (!ModelState.IsValid)
           {
               return BadRequest(ModelState);
           }

           if (id != toDoList.TaskID)
           {
               return BadRequest();
           }

           db.Entry(toDoList).State = EntityState.Modified;

           try
           {
               db.SaveChanges();
           }
           catch (DbUpdateConcurrencyException)
           {
               if (!ToDoListExists(id))
               {
                   return NotFound();
               }
               else
               {
                   throw;
               }
           }

           return StatusCode(HttpStatusCode.NoContent);
       }

       // POST: api/ToDoLists
       [ResponseType(typeof(ToDoList))]
       public IHttpActionResult PostToDoList(ToDoList toDoList)
       {
           if (!ModelState.IsValid)
           {
               return BadRequest(ModelState);
           }

           db.ToDoLists.Add(toDoList);

           try
           {
               db.SaveChanges();
           }
           catch (DbUpdateException)
           {
               if (ToDoListExists(toDoList.TaskID))
               {
                   return Conflict();
               }
               else
               {
                   throw;
               }
           }

           return CreatedAtRoute("DefaultApi", new { id = toDoList.TaskID }, toDoList);
       }

       // DELETE: api/ToDoLists/5
       [ResponseType(typeof(ToDoList))]
       public IHttpActionResult DeleteToDoList(int id)
       {
           ToDoList toDoList = db.ToDoLists.Find(id);
           if (toDoList == null)
           {
               return NotFound();
           }

           db.ToDoLists.Remove(toDoList);
           db.SaveChanges();

           return Ok(toDoList);
       }

       protected override void Dispose(bool disposing)
       {
           if (disposing)
           {
               db.Dispose();
           }
           base.Dispose(disposing);
       }

       private bool ToDoListExists(int id)
       {
           return db.ToDoLists.Count(e => e.TaskID == id) > 0;
       }
   }
}

COR

*/
