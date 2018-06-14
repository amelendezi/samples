using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Web.Http;
using WebApiSample.Models;

namespace WebApiSample.Controllers
{
  public class PeopleController : ApiController
  {
    List<Person> people = new List<Person>();

    public PeopleController()
    {
      people.Add(new Person() { FirstName = "Donald", LastName = "Duck", Id = 1 });
      people.Add(new Person() { FirstName = "Mickey", LastName = "Mouse", Id = 2 });
      people.Add(new Person() { FirstName = "Minnie", LastName = "Mouse", Id = 3 });
    }

    // GET: api/People
    public IEnumerable<Person> Get()
    {
      return people;
    }

    // GET: api/People/5
    public Person Get(int id)
    {
      return people.FirstOrDefault(p => p.Id == id);
    }

    // POST: api/People
    public void Post([FromBody]string value)
    {
    }

    // DELETE: api/People/5
    public void Delete(int id)
    {
    }
  }
}
