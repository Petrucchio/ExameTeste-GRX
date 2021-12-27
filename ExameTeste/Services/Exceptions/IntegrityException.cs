using System;

namespace ExameTeste.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException (string message ) : base(message)
        {

        }
    }
}
