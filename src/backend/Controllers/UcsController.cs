using backend.Domain.Entities;
using backend.Domain.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UcsController : ControllerBase
    {
        private IUcRepository _repository { get; set; }

        public UcsController(IUcRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public IEnumerable<Uc> Get()
        {
            return _repository.GetAll();
        }


        [HttpGet("{id}")]
        public Uc Get(long id)
        {
            return _repository.Get(id);
        }
    }
}
