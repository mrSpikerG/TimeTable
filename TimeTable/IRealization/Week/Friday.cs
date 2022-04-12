using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTable.Interface;
using TimeTable.IRealization.Food;

namespace TimeTable.IRealization
{
    class Friday : IDay
    {

        private IFood[] Smena ;
      
        public Friday()
        {
            //Значения по умолчанию
            Smena = new IFood[2];
            Smena[0] = new Hamburger();
            Smena[1] = new Home();
        }

        //Entries: smena(0,1)
        public IFood getSmena(int smena)
        {
            return Smena[smena];
        }

        //Entries: Food, smena(0,1)
        public void setSmena(IFood food, int smena)
        {
            Smena[smena] = food;
        }

        public override string ToString()
        {
            return "Friday";
        }
    }
}
