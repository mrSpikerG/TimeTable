using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTable.Interface;

namespace TimeTable.IRealization.Food
{
    class PotatoFree : IFood
    {
        public override string ToString()
        {
            return "Картошка фри";
        }
    }
}
