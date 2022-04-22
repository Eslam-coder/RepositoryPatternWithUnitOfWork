using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepsoitroyPatternWithUOW.Core.Models;
using RepsoitroyPatternWithUOW.Core.Repositories;

namespace RespositoryPatternWithUOW.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        //private readonly IBaseRepository<Book> _baseRepository;
        //public BookController(IBaseRepository<Book> baseRepository)
        //{
        //    _baseRepository = baseRepository;
        //}
        private readonly IUnitOfWork _unitOfWork;

        public BookController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetById()
        {
           // return Ok(_baseRepository.GetById(1));

            return Ok(_unitOfWork.Books.GetById(1));
        }

        [HttpGet]
        public IActionResult GetByIdAsync()
        {
            //return Ok(_baseRepository.GetByIdAsync(1));
            return Ok(_unitOfWork.Books.GetByIdAsync(1));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unitOfWork.Books.GetAll());

           // return Ok(_baseRepository.GetAll());
        }

        [HttpGet("GetByName")]
        public IActionResult GetByName()
        {
            return Ok(_unitOfWork.Books.Find(b => b.Title == "New Book", new[] { "Author" }));
            //return Ok(_baseRepository.Find(b => b.Title == "New Book", new[] {"Author"}));
        }

        [HttpGet("GetAllWithAuthors")]
        public IActionResult GetAllWithAuthors()
        {
            return Ok(_unitOfWork.Books.FindAll(b => b.Title == "New Book", new[] { "Author" }));

            //return Ok(_baseRepository.FindAll(b => b.Title == "New Book", new[] { "Author" }));
        }

        [HttpGet("GetOrdered")]
        public IActionResult GetOrdered()
        {
            return Ok(_unitOfWork.Books.FindAll(b => b.Title.Contains("New Book"), null, null, b => b.Id));

            //return Ok(_baseRepository.FindAll(b => b.Title.Contains("New Book"),null , null,b=>b.Id));
        }

        [HttpGet("AddOne")]
        public IActionResult AddOne()
        {
            var book = _unitOfWork.Books.Add(new Book { Title = "Test3", AuthorId = 1 });
            
            return Ok(_unitOfWork.Complete());

            //return Ok(_baseRepository.Add(new Book { Title="Test3",AuthorId=1}));
        }
    }
}
