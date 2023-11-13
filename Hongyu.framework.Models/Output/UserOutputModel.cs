using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hongyu.framework.Models.Output
{
    public class UserOutputModel
    {
        public List<UserOutput> userOutputList { get; set; }

    }
    public class UserOutput { 
            public string Name { get; set; }
    
    }
}
