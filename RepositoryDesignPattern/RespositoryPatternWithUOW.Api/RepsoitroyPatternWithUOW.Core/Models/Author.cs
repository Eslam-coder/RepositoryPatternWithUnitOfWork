using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RepsoitroyPatternWithUOW.Core.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required,MaxLength(150)]
        public string Name { get; set; }

    }
}
