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
        [HttpGet]
        public ActionResult GetUser([FromQuery] ObjectId objectId)
        {
            var user = _userRepository.GetUserById(objectId);
            return Ok(user);
        }
    }
}
