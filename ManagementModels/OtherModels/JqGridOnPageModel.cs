using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementModels
{
    public class JqGridOnPageModel
    {
        public int page { get; set; }
        public int total { get; set; }
        public int records { get; set; }
        public Object rows { get; set; }
    }
}
