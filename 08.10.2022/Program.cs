using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        public enum SubjectExam_1
        {
            english = 1,
            physics,            //1.Нормально назвать информатику
            computersciense

        }
        public struct Students_1
        {
            public string firstname_1;
            public string secondname_1;
            public int age_1;
            public SubjectExam_1 SubjectExam;
            public int points_1;    //2. Нормально назвать переменную

        }
        public struct Citizens_3
        {
            public string name_3;
            public int id_3;
            public string problem_3;
            public int iq_3;
            public int character_3;
        }
        public static void Main(string[] args)
        {
            Students_1 Agieva = new Students_1 { firstname_1 = "Агиева", secondname_1 = "Лилия", age_1 = 18, points_1 = 260, SubjectExam = SubjectExam_1.english };
            Students_1 Arsentev = new Students_1 { firstname_1 = "Арсентьев", secondname_1 = "Кирилл", age_1 = 18, points_1 = 243, SubjectExam = SubjectExam_1.physics };
            Students_1 Ivanova = new Students_1 { firstname_1 = "Иванова", secondname_1 = "Карина", age_1 = 18, points_1 = 255, SubjectExam = SubjectExam_1.english };
            Students_1 Makarova = new Students_1 { firstname_1 = "Макарова", secondname_1 = "Дарья", age_1 = 18, points_1 = 267, SubjectExam = SubjectExam_1.computersciense };
            Students_1 Makhmutova = new Students_1 { firstname_1 = "Махмутова", secondname_1 = "Хадижа", age_1 = 18, points_1 = 261, SubjectExam = SubjectExam_1.english };
            Students_1 Mitrofanov = new Students_1 { firstname_1 = "Митрофанов", secondname_1 = "Леонид", age_1 = 18, points_1 = 250, SubjectExam = SubjectExam_1.physics };
            Students_1 Morozov = new Students_1 { firstname_1 = "Морозов", secondname_1 = "Даниил", age_1 = 18, points_1 = 251, SubjectExam = SubjectExam_1.computersciense };
            Students_1 Saitov = new Students_1 { firstname_1 = "Саитов", secondname_1 = "Марат", age_1 = 18, points_1 = 256, SubjectExam = SubjectExam_1.computersciense };
            Students_1 Khamitov = new Students_1 { firstname_1 = "Хамитов", secondname_1 = "Ринат", age_1 = 18, points_1 = 234, SubjectExam = SubjectExam_1.computersciense };
            Students_1 Shaposhnikova = new Students_1 { firstname_1 = "Щапошникова", secondname_1 = "Екатерина", age_1 = 18, points_1 = 270, SubjectExam = SubjectExam_1.computersciense };

            Dictionary<string, Students_1> StudentsDic = new Dictionary<string, Students_1>()
            {
                {"Агиева", Agieva },
                {"Арсентьев", Arsentev},
                {"Иванова", Ivanova },
                {"Макарова", Makarova },
                {"Махмутова", Makhmutova },
                {"Митрофанов", Mitrofanov },
                {"Морозов", Morozov },
                {"Саитов", Saitov },
                {"Хамитов", Khamitov },
                {"Шпаошникова", Shaposhnikova }
            };
            Console.WriteLine("Домашнее задание #1. Студенты.");
            Console.WriteLine("Словарь до преобразований.");
            foreach (var person in StudentsDic)
            {
                Console.WriteLine($"Ключ:{person.Key} Значение: {person.Value}");
            }
            Console.Write("Введите действие (новый студент, удалить, сортировать): ");
            string action;
            action = Console.ReadLine();
            action.ToLower();
            switch (action)
            {
                case "новый студент":
                    Console.Write("Введите фамилию студента: ");
                    string keyname = Console.ReadLine();
                    Students_1 Name1 = new Students_1();
                    Console.Write("Введите имя студента: ");
                    Name1.firstname_1 = Console.ReadLine();
                    Name1.secondname_1 = keyname;
                    Console.Write("Введите возраст студента: ");
                    Name1.age_1 = int.Parse(Console.ReadLine());
                    Console.Write("Введите сумму баллов за ЕГЭ: ");
                    Name1.points_1 = int.Parse(Console.ReadLine());
                    Console.Write("Введите предмет сдачи ЕГЭ (информатика, английский язык, физика): ");
                    string subject = Console.ReadLine();
                    subject.ToLower();
                    switch (subject)
                    {
                        case "информатика":
                            Name1.SubjectExam = SubjectExam_1.computersciense;
                            break;
                        case "английский язык":
                            Name1.SubjectExam = SubjectExam_1.english;
                            break;
                        case "физика":
                            Name1.SubjectExam = SubjectExam_1.physics;
                            break;
                        default:
                            Console.WriteLine("Вы что-то неправильно ввели");
                            break;
                    }
                    StudentsDic.Add(keyname, Name1);
                    Console.WriteLine("Словарь после преобразований");
                    foreach (var person in StudentsDic)
                    {
                        Console.WriteLine($"Ключ:{person.Key} Значение: {person.Value}");
                    }
                    break;
                case "удалить":
                    Console.Write("Введите фамилию студента, которого вы хотите удалить: ");
                    string deletename = Console.ReadLine();
                    foreach (var person in StudentsDic)
                    {
                        if (deletename == person.Key)
                        {
                            StudentsDic.Remove(person.Key);
                        }
                        else
                        {
                            Console.WriteLine("Такого студента не существует");
                        }
                    }
                    Console.WriteLine("Словарь после преобразований.");
                    foreach (var person in StudentsDic)
                    {
                        Console.WriteLine($"Ключ:{person.Key} Значение: {person.Value}");
                    }
                    break;
                case "сортировать": //Сортировка по значению структура?!?!??!?!?!
                    Console.WriteLine("Словарь после преобразований.");
                    foreach (var person in StudentsDic)
                    {
                        Console.WriteLine($"Ключ:{person.Key} Значение: {person.Value}");
                    }
                    break;
                default:
                    Console.WriteLine("Что-то не так...");
                    break;
            }

            Console.WriteLine("Домашнее задание #2. Викинги и пиво.");
            int[] BBBArray = new int[5];
            Console.Write("Введите числа, названные игроками Bavarian Beer Bears: ");
            int counterBBB = 0;
            for (int i = 0; i < 5; i++)
            {
                BBBArray[i] = int.Parse(Console.ReadLine());


            }
            for (int i = 0; i < 5; i++)
            {

                if (BBBArray[i] == 5)
                {
                    counterBBB++;
                    Console.WriteLine($"Количество 5: {counterBBB}");
                }

            }

            int[] SSArray = new int[5];
            Console.Write("Введите числа, названные игроками Scandinavian Schollers: ");
            int counterSS = 0;
            for (int i = 0; i < 5; i++)
            {
                SSArray[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < 5; i++)
            {

                if (SSArray[i] == 5)
                {
                    counterSS++;
                    Console.WriteLine($"Количество 5: {counterSS}");
                }
            }
            if (counterBBB == counterSS)
            {
                Console.WriteLine("Drinks All Round! Free Beers on Bjorg!");
            }
            else
            {
                Console.WriteLine("Ой, Бьорг - пончик! Ни для кого пива!");
            }

            Console.WriteLine("Домашнее задание #3. ЖЭК");
            Citizens_3 Rick = new Citizens_3 { name_3 = "Rick", id_3 = 1, problem_3 = "оплата", iq_3 = 1, character_3 = 10 };
            Citizens_3 Morty = new Citizens_3 { name_3 = "Morty", id_3 = 2, problem_3 = "отопление", iq_3 = 0, character_3 = 4 };
            Citizens_3 Deyneris = new Citizens_3 { name_3 = "Deyneris", id_3 = 3, problem_3 = "завоевание мира", iq_3 = 1, character_3 = 6 };
            Citizens_3 Karchevsky = new Citizens_3 { name_3 = "Karchevsky", id_3 = 4, problem_3 = "провести пару онлайн", iq_3 = 1, character_3 = 2 };
            Citizens_3 Raskolnikov = new Citizens_3 { name_3 = "Raskolnikov", id_3 = 5, problem_3 = "оплата", iq_3 = 0, character_3 = 1 };
            Stack<Citizens_3> Zina = new Stack<Citizens_3>(5);
            Zina.Push(Rick);
            Zina.Push(Morty);
            Zina.Push(Deyneris);
            Zina.Push(Karchevsky);
            Zina.Push(Raskolnikov);
            Dictionary<int, Citizens_3> Window1 = new Dictionary<int, Citizens_3>(); //отопление
            Dictionary<int, Citizens_3> Window2 = new Dictionary<int, Citizens_3>(); //оплата
            Dictionary<int, Citizens_3> Window3 = new Dictionary<int, Citizens_3>(); //другое
        
            if (Zina.Count > 0)
            {
                Citizens_3 citizen = Zina.Pop(); // Доделать!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
               
                switch (citizen.problem_3)
                {
                    case "оплата":
                        Window2.Add(citizen.id_3, citizen);
                        break;
                    case "отопление":
                        Window1.Add(citizen.id_3, citizen);
                        break;
                    default:
                        Window3.Add(citizen.id_3, citizen);
                        break;
                }

            }

            Console.WriteLine("Домашнее задание #4. Графы");
            

        }

        }


    }

