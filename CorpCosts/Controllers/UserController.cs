using CorpCosts.DAL;
using CorpCosts.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CorpCosts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository repository)
        {
            _userRepository = repository;
        }

        [HttpPost("create")]
        public ActionResult CreateUser([FromBody] User user)
        {
            _userRepository.Create(user);
            return Created("", user);
        }

        [HttpGet("get/{id}")]
        public ActionResult GetUser([FromRoute] ObjectId id)
        {
            var user = _userRepository.GetById(id);
            return Ok(user);
        }

        [HttpGet("get-all")]
        public ActionResult GetAll()
        {
            var userList = _userRepository.GetAll();
            return Ok(userList);
        }

        [HttpPost("edit/{id}")]
        public ActionResult EditUser([FromRoute] ObjectId id, [FromBody] User user)
        {
            _userRepository.Edit(id, user);
            return Ok();
        }
        [HttpDelete("delete/{id}")]
        public ActionResult DeleteUser([FromRoute] ObjectId id)
        {
            _userRepository.Delete(id); 
            return Ok();
        }
    }
}
    
