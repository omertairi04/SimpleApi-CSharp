using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;
using System.Collections;

namespace SimpleApi.Controllers;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    private static ArrayList users = new ArrayList
    {
        new User
        {
            Id = 1,
            Username = "omer",
            Password = "1234"
        },
        new User
        {
            Id = 2,
            Username = "admin",
            Password = "admin123"
        }
    };

    // GET: api/user
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(users);
    }

    // GET: api/user/1
    [HttpGet("{id}")]
    public IActionResult GetOne(int id)
    {
        foreach (User user in users)
        {
            if (user.Id == id)
            {
                return Ok(user);
            }
        }

        return NotFound();
    }

    // POST: api/user
    [HttpPost]
    public IActionResult Create(User user)
    {
        user.Id = users.Count + 1;
        users.Add(user);

        return Ok(user);
    }

    // PUT: api/user/1
    [HttpPut("{id}")]
    public IActionResult Update(int id, User updatedUser)
    {
        foreach (User user in users)
        {
            if (user.Id == id)
            {
                user.Username = updatedUser.Username;
                user.Password = updatedUser.Password;

                return Ok(user);
            }
        }

        return NotFound();
    }

    // DELETE: api/user/1
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        foreach (User user in users)
        {
            if (user.Id == id)
            {
                users.Remove(user);
                return Ok();
            }
        }

        return NotFound();
    }
}
