using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class HelloWorldController : ApiBaseController
{

    [HttpGet()]
    public ActionResult<IEnumerable<string>> GetTModels()
    {
        return new List<string> { "Hello World", "Hello World2" };
    }

    
    [HttpGet("{id}")]
    public ActionResult<string> GetById(int id)
    {
        if (id < 0) return BadRequest();

        if (id == 0) return NotFound();

        return "Hello World";
    }


    [HttpPost("{model}")]
    public ActionResult PostTModel(string model)
    {
        return Ok();
    }

    [HttpPut("{id}")]
    public ActionResult PutTModel(string model)
    {
        return NoContent();
    }


    [HttpDelete("{id}")]
    public ActionResult<string> DeleteTModelById(string id)
    {
        if (id == "1234")
        {            
            return Ok(id);
        }
        return NotFound();
    }
}
