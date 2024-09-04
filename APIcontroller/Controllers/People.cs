using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIcontroller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class People : ControllerBase
    {
        [HttpGet("get-people")]
        public object Get()
        {
            Person iveta = new Person(1, "Iveta", "Nová", "iveta.nova@seznam.cz", 758471241);
            Person martin = new Person(2, "Martin", "Nový", "martin.novy69@pslib.cz", 731371311);
            Person ivan = new Person(3, "Ivan", "Dvořák", "ivandvorakhaf@gmail.com", 789523641);

            object[] people = [iveta, martin, ivan];
            

            return people;
        }

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Email { get; set; }
            public int Phone { get; set; }

            public Person(int id, string name, string surname, string email, int phone)
            {
                this.Id = id;
                this.Name = name;
                this.Surname = surname;
                this.Email = email;
                this.Phone = phone;
            }

        }
    }
}