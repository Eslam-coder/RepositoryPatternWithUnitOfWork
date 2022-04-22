using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepsoitroyPatternWithUOW.Core.Models;
using RepsoitroyPatternWithUOW.Core.Repositories;

namespace RespositoryPatternWithUOW.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AuthorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //private readonly IBaseRepository<Author> _baseRepository;
        //public AuthorController(IBaseRepository<Author> baseRepository)
        //{
        //    _baseRepository = baseRepository;
        //}

        [HttpGet]
        public IActionResult GetById()
        {
            return Ok(_unitOfWork.Authors.GetById(1));
        }

        [HttpGet]
        public IActionResult GetByIdAync()
        {
            return Ok(_unitOfWork.Authors.GetByIdAsync(1));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unitOfWork.Authors.GetAll());
        }
    }
}
