﻿using System.Collections.Generic;

using KeLi.HelloOwin.Models;

namespace KeLi.HelloOwin.Controllers
{
    public class PersonController : BaseController<Person>
    {
        private readonly List<Person> persons = new List<Person>
        {
            new Person { Id = 001, Age = 20, Name = "Jack" },
            new Person { Id = 002, Age = 27, Name = "Tom" },
            new Person { Id = 003, Age = 26, Name = "Kit" }
        };

        public override void Post(Person value)
        {
        }

        public override void Delete(int id)
        {
        }

        public override void Put(int id, Person value)
        {
        }

        public override Person Get(int id)
        {
            return persons.Find(f => f.Id == id);
        }

        public override List<Person> Get()
        {
            return persons;
        }
    }
}