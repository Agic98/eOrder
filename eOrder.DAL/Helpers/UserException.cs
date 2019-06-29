using System;

namespace eOrder.DAL.Helpers
{
    public class UserException : Exception
    {
        public UserException(string message) :
            base(message)
        {
        }
    }
}
