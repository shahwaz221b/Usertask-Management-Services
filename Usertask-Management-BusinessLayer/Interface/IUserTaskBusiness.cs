using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usertask_Management_Entity.RequestModel;

namespace Usertask_Management_BusinessLayer.Interface
{
    public interface IUserTaskBusiness
    {
        Task<bool> AddTask(NewTask newTask);

        Task<bool> UpdateTask(int id, NewTask newTask);
    }
}
