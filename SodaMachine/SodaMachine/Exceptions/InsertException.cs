using System;

namespace SodaMachine
{
    public class InsertException : ApplicationException
    {
        public InsertException(Exception innerException) : base("Please only use numbers", innerException)
        {
            
        }
    }
}