using Microsoft.AspNetCore.Mvc;
using RehearsalPortal.Core;
using RehearsalPortal.Domain;

namespace RehearsalPortal.Controllers
{
    [Route("api/[controller]")]
    public class BaseUserController : Controller
    {
        private IBaseRepository _baseRepository { get; set; }
        private IRoomRepository _roomRepository { get; set; }
        private IBaseUserRepository _baseUserRepository { get; set; }

        public BaseUserController(
            IBaseRepository baseRepository, 
            IRoomRepository roomRepository, 
            IBaseUserRepository baseUserRepository)
        {
            this._baseRepository = baseRepository;
            this._roomRepository = roomRepository;
            this._baseUserRepository = baseUserRepository;
        }

        [HttpGet("Hello")]
        public string Hello()
        {
            return "Hello";
        }

        [HttpGet("{id}")]
        public BaseUser GetBaseUserById(System.Guid Id)
        {
            return _baseUserRepository.GetById(Id);
        }
    }
}
