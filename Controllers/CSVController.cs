using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSV.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSVController : ControllerBase
    {
      
        FileStream F = new FileStream("sample.csv", FileMode.OpenOrCreate);//, FileAccess.ReadWrite);
          
    
       [HttpGet]
       public dynamic Get()
       {
            StreamReader Reader = new StreamReader(F);
            return Reader.ReadToEnd();
          //return data.prrr();
       }
/*
       // GET api/<CSVController>/5
       [HttpGet("{id}")]
       public string Get(int id)
       {
           return "value";
       }

       // POST api/<CSVController>
       [HttpPost]
       public void Post([FromBody] string value)
       {
       }

       // PUT api/<CSVController>/5
       [HttpPut("{id}")]
       public void Put(int id, [FromBody] string value)
       {
       }

       // DELETE api/<CSVController>/5
       [HttpDelete("{id}")]
       public void Delete(int id)
       {
       }
*/

    }
}
