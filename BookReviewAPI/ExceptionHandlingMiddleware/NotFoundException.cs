﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandlingMiddleware
{
    [Serializable()]
    public class NotFoundException:Exception
    {
        public NotFoundException() : base("Data not found")
        {

        }
    }
}
