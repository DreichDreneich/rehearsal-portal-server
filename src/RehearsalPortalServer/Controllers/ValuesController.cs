using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RehearsalPortal.Core;
using RehearsalPortal.Domain;

namespace RehearsalPortal.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<BaseUser> Get()
        {
            using (var db = new RPContext())
            {
                var bu1 = new BaseUser
                {
                    Name = "Холдинг мега крутых баз",
                    Phones = new List<string>()
                    {
                        "3563546356",
                        "5674657456"
                    },
                    Bases=new List<Base>()
                    {
                        new Base
                        {
                            City="Moscow",
                            Name="Bazza.ru",
                            Rooms=new List<Room>
                            {
                                new Room
                                {
                                    Name="Third"
                                }
                            }
                        },
                        new Base
                        {
                            City="Piter",
                            Name="Hendrix",
                            Rooms=new List<Room>
                            {
                                new Room
                                {
                                    Name="First"
                                },
                                new Room
                                {
                                    Name="Second"
                                }
                            }
                        }
                    }
                };

                db.BaseUsers.Add(bu1);
                db.SaveChanges();

                var users = db.BaseUsers;
                return users.ToList();
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public TestClass Get(int id)
        {
            return new TestClass() {
                Name = "sdfasdf"
            };
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class TestClass
    {
        public string Name { get; set; }
    }
}
