using System;

namespace RehearsalPortal.Core.Exceptions
{
    public abstract class BNotFoundException : Exception
    {
        private Guid Id { get; set; }

        public BNotFoundException(Guid Id)
        {
            this.Id = Id;
        }

        //Идея в том, что бы с сервера посылать коды, а на клиенте их локализовывать
        public virtual string BASE_CODE
        {
            get
            {
                return "_NOT_FOUND";
            }
        }
    }

    public class BaseNotFoundException : BNotFoundException 
    {
        public BaseNotFoundException(Guid id) : base(id)
        { }

        public override string BASE_CODE
        {
            get
            {
                return "BASE" + base.BASE_CODE;
            }
        }
    }

    public class BaseUserNotFoundException : BNotFoundException
    {
        public BaseUserNotFoundException(Guid id) : base(id)
        { }

        public override string BASE_CODE
        {
            get
            {
                return "BASE_USER" + base.BASE_CODE;
            }
        }
    }

    public class RoomNotFoundException : BNotFoundException
    {
        public RoomNotFoundException(Guid id) : base(id)
        { }

        public override string BASE_CODE
        {
            get
            {
                return "ROOM" + base.BASE_CODE;
            }
        }
    }
}

