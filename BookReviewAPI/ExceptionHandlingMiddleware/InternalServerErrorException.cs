using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandlingMiddleware
{
    [Serializable]
    public class InternalServerErrorException:Exception
    {
        public InternalServerErrorException() : base("Something wrong happen when handling your process")
        {

        }
    }
}
