using CorpCosts.DAL;
using CorpCosts.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace CorpCosts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyController(ICompanyRepository repository)
        {
            _companyRepository = repository;
        }
        [HttpPost("create")]
        public ActionResult CreateCompany([FromBody] Company obj)
        {
            _companyRepository.Create(obj);
            return Created("", obj);
        }

        [HttpGet("get/{id}")]
        public ActionResult GetCompany([FromRoute] ObjectId id)
        {
            var comp = _companyRepository.GetById(id);
            return Ok(comp);
        }

        [HttpGet("get-all")]
        public ActionResult GetAll()
        {
            var compList = _companyRepository.GetAll();
            return Ok(compList);
        }

        [HttpPost("edit/{id}")]
        public ActionResult EditCompany([FromRoute] ObjectId id, [FromBody] Company obj)
        {
            _companyRepository.Edit(id, obj);
            return Ok();
        }
        [HttpDelete("delete/{id}")]
        public ActionResult DeleteCompany([FromRoute] ObjectId id)
        {
            _companyRepository.Delete(id);
            return Ok();
        }
    }
}
