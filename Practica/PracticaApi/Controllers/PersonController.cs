using System.Collections;
using Microsoft.AspNetCore.Mvc;
using PracticaApi.Repositories;
using PracticaApi.Domain;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetFields();
            return Ok(persons);
        }

             public IActionResult GetFields()
        {
            var repository = new PersonRepository();
            var persons = repository.GetFields();
            return Ok(persons);
        } 
         public IActionResult GetByGender()
        {
            var repository = new PersonRepository();
            var persons = repository.GetByGender();
            return Ok(persons);
        }
         public IActionResult GetMinusAge()
        {
            var repository = new PersonRepository();
            var persons = repository.GetMinusAge();
            return Ok(persons);
        }
         public IActionResult  GetDiference()
        {
            var repository = new PersonRepository();
            var persons = repository. GetDiference();
            return Ok(persons);
        }
        public IActionResult   GetJobs()
        {
            var repository = new PersonRepository();
            var persons = repository.  GetJobs();
            return Ok(persons);
        }


        public IActionResult  GetStartWith()
        {
            var repository = new PersonRepository();
            var persons = repository.  GetStartWith();
            return Ok(persons);
        }

        public IActionResult  GetContains()
        {
            var repository = new PersonRepository();
            var persons = repository. GetContains();
            return Ok(persons);
        }

        public IActionResult  GetByList()
        {
            var repository = new PersonRepository();
            var persons = repository.   GetByList();
            return Ok(persons);
        }

        public IActionResult  GetOrdered()
        {
            var repository = new PersonRepository();
            var persons = repository.  GetOrdered();
            return Ok(persons);
        }

        public IActionResult GetOrderedDesc()
        {
            var repository = new PersonRepository();
            var persons = repository.  GetOrderedDesc();
            return Ok(persons);
        }

         public IActionResult CountPerson()
        {
            var repository = new PersonRepository();
            var persons = repository. CountPerson();
            return Ok(persons);
        }

         public IActionResult ExistPerson()
        {
            var repository = new PersonRepository();
            var persons = repository.  ExistPerson();
            return Ok(persons);
        }

         public IActionResult AnyPerson()
        {
            var repository = new PersonRepository();
            var persons = repository. AnyPerson();
            return Ok(persons);
        }

         public IActionResult GetFirst()
        {
            var repository = new PersonRepository();
            var persons = repository. GetFirst();
            return Ok(persons);
        }

        public IActionResult TakePerson()
        {
            var repository = new PersonRepository();
            var persons = repository. TakePerson();
            return Ok(persons);
        }

        public IActionResult SkipTakePerson()
        {
            var repository = new PersonRepository();
            var persons = repository. SkipTakePerson();
            return Ok(persons);
        } 
    }
}