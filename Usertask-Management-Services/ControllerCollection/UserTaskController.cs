using Microsoft.AspNetCore.Mvc;
using Usertask_Management_BusinessLayer.Interface;
using Usertask_Management_Entity.RequestModel;
using Usertask_Management_Entity.ResponseModel;

namespace Usertask_Management_Services.ControllerCollection
{
    [Produces("applicaion/json")]
    public class UserTaskController : Controller
    {
        private readonly IUserTaskBusiness userTaskBusiness;

        public UserTaskController(IUserTaskBusiness userTaskBusiness)
        {
            this.userTaskBusiness = userTaskBusiness;
        }
        [HttpPost]
        [Route("api/AddTask")]
        public async Task<IActionResult> AddTask([FromBody] NewTask newTask)
        {
            if (newTask == null)
            {
                return BadRequest("Invalid data");
            }
            ResponseBase response = new ResponseBase() { IsSuccess = false};
            try
            {
                var result = await userTaskBusiness.AddTask(newTask);
                if (result)
                {
                    response.IsSuccess = true;
                    response.Message = "Task Added Successfully";
                }
                else
                {
                    response.Message = "Failed to add task";
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessage = ex.Message;
                response.Message = "Failed to add task";
            }
            return this.Ok(response);
        }

        [HttpPut]
        [Route("api/UpdateTask/{id}")]
        public async Task<IActionResult> UpdateTask(int id, [FromBody] NewTask newTask)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid data");
            }
            if (newTask == null)
            {
                return BadRequest("Invalid data");
            }
            ResponseBase response = new ResponseBase() { IsSuccess = false };
            try
            {
                var result = await userTaskBusiness.UpdateTask(id,newTask);
                if (result)
                {
                    response.IsSuccess = true;
                    response.Message = "Task Updated Successfully!";
                }
                else
                {
                    response.Message = "Failed to update task";
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Failed to update task";
                response.ErrorMessage = ex.Message;
            }
            return this.Ok(response);
        }
    }
}
