using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDogApp.Infrastructure.Data.Domain
{
    public class Breed
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public IEnumerable<Dog> Dogs { get; set; } = null!;
    }
}
