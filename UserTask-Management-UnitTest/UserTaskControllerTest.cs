using Microsoft.AspNetCore.Mvc;
using Moq;
using Usertask_Management_BusinessLayer.Interface;
using Usertask_Management_Entity.RequestModel;
using Usertask_Management_Entity.ResponseModel;
using Usertask_Management_Services.ControllerCollection;
using UserTask_Management_UnitTest.MockData;

namespace UserTask_Management_UnitTest
{
    [TestClass]
    public class UserTaskControllerTest
    {
        private readonly UserTaskController userTaskController;
        private readonly Mock<IUserTaskBusiness> userTaskBusiness = new Mock<IUserTaskBusiness>();


        public UserTaskControllerTest()
        {
            userTaskController = new UserTaskController(userTaskBusiness.Object);
        }

        [TestMethod]
        [DynamicData(nameof(NewTaskMockData.UserTaskController_TestData),typeof(NewTaskMockData),DynamicDataSourceType.Method)]
        public async Task AddTask(NewTask newTask, ResponseBase response, bool result)
        {
            
            userTaskBusiness.Setup(x => x.AddTask(It.IsAny<NewTask>())).ReturnsAsync(result);

            var res = userTaskController.AddTask(newTask);
            var val = ((ObjectResult)res.Result).Value;
            Assert.IsNotNull(res);
            Assert.AreEqual(response, val);
            
        }
    }
}
