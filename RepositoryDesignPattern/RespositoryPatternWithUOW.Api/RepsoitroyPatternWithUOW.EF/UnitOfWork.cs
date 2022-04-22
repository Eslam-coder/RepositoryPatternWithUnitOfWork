using RepsoitroyPatternWithUOW.Core.Models;
using RepsoitroyPatternWithUOW.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepsoitroyPatternWithUOW.EF.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ApplicationDBContext _context;
        public IBaseRepository<Author> Authors { get; private set; }
        public IBookRepository Books { get; private set; }
        public UnitOfWork(ApplicationDBContext context)
        {
            _context = context;
            Authors = new BaseRepository<Author>(_context);
            Books = new BooksRepository(_context);
        }

        //return no of rows affected in database 
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
           _context.Dispose();
        }
    }
}
