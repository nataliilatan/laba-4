using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attribute
{
    class Subjects
    {
        public string Name;
        public string Position;
        public int Id;
        public string Departament;
        public string Branch_office;
        public Subjects(string name, string position, int id, string depT, string branch)
        {
            Name = name;
            Position = position;
            Id = id;
            Departament = depT;
            Branch_office = branch;
        }
    }
    class Objects
    {
        public string Type;
        public int ID_owner;
        public string Object_name;
        public string Branch_office;
        public int Num;
        public Objects(string type, int id_owner, string object_name, string branch, int num)
        {
            Type = type;
            ID_owner = id_owner;
            Object_name = object_name;
            Branch_office = branch;
            Num = num;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Subjects first = new Subjects("Олег", "Финансовый менеджер", 103, "Финансовый отдел", "Москва");
            Subjects second = new Subjects("Александр", "Программист", 202, "IT отдел", "Казань");
            Subjects third = new Subjects("Анна", "Системный администратор", 101, "IT отдел", "Москва");
            Subjects forth = new Subjects("Светлана", "Маркетинговый менеджер", 201, "Отдел маркетинга", "Казань");
            Subjects fifth = new Subjects("Иван", "Маркетинговый менеджер", 301, "Отдел маркетинга", "Санкт-Петербуг");
            Subjects sixth = new Subjects("Ольга", "Генеральный директор", 102, "Администрация", "Москва");
            List<Subjects> subjects = new List<Subjects>();
            subjects.Add(first);
            subjects.Add(second);
            subjects.Add(third);
            subjects.Add(forth);
            subjects.Add(fifth);
            subjects.Add(sixth);
            Objects one = new Objects("Отчет", first.Id, "Финансовый отчет", first.Branch_office, 1);
            Objects two = new Objects("Заказ", forth.Id, "Заказ на выполнение", forth.Branch_office, 2);
            Objects three = new Objects("Договор", sixth.Id, "Договор о сотрудничестве", sixth.Branch_office, 3);
            Objects four = new Objects("Список", 301, "Список сотрудников", fifth.Branch_office, 4);
            Objects five = new Objects("План", second.Id, "План внедрения новой технологии", second.Branch_office, 5);
            List<Objects> objects = new List<Objects>();
            objects.Add(one);
            objects.Add(two);
            objects.Add(three);
            objects.Add(four);
            objects.Add(five);
 Found:
            Console.WriteLine("Введите ID сотрудника");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < subjects.Count)
            {
                if (x == subjects[i].Id)
                {
                    Console.WriteLine("Вход в систему выполенен под именем " + subjects[i].Name + ", должность - "+ subjects[i].Position);
                    int t = 1;
                    while (t == 1)
                    {
                        Console.WriteLine("Список документов:");
                        for (int j = 0; j < objects.Count; j++)
                        {
                            Console.WriteLine(objects[j].Num + ". " + objects[j].Object_name);
                        }
                        Console.WriteLine("Введите номер документа для взаимодействия от 1 до 5 или 6, если хотите выйти");
                        int y = Convert.ToInt32(Console.ReadLine());
                        switch (y)
                        {
                            case 1:
                                Console.WriteLine("Выберете действие с файлом: w - изменить, e - подтвердить, r - посмотреть");
                                switch (Console.ReadLine())
                                {
                                    case "w":
                                        if (objects[y - 1].ID_owner == subjects[i].Id)
                                        {
                                            Console.WriteLine("Успешно!");
                                        }
                                        else Console.WriteLine("У вас недостаточно прав для действия.");
                                        break;
                                    case "e":
                                        if (subjects[i].Position == "Генеральный директор")
                                        {
                                            Console.WriteLine("Успешно");
                                        }
                                        else Console.WriteLine("У вас недостаточно прав для действия.");
                                        break;
                                    case "r":
                                        if ((objects[y - 1].ID_owner == subjects[i].Id) || subjects[i].Position == "Генеральный директор" || subjects[i].Position == "Системный администратор")
                                        {
                                            Console.WriteLine("Успешно");
                                        }
                                        else Console.WriteLine("У вас недостаточно прав для действия.");
                                        break;
                                }
                                break;
                            case 2:
                                Console.WriteLine("Выберете действие с файлом: w - изменить, e - подтвердить, r - посмотреть");
                                switch (Console.ReadLine())
                                {
                                    case "w":
                                        if (objects[y - 1].ID_owner == subjects[i].Id)
                                        {
                                            Console.WriteLine("Успешно!");
                                        }
                                        else Console.WriteLine("У вас недостаточно прав для действия.");
                                        break;
                                    case "e":
                                        if (subjects[i].Position == "Генеральный директор")
                                        {
                                            Console.WriteLine("Успешно");
                                        }
                                        else Console.WriteLine("У вас недостаточно прав для действия.");
                                        break;
                                    case "r":
                                        Console.WriteLine("Успешно");

                                        break;
                                }
                                break;
                            case 3:
                                Console.WriteLine("Выберете действие с файлом: w - изменить, e - подтвердить, r - посмотреть");
                                switch (Console.ReadLine())
                                {
                                    case "w":
                                        if (objects[y - 1].ID_owner == subjects[i].Id)
                                        {
                                            Console.WriteLine("Успешно!");
                                        }
                                        else Console.WriteLine("У вас недостаточно прав для действия.");
                                        break;
                                    case "e":
                                        if (objects[y - 1].ID_owner == subjects[i].Id)
                                        {
                                            Console.WriteLine("Успешно!");
                                        }
                                        else Console.WriteLine("У вас недостаточно прав для действия.");
                                        break;
                                    case "r":
                                        if (objects[y - 1].ID_owner == subjects[i].Id || subjects[i].Position == "Генеральный директор")
                                        {
                                            Console.WriteLine("Успешно!");
                                        }
                                        else Console.WriteLine("У вас недостаточно прав для действия.");
                                        break;
                                }
                                break;
                            case 4:
                                Console.WriteLine("Выберете действие с файлом: w - изменить, e - подтвердить, r - посмотреть");
                                switch (Console.ReadLine())
                                {
                                    case "w":
                                        if (objects[y - 1].ID_owner == subjects[i].Id)
                                        {
                                            Console.WriteLine("Успешно!");
                                        }
                                        else Console.WriteLine("У вас недостаточно прав для действия.");
                                        break;
                                    case "e":
                                        if (subjects[i].Position == "Генеральный директор" && objects[y - 1].Branch_office == subjects[i].Branch_office)
                                        {
                                            Console.WriteLine("Успешно!");
                                        }
                                        else Console.WriteLine("У вас недостаточно прав для действия.");
                                        break;
                                    case "r":
                                        if (objects[y - 1].Branch_office == subjects[i].Branch_office)
                                        {
                                            Console.WriteLine("Успешно!");
                                        }
                                        else Console.WriteLine("У вас недостаточно прав для действия.");
                                        break;
                                }
                                break;
                            case 5:
                                Console.WriteLine("Выберете действие с файлом: w - изменить, e - подтвердить, r - посмотреть");
                                switch (Console.ReadLine())
                                {
                                    case "w":
                                        if (objects[y - 1].ID_owner == subjects[i].Id)
                                        {
                                            Console.WriteLine("Успешно!");
                                        }
                                        else Console.WriteLine("У вас недостаточно прав для действия.");
                                        break;
                                    case "e":
                                        if (objects[y - 1].Branch_office == subjects[i].Branch_office && subjects[i].Position == "Менеджер IT отдела")
                                        {
                                            Console.WriteLine("Успешно!");
                                        }
                                        else Console.WriteLine("У вас недостаточно прав для действия.");
                                        break;
                                    case "r":
                                        if (objects[y - 1].Branch_office == subjects[i].Branch_office)
                                        {
                                            Console.WriteLine("Успешно!");
                                        }
                                        else Console.WriteLine("У вас недостаточно прав для действия.");
                                        break;
                                }
                                break;
                            case 6:
                                t = 0;
                                goto Found;
                        }

                    }

                }
                    else
                    {
                        i++;
                    }

            }
               

                Console.ReadKey();
            }
        }
    }

