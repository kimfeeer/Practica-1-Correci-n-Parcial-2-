using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using PracticaApi.Domain;
using System.Threading.Tasks;

namespace PracticaApi.Repositories
{
    public class PersonRepository
    {
        List<Person> _persons;

        public PersonRepository()
        {
            var fileName = "dummy.data.queries.json";
            if(File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                _persons = JsonSerializer.Deserialize<IEnumerable<Person>>(json).ToList();
            }
        }

        // retornar todos los valores
        public IEnumerable<Person> GetAll()
        {
            var query = _persons.Select(person => person);
            return query;
        }

        // retornar campos especificos

        public IEnumerable<Object> GetFields()
        {
           var query = _persons.Select(person => new {
                NombreCompleto = $"{person.FirstName} {person.LastName}",
                AnioNacimiento = DateTime.Now.AddYears(person.Age * -1),
                Correo = person.Email
            });
            return query;
        }

        // retornar elementos que sean iguales
        public IEnumerable<Person> GetByGender()
        {
            var gender = 'M';
            var query = _persons.Where(Persona => Persona.Gender == gender);
            return query;
        }

        public IEnumerable<Person> GetMinusAge()
        {
            var age = 30;
             var query = _persons.Where(Persona => Persona.Age <= age);
            return query;
        }
        // Retornar elementos que sean diferentes
        public IEnumerable<Person> GetDiference()
        {
             var age = 30;
             var gender = 'F';
             var query = _persons.Where(Persona => Persona.Age  <= age && Persona.Gender == gender);
            return query;
        }

        public IEnumerable<string> GetJobs()
        {
             var age = 30;
             var gender = 'F';
             var query = _persons.Where(Persona => Persona.Age <= age && Persona.Gender == gender).Select(Persona => Persona.Job).Distinct();
            return query;
        }
        // retornar valores que contengan
        
        public IEnumerable<Person> GetStartWith()
        {
            var star = "Mar";
            var query = _persons.Where(x =>x.Job.StartsWith(star));
            return query;
        }
        public IEnumerable<Person> GetContains()
        {
            var word = "er";
            var query = _persons.Where(Persona => Persona.FirstName.Contains(word));
            return query;
        }

        public IEnumerable<Person> GetByList()
        {
            var ages = new List<int>{15,25,35,45,55};
            var query = _persons.Where(Persona => ages.Contains(Persona.Age));
            return query;
        }
        
        // retornar elementos ordenados
        public IEnumerable<Person> GetOrdered()
        {
            var age = 33;
            var query = _persons.Where(Persona => Persona.Age > age).OrderBy(Persona => Persona.Age);
            return query;
        }

        public IEnumerable<Person> GetOrderedDesc()
        {
            var minAge = 20;
            var MaxAge = 50;
            var query = _persons
                .Where(Persona => Persona.Age >= minAge && Persona.Age < MaxAge)
                .OrderByDescending(Persona => Persona.Age);
                return query;
        }
        // retorno cantidad de elementos
        
        public int CountPerson()
        {
            var gender = 'M';
            var query = _persons.Count(Persona => Persona.Gender == gender);
            return query;
        }

        // Evalua si un elemento existe
        
        public bool ExistPerson()
        {
            var LastName = "Shemelt";
            var query = _persons.Exists(p => p.LastName == LastName);
            return query;
        }

        public bool AnyPerson()
        {
            var FirstName = "Aleksand";
            var query = _persons.Any(p => p.FirstName == FirstName);
            return query;
        }
        // retornar solo un elemento
        
        public Person GetFirst()
        {
            var age = 26;
            var Job = "Software Consultant";
            var query = _persons.FirstOrDefault(p => p.Age == age && p.Job == Job);

            return query;
        }
        // retornar solamente unos elementos
        
        public IEnumerable<Person> TakePerson()
        {
            var Job = "Sofware Consultant";
            var take = 3;
            var query = _persons.Where(Persona => Persona.Job == Job).Take(take);
            return query;
        }
        // retornar elementos saltando posición
        public IEnumerable<Person> SkipTakePerson()
        {
            var job = "Sofware Consultant";
            var skip = 3;
            var take = 3;
            var query = _persons.Where(Persona => Persona.Job == job).Skip(skip).Take(take);
            return query;
        }
    }
}