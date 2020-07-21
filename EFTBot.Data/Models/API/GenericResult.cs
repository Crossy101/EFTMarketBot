using System;
using System.Collections.Generic;
using System.Text;

namespace EFTBot.Data.Models.API
{
    public class GenericResult<T>
    {
        public T Data { get; set; }
        public GenericError Error { get; set; }
    }
}
