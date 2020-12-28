using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.core
{
    public class Return<T>
    {
        public int state { get; set; }//1成功，0失败
        public T body { get; set; }
        public string msg { get; set; }
    }
}
