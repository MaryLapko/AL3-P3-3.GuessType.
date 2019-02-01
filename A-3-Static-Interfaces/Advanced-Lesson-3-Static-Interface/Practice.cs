using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_3_Static_Interface
{
    public partial class Practice
    {
        /// <summary>
        /// AL3-P1/3. Создать класс UniqueItem c числовым полем Id. 
        /// Каждый раз, когда создается новый экземпляр данного класса, 
        /// его идентификатор должен увеличиваться на 1 относительно последнего созданного. 
        /// Приложение должно поддерживать возможность начать идентификаторы с любого числа. 
        /// </summary>
        public static void AL3_P1_3()
        {
            for (int i = 0; i < 100; i++)
            {
                PracticeID a = new PracticeID();
            }
            Console.WriteLine(PracticeID.id);
            
        }

        /// <summary>
        /// AL3-P2/3. Отредактировать консольное приложение Printer. 
        /// Заменить базовый абстрактный класс на интерфейс.
        /// </summary>
        public static void AL3_P2_3()
        {

        }

        public static void GuessType<T>(T item)
        {
            switch(Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.String:
                    {
                        string value = item as string;
                        if (value.Length == 5)
                        {
                            Console.WriteLine("You entered a string of 5 symbols");
                            return;
                        }
                        break;
                    }
                case TypeCode.Int32:
                    {
                        int? value = item as int?;
                        if (value > 0)
                        {
                            Console.WriteLine("You entered a simple integer");
                            return;
                        }
                        break;
                    }
                case TypeCode.Decimal:
                    {
                        decimal? value = item as decimal?;
                        if (5 == BitConverter.GetBytes(decimal.GetBits(value.Value)[3])[2])
                        {
                            Console.WriteLine("You entered a real number with 5 sygnificant digits");
                            return;
                        }
                        break;
                    }
                case TypeCode.DateTime:
                    Console.WriteLine("You entered time");
                    return;
                default:
                    Console.WriteLine("I don't know what type you entered");
                    break;
            }

            Console.WriteLine("I don't know what type you entered");

        }


        /// <summary>
        /// AL3-P3/3. Создайте обобщенный метод GuessType<T>(T item), 
        /// который будет принимать переменную обобщенного типа и выводить на консоль, 
        /// что это за тип был передан.
        /// </summary>
        public static void AL3_P3_3()
        {
        }

        public class PracticeID
        {
            public static int id {get; set;}
            public string name;

            public PracticeID() //simple constructor
            {
                id++;
            }
            static PracticeID()//static construction
            {
                id = 1000;
            }
        }
    }    
}
