using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;
using System.Collections;


[ApiController]
[Route("api/user")]
public class ProductController : ControllerBase {

    public ArrayList products = new ArrayList{
        new Product{
            Id=1,
            Emri="Maic",
            Description="Maic 100% pamuk",
            Cmimi=49
        }
    };

    [HttpGet]
    public IActionResult GetAll() {
        return Ok(products);
    }

    [HttpGet("{id}")]
    public IActionResult GetOne(int id) {
        foreach (Product p in products) {
            if (p.Id == id) return Ok(p);
        }

        return NotFound();
    }

    [HttpPost]
    public IActionResult Create(Product p) {
        p.Id = products.Count + 1;
        products.Add(p);

        return Ok(p);
    }
}
