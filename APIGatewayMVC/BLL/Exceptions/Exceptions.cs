﻿namespace BLL.Exceptions
{
    [Serializable]
    public class RoleException : Exception
    {
        public RoleException(string message)
            : base(message) { }
    }
}
