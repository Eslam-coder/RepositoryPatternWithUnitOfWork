using RepsoitroyPatternWithUOW.Core.Models;
using RepsoitroyPatternWithUOW.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepsoitroyPatternWithUOW.EF.Repositories
{
    public class BooksRepository : BaseRepository<Book>, IBookRepository
    {
        protected ApplicationDBContext _context;
        public BooksRepository(ApplicationDBContext context) : base(context)
        {

        }

        public IEnumerable<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }
    }
}
