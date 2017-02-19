using System.Data.Entity;
using RehearsalPortal.Domain;
using System.Collections.Generic;

namespace RehearsalPortal.Core
{
    public class RPContextInitializer : DropCreateDatabaseAlways<RPContext>
    {
        protected override void Seed(RPContext context)
        {
            var baseUsers = new List<BaseUser>
            {
                new BaseUser
                {
                    Id = new System.Guid("8E00AD00-FBB6-4BA8-9CED-9A6DF3B51F89"),
                    Name = "Hendrix",

                    Phones = new List<string>
                    {
                        "89379876542", "80876753723"
                    },
                    UserId = new System.Guid("B40F89A6-27AA-4A7D-9D1E-5665E2958C89"),
                    AddedDate = System.DateTime.Now,
                    ModifiedDate = System.DateTime.Now
                },
                new BaseUser
                {
                    Id = new System.Guid("D491C2AA-6172-402A-9B1A-C41CC257107F"),
                    Name = "Bazza",
                    Phones = new List<string>
                    {
                        "89379897154"
                    },
                    UserId = new System.Guid("B40F89A6-8521-4A7D-9D1E-5455E2958C89"),
                    AddedDate = System.DateTime.Now,
                    ModifiedDate = System.DateTime.Now
                },
            };

            context.BaseUsers.AddRange(baseUsers);

            var users = new List<User>
            {
                new User
                {
                    Id = new System.Guid("B40F89A6-27AA-4A7D-9D1E-5665E2958C89"),
                    Email = "alan6161@yandex.ru",
                    Login = "hendrix",
                    Password = "11111",
                    LastLoginDate = System.DateTime.Now,
                    RegistrationDate = System.DateTime.Now
                },
                new User
                {
                    Id = new System.Guid("B40F89A6-8521-4A7D-9D1E-5455E2958C89"),
                    Email = "alan6161@yandex.ru",
                    Login = "bazza",
                    Password = "11111",
                    LastLoginDate = System.DateTime.Now,
                    RegistrationDate = System.DateTime.Now
                }
            };

            context.Users.AddRange(users);

            var bases = new List<Base> {
                new Base {
                    Id = new System.Guid("665F6C13-10C2-48F5-9D35-31B1A403F1F1"),
                    BaseUserId = new System.Guid("8E00AD00-FBB6-4BA8-9CED-9A6DF3B51F89"),
                    City = "Moscow",
                    Name = "Hendrix 1905",
                    Email = "hendrix1905@gmail.com",
                    Phones = new List<string> { "89157867823" },
                    AddedDate = System.DateTime.Now,
                    ModifiedDate = System.DateTime.Now
                },
                new Base {
                    Id = new System.Guid("32B3B092-A046-4D8B-80EB-802CEA6816A6"),
                    BaseUserId = new System.Guid("8E00AD00-FBB6-4BA8-9CED-9A6DF3B51F89"),
                    City = "Moscow",
                    Name = "Hendrix Savok",
                    Email = "hendrix_savok@gmail.com",
                    Phones = new List<string> { "89167869715" },
                    AddedDate = System.DateTime.Now,
                    ModifiedDate = System.DateTime.Now
                },
                new Base {
                    Id = new System.Guid("FE305645-FD10-442A-BDF1-0CDAC522F62B"),
                    BaseUserId = new System.Guid("D491C2AA-6172-402A-9B1A-C41CC257107F"),
                    City = "Moscow",
                    Name = "Bazza.ru Savok",
                    Email = "Bazza-savok@gmail.com",
                    Phones = new List<string> { "89167827514" },
                    AddedDate = System.DateTime.Now,
                    ModifiedDate = System.DateTime.Now
                }
            };

            context.Bases.AddRange(bases);

            var rooms = new List<Room> {
                new Room {
                    Id = new System.Guid("B71F2B6D-7101-4F54-A753-A54CA730C31D"),
                    BaseId = new System.Guid("665F6C13-10C2-48F5-9D35-31B1A403F1F1"),
                    Area = 25,
                    Name = "Big room",
                    AddedDate = System.DateTime.Now,
                    ModifiedDate = System.DateTime.Now
                },
                new Room {
                    Id = new System.Guid("B71F2B6D-7101-4F54-A753-A5471986C31D"),
                    BaseId = new System.Guid("665F6C13-10C2-48F5-9D35-31B1A403F1F1"),
                    Area = 20,
                    Name = "Medium room",
                    AddedDate = System.DateTime.Now,
                    ModifiedDate = System.DateTime.Now
                },
                new Room {
                    Id = new System.Guid("B71F2B6D-7101-9376-A753-A54CA730C31D"),
                    BaseId = new System.Guid("665F6C13-10C2-48F5-9D35-31B1A403F1F1"),
                    Area = 15,
                    Name = "Small room",
                    AddedDate = System.DateTime.Now,
                    ModifiedDate = System.DateTime.Now
                },
                new Room {
                    Id = new System.Guid("B71F2B6D-7101-4F54-9108-A54CA730C31D"),
                    BaseId = new System.Guid("665F6C13-10C2-48F5-9D35-31B1A403F1F1"),
                    Area = 16,
                    Name = "Yellow",
                    AddedDate = System.DateTime.Now,
                    ModifiedDate = System.DateTime.Now
                },
                new Room {
                    Id = new System.Guid("32B3B092-8574-4D8B-2111-802CEA6816A6"),
                    BaseId = new System.Guid("665F6C13-10C2-48F5-9D35-31B1A403F1F1"),
                    Area = 9,
                    Name = "Extra-small room",
                    AddedDate = System.DateTime.Now,
                    ModifiedDate = System.DateTime.Now
                },
                new Room {
                    Id = new System.Guid("32B3B092-6579-4D8B-9842-802CEA6816A6"),
                    BaseId = new System.Guid("665F6C13-10C2-48F5-9D35-31B1A403F1F1"),
                    Area = 34,
                    Name = "Very-big room",
                    AddedDate = System.DateTime.Now,
                    ModifiedDate = System.DateTime.Now
                },
                new Room {
                    Id = new System.Guid("32B3B092-A046-4D8B-8570-802CEA6816A6"),
                    BaseId = new System.Guid("665F6C13-10C2-48F5-9D35-31B1A403F1F1"),
                    Area = 23,
                    Name = "Green",
                    AddedDate = System.DateTime.Now,
                    ModifiedDate = System.DateTime.Now
                },
                new Room {
                    Id = new System.Guid("32B3B092-A046-0943-8743-802CEA6816A6"),
                    BaseId = new System.Guid("665F6C13-10C2-48F5-9D35-31B1A403F1F1"),
                    Area = 6,
                    Name = "Ugly",
                    AddedDate = System.DateTime.Now,
                    ModifiedDate = System.DateTime.Now
                },
                new Room {
                    Id = new System.Guid("FE305645-FD10-442A-9864-0CDAC522F62B"),
                    BaseId = new System.Guid("665F6C13-10C2-48F5-9D35-31B1A403F1F1"),
                    Area = 54,
                    Name = "Beautiful",
                    AddedDate = System.DateTime.Now,
                    ModifiedDate = System.DateTime.Now
                },
                new Room {
                    Id = new System.Guid("FE305645-9574-442A-BDF1-0CDAC522F62B"),
                    BaseId = new System.Guid("665F6C13-10C2-48F5-9D35-31B1A403F1F1"),
                    Area = 89,
                    Name = "Palace room",
                    AddedDate = System.DateTime.Now,
                    ModifiedDate = System.DateTime.Now
                },
                new Room {
                    Id = new System.Guid("FE305645-8746-442A-8777-0CDAC522F62B"),
                    BaseId = new System.Guid("665F6C13-10C2-48F5-9D35-31B1A403F1F1"),
                    Area = 32,
                    Name = "Metallica room",
                    AddedDate = System.DateTime.Now,
                    ModifiedDate = System.DateTime.Now
                },
                new Room {
                    Id = new System.Guid("FE305645-FD10-442A-8776-0CDAC522F62B"),
                    BaseId = new System.Guid("665F6C13-10C2-48F5-9D35-31B1A403F1F1"),
                    Area = 45,
                    Name = "U25 room",
                    AddedDate = System.DateTime.Now,
                    ModifiedDate = System.DateTime.Now
                }
            };

            context.Rooms.AddRange(rooms);

            context.SaveChanges(); 

            base.Seed(context);
        }
    }
}
