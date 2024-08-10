using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs2_rent_sistem.Models
{
    public class PageResult<T>
    {
        public List<T> Result { get; set; }
        public int? Count { get; set; }
    }
}
