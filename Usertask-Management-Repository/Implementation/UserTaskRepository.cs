using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usertask_Management_Entity.RequestModel;
using Usertask_Management_Repository.Interface;

namespace Usertask_Management_Repository.Implementation
{
    public class UserTaskRepository : IUserTaskRepository
    {
        public async Task<bool> AddTask(NewTask newTask)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateTask(int id, NewTask newTask)
        {
            throw new NotImplementedException();
        }
    }
}
