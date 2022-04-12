using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTable.Interface;
using TimeTable.IRealization;
using TimeTable.IRealization.Food;

namespace TimeTable
{

    public class Work
    {
        private static IDay[] day = new IDay[5];
        private static IFood[] foods = new IFood[4];
        public Work()
        {
            day[0] = new Monday();
            day[1] = new Tuesday();
            day[2] = new Wednsday();
            day[3] = new Thursday();
            day[4] = new Friday();

            foods[0] = new Home();
            foods[1] = new Hamburger();
            foods[2] = new IceCream();
            foods[3] = new PotatoFree();
        }


        //Расписание на сегодня
        public void getTodaySchedule()
        {
            Console.WriteLine(day[(int)DateTime.Now.DayOfWeek]);
            Console.WriteLine($"7:00-12:00\t{day[(int)DateTime.Now.DayOfWeek].getSmena(0)}");
            Console.WriteLine($"13:00-20:00\t{day[(int)DateTime.Now.DayOfWeek].getSmena(1)}");
        }

        //Расписание на нужный день
        public void getDaySchedule(int index)
        {
            Console.WriteLine(day[index - 1]);
            Console.WriteLine($"7:00-12:00\t{day[index - 1].getSmena(0)}");
            Console.WriteLine($"13:00-20:00\t{day[index - 1].getSmena(1)}");
        }

        //Изменить расписание 
        public void setDaySchedule(int index)
        {
            //Чтобы показать расписание "до"
            getDaySchedule(index);

            Console.Write("Выберите смену(1,2): ");
            int smena = int.Parse(Console.ReadLine());

            Console.WriteLine("0 - Ничего");
            Console.WriteLine("1 - Бургеры");
            Console.WriteLine("2 - Мороженое");
            Console.WriteLine("3 - Картошка фри");
            Console.Write("Выберите занятие: ");
            int foodChose = int.Parse(Console.ReadLine());
            day[index-1].setSmena(foods[foodChose], smena-1);

        }

        //Расписание на неделю
        public void getWeekSchedule()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(day[i]);
                Console.WriteLine($"7:00-12:00\t{day[i].getSmena(0)}");
                Console.WriteLine($"13:00-20:00\t{day[i].getSmena(1)}");
            }
        }

        //Зарплата Entries: rank (1,2,3)
        //1 - slave
        //2 - jabroni
        //3 - Dungeon Master
        public void getSalary(int rank)
        {
            int sum =0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (!typeof(Home).IsInstanceOfType(day[i].getSmena(j)))
                    {
                        sum += 100;
                    }  
                }
            }
            Console.WriteLine($"Зарплата за неделю: {sum * rank}");
        }
    }
}
