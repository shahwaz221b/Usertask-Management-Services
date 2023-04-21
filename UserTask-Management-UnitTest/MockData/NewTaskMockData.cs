using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usertask_Management_Entity.RequestModel;
using Usertask_Management_Entity.ResponseModel;

namespace UserTask_Management_UnitTest.MockData
{
    public class NewTaskMockData
    {
        public static IEnumerable<object[]> UserTaskController_TestData()
        {
            return new[] 
            { 
                new object[] 
                {
                    new NewTask()
                    {
                        Id = 1,
                        Name = "test",
                        Deadline = "24/04/2023",
                        Description = "Description"
                    },
                    new ResponseBase()
                    {
                        IsSuccess = true,
                        Message = "Task Added Successfully",
                        ErrorMessage = "",
                    },
                    true
                }
            };
        }
    }
}
