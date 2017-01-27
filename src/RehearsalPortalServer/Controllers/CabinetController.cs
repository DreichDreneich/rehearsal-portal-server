﻿using Microsoft.AspNetCore.Mvc;
using RehearsalPortal.Core;
using RehearsalPortal.Domain;

namespace RehearsalPortal.Controllers
{
    public class CabinetController : Controller
    {
        private IBaseRepository _baseRepository { get; set; }
        private IRoomRepository _roomRepository { get; set; }
        private IBaseUserRepository _baseUserRepository { get; set; }

        public CabinetController(
            IBaseRepository baseRepository, 
            IRoomRepository roomRepository, 
            IBaseUserRepository baseUserRepository)
        {
            this._baseRepository = baseRepository;
            this._roomRepository = roomRepository;
            this._baseUserRepository = baseUserRepository;
        }

    }
}
