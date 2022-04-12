using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable.Interface
{
    public interface IDay
    {
        
        public IFood getSmena(int smena);

        public void setSmena(IFood food,int smena);
    }
}
