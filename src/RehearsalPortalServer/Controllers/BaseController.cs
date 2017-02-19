using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RehearsalPortal.Core;
using RehearsalPortal.Domain;

namespace RehearsalPortal.Controllers
{
    [Route("api/[controller]")]
    public class BaseController : Controller
    {
        private IBaseRepository _baseRepository { get; set; }
        private IRoomRepository _roomRepository { get; set; }
        private IBaseUserRepository _baseUserRepository { get; set; }

        public BaseController(
            IBaseRepository baseRepository,
            IRoomRepository roomRepository,
            IBaseUserRepository baseUserRepository)
        {
            this._baseRepository = baseRepository;
            this._roomRepository = roomRepository;
            this._baseUserRepository = baseUserRepository;
        }

        [HttpGet("{id}")]
        public Base GetBaseById(string id)
        {
            var guidId = new System.Guid(id);
            return _baseRepository.GetById(guidId);
        }

        [HttpGet("getBaseByBaseUserId/{id}")]
        public Base GetBaseByUserId(string id)
        {
            var guidId = new System.Guid(id);
            return _baseRepository.GetBaseByBaseUserId(guidId);
        }
    }
}
