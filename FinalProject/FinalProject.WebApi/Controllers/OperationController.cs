using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        private readonly FinalProjectContext _context;

        private readonly OperationRepository _repo;

        public OperationController(FinalProjectContext context)
        {
            _context = context;

            _repo = new OperationRepository(_context);

            if (_context.Operations.Count() == 0)
            {
                _context.Operations.Add(new Operation { Name = "Method Test1" , ExecutionDate = DateTime.Now, ExecutionTime  = 1234 });
                _context.SaveChanges();
            }
        }

        // GET: api/Operation
        [HttpGet]
        public  ActionResult< IEnumerable<Operation>> Get()
        {
            var obj = _repo.GetAll();

            return obj.ToList();
          
        }

        // GET: api/Operation/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Operation> Get(Guid id)
        {
            return _repo.GetById(id);
        }

        // POST: api/Operation
        [HttpPost]
        public void Post([FromBody] Operation value)
        {
            _repo.Add(value);
        }

        // PUT: api/Operation/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
