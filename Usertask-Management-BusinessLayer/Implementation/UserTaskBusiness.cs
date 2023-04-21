using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usertask_Management_BusinessLayer.Interface;
using Usertask_Management_Entity.RequestModel;
using Usertask_Management_Repository.Interface;

namespace Usertask_Management_BusinessLayer.Implementation
{
    public class UserTaskBusiness : IUserTaskBusiness
    {
        private readonly IUserTaskRepository userTaskRepository;
        public UserTaskBusiness(IUserTaskRepository userTaskRepository)
        {
            this.userTaskRepository = userTaskRepository;
        }
        public async Task<bool> AddTask(NewTask newTask)
        {
            var result = false;
            try
            {
                result = await userTaskRepository.AddTask(newTask);
            }
            catch (Exception ex)
            {
                return false;
            }
            return result;
        }  

        public async Task<bool> UpdateTask(int id, NewTask newTask)
        {
            var result = false;
            try
            {
                result = await userTaskRepository.UpdateTask(id, newTask);
            }
            catch (Exception ex)
            {
                return false;
            }
            return result;
        }
    }
}
