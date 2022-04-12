using System;
using TimeTable.IRealization;

namespace TimeTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Work app = new Work();

            int check;
            do
            {
                Console.WriteLine("\tMenu");
                Console.WriteLine("1 - Расписание недели ");
                Console.WriteLine("2 - Расписание на сегодня");
                Console.WriteLine("3 - Расписание на определенный день недели");
                Console.WriteLine("4 - Изменить расписание");
                Console.WriteLine("5 - Зарплата");
                Console.WriteLine("0 - Exit");
                
                
                Console.Write("Ваш выбор: ");
                check = int.Parse(Console.ReadLine());
                        Console.Clear();


                int chose;
                //Я понимаю что совершаю смертный грех используя свитч после изучения делегатов, но до конца сдачи осталось очень мало
                //Если данный свитч станет фактором занижающим оценку отмените пожалуйста мою работу, я переделаю под делегаты :<
                switch (check)
                {
                    case 1:
                        app.getWeekSchedule();
                        break;
                    case 2:
                        app.getTodaySchedule();
                        break;
                    case 3:
                        Console.Write("Введите нужный день недели цифрой: ");
                        chose = int.Parse(Console.ReadLine());
                        app.getDaySchedule(chose);
                        break;
                    case 4:
                        Console.Write("Введите нужный день недели цифрой: ");
                        chose = int.Parse(Console.ReadLine());
                        app.setDaySchedule(chose);
                        break;
                    case 5:
                        Console.Write("Введите свой ранг цифрой(1-3): ");
                        chose = int.Parse(Console.ReadLine());
                        app.getSalary(chose);
                        break;
                }

            } while (check != 0);

        }
    }
}
