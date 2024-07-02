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
        private readonly UserRepository _userRepository;

        public UserController(IMongoDatabase db)
        {
            var repository = new UserRepository(db);
            _userRepository = repository;
        }

        [HttpPost]
        public ActionResult CreateUser([FromBody] User user)
        {
            _userRepository.CreateUser(user);
            return Created("", user);
        }

        [HttpGet("{id}")]
        public ActionResult GetUser([FromRoute] ObjectId id)
        {
            var user = _userRepository.GetUserById(id);
            return Ok(user);
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var userList = _userRepository.GetAll();
            return Ok(userList);
        }

        [HttpPost("{id}")]
        public ActionResult EditUser([FromRoute] ObjectId id, [FromBody] User user)
        {
            _userRepository.EditUser(id, user);
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteUser([FromRoute] ObjectId id)
        {
            _userRepository.DeleteUser(id); 
            return Ok();
        }
    }
}
    
