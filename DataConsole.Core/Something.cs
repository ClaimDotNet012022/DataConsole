using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConsole.Core
{
    public class Something
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<SomethingElse> SomethingElses { get; set; }
    }
}
