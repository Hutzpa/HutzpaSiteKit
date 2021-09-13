using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutzpaSiteKit.Models
{
    public class CompositeKeyEntityExample
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public int EntityExampleId { get; set; }

        public EntityExample EntityExample { get; set; }
    }
}
