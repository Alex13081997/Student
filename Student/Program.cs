using System;
using System.Collections.Generic;
namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> spisak = new List<Student>();
            //spisak.Add(new Student() { id = 1,name = "Alex" });
            //spisak.Add(new Student() { id = 2, name = "Bob" });
            //spisak.Add(new Student(1, "Alex"));
            

            //spisak.Add(new Student()
            //{ 

            //    Id = Convert.ToInt32(Console.ReadLine()),
            //    Name = Convert.ToString(Console.ReadLine()),
            //    Surname = Convert.ToString(Console.ReadLine()),
            //    Lastname = Convert.ToString(Console.ReadLine()),
            //    Birthday = Convert.ToString(Console.ReadLine()),
            //    Faculty = Convert.ToString(Console.ReadLine()),
            //    CourseNumber = Convert.ToInt32(Console.ReadLine()),
            //    GroupNumber = Convert.ToInt32(Console.ReadLine()),


            //});

            


            while (true)
            {
                Console.WriteLine("----------Регистрация студентов----------");
                Console.WriteLine("\n\n\n\n\t\tМеню");
                Console.WriteLine("\n\n1.Регистрация студента");
                Console.WriteLine("2.Список студентов");
                Console.WriteLine("3.Удаление студентов");
                Console.WriteLine("4.Изменение студентов");
                Console.WriteLine("0.Выход");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Ввод данных");
                        
                        int velID = 0;
                        for (int i = 0; i < spisak.Count; i++)
                        {
                            velID++;
                        }
                        try
                        {

                            Console.Write("Имя: ");
                            string name = Console.ReadLine();
                            Console.Write("Фамилия: ");
                            string surname = Console.ReadLine();
                            Console.Write("Отчество: ");
                            string lastname = Console.ReadLine();
                            Console.Write("День рождение: ");
                            string birthday = Console.ReadLine();
                            Console.Write("Адресс: ");
                            string adrress = Console.ReadLine();
                            Console.Write("Номер телефона: ");
                            string phonenumber = Console.ReadLine();
                            Console.Write("Факультет: ");
                            string faculty = Console.ReadLine();
                            Console.Write("Номер курса: ");
                            int coursenumber = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Номер группы: ");
                            int groupnumber = Convert.ToInt32(Console.ReadLine());
                            spisak.Add(new Student()
                            {
                                Id = velID,
                                Name = name,
                                Surname = surname,
                                Lastname = lastname,
                                Birthday = birthday,
                                Address = adrress,
                                PhoneNumber = phonenumber,
                                Faculty = faculty,
                                CourseNumber = coursenumber,
                                GroupNumber = groupnumber
                            });
                            Console.WriteLine("\n Успешная регистрация!");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ошибка ввода данных");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                          void GetInfo()
                        {

                            Console.Clear();
                            Console.WriteLine("Список студентов");
                            foreach (var i in spisak)
                            {
                                Console.Write($"\n{ i.Id}|{i.Name}|{i.Surname}|{i.Lastname}|" +
                                    $"{i.Birthday}|{i.Address}|{i.PhoneNumber}|{i.Faculty}" +
                                    $"|{i.CourseNumber}|{i.GroupNumber}");
                                
                            }
                           
                        }


                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                       
                        GetInfo();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        GetInfo();
                        Console.WriteLine("\n\n\tНажмите Id что бы удалить ");
                        var Del = Convert.ToInt32(Console.ReadLine());
                        spisak.RemoveAt(Del);
                        Console.Clear();
                        GetInfo();
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "4":
                        Console.Clear();
                        GetInfo();
                        Console.WriteLine("\n\n\tВыберите строку ");
                        var Insert = Convert.ToInt32(Console.ReadLine());
                        velID = Insert;
                        void GetInfo_2()
                        {
                            Console.WriteLine($"{spisak[Insert].Id}|{spisak[Insert].Surname}|{spisak[Insert].Lastname}|" +
                                $"" +
                                $"{spisak[Insert].Birthday}|{spisak[Insert].Address}|{spisak[Insert].PhoneNumber}|{spisak[Insert].Faculty}" +
                                $"|{spisak[Insert].CourseNumber}|{spisak[Insert].GroupNumber}");
                        }
                        
                        Console.Clear();

                        GetInfo_2();
                        Console.WriteLine("\n\t\tВыберите, что хотите изменить");
                        Console.WriteLine("1.name");
                        Console.WriteLine("2.surname");
                        Console.WriteLine("3.lastname");
                        Console.WriteLine("4.birtday");
                        Console.WriteLine("5.address");
                        Console.WriteLine("6.phonenumber");
                        Console.WriteLine("7.faculty");
                        Console.WriteLine("8.coursenumber");
                        Console.WriteLine("9.grouphnumber");
                        Console.WriteLine("0.Выход");
                        int insert_2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (insert_2)
                        {
                            case 1:
                                Console.Write("name: ");
                                spisak[Insert].Name = Convert.ToString(Console.ReadLine());
                                GetInfo_2();
                                Console.ReadKey();
                                Console.Clear();

                                break;
                            case 2:
                                Console.Write("Surname: ");
                                spisak[Insert].Surname = Convert.ToString(Console.ReadLine());
                                GetInfo_2();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 3:
                                Console.Write("lastname: ");
                                spisak[Insert].Lastname = Convert.ToString(Console.ReadLine());
                                GetInfo_2();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 4:
                                Console.Write("birtday: ");
                                spisak[Insert].Birthday = Convert.ToString(Console.ReadLine());
                                GetInfo_2();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 5:
                                Console.Write("address: ");
                                spisak[Insert].Address = Convert.ToString(Console.ReadLine());
                                GetInfo_2();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 6:
                                Console.Write("phonenumber: ");
                                spisak[Insert].PhoneNumber = Convert.ToString(Console.ReadLine());
                                GetInfo_2();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 7:
                                Console.Write("faculty: ");
                                spisak[Insert].Faculty = Convert.ToString(Console.ReadLine());
                                GetInfo_2();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 8:
                                Console.Write("coursenumber : ");
                                spisak[Insert].CourseNumber = Convert.ToInt32(Console.ReadLine());
                                GetInfo_2();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 9:
                                Console.Write("grouphnumber: ");
                                spisak[Insert].GroupNumber = Convert.ToInt32(Console.ReadLine());
                                GetInfo_2();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 0:
                                return;


                            default: 
                                Console.WriteLine("error");
                                break;
                        }

                        break;
                    case "0":

                        return;
                    default:
                        Console.WriteLine("Ошибка ввода");
                        break;


                }
            }

        }
    }
}
