using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.Library.Model
{
    class PersonInfo
    {
        public int Id { get; set; }
        public int PersonAge { get; set; }
        public string PersonEmail { get; set; }
        public string PersonAddress { get; set; }
        public int PersonId { get; set; }
        public virtual Person People { get; set; }
    }
}
