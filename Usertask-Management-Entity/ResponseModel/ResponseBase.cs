using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usertask_Management_Entity.ResponseModel
{
    public class ResponseBase
    {
        public bool IsSuccess { get; set; }

        public string? ErrorMessage { get; set; }
        public string? Message { get; set; }


    }
}
