using RepsoitroyPatternWithUOW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepsoitroyPatternWithUOW.Core.Repositories
{
    public interface IBookRepository: IBaseRepository<Book>
    {
        IEnumerable<Book> GetAllBooks();
    }
}
