using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetproject.Dico;
using dotnetproject.DTO;

namespace dotnetproject.Controllers 
{

    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase 
    {
        // GET api/items
        // Get all the names from the Enum
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            List<String> names = new List<String>() ;

            foreach( ENameTable item in Enum.GetValues(typeof(ENameTable))) {
                names.Add(item.ToString()) ;
            }

            return names ;
        }

        // PUT api/items/5
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] ItemDTO item)
        {
            Context.Update(item);

            return Ok(item);
        }

    }
}