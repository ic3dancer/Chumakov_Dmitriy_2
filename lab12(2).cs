using System;

namespace _12_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y,z,v, kol, kolp,nt;
            string name, surname, passport;
            Eda eda;
            eda = Eda.Nothing;
            Resort resort;
            resort = Resort.excursia;
            Transport transport;
            transport = Transport.avia;
            int age, dni;           
            kol = 0;
            kolp = 0;
            x = 1;
            y = 1;
            z = 1;
            v = 1;
            Console.WriteLine("Тур.Бюро");
            Tourist[] tmass = new Tourist[10];
            Putevka[] tput = new Putevka[10];
            do
            {


                Console.WriteLine("1-ввести данные туриста\n2-ввести данные путевки\n3-вывести список туристов\n4-вывести список путевок\n5-выход");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Введите имя туриста:");
                        name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Введите фамилию туриста:");
                        surname = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Введите пасспортные данные туриста:");
                        passport = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Введите возраст туриста:");
                        age = Convert.ToInt32(Console.ReadLine());
                        tmass[kol] = new Tourist(name,surname,passport,age);
                        Console.WriteLine(tmass[kol].ToString());
                        kol++;
                        break;
                    case 2:
                        Console.WriteLine("Выберите туриста из списка:");
                        nt = Convert.ToInt32(Console.ReadLine());
                        if (nt-1 < kol)
                        {


                            Tourist tr = tmass[nt - 1];
                            Console.WriteLine("Введите дни путевки:");
                            dni = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите вид отдыха путевки:\n1-экскурсия\n2-круиз\n3-шоппинг\n4-морской отдых");
                            y = Convert.ToInt32(Console.ReadLine());
                            switch (y)
                            {
                                case 1:
                                    resort = Resort.excursia;
                                    break;
                                case 2:
                                    resort = Resort.cruise;
                                    break;
                                case 3:
                                    resort = Resort.shopping;
                                    break;
                                case 4:
                                    resort = Resort.sea;
                                    break;
                            }
                            Console.WriteLine("Введите вид транспорта путевки:\n1-автобус\n2-самолет\n3-поезд");
                            z = Convert.ToInt32(Console.ReadLine());
                            switch (z)
                            {
                                case 1:
                                    transport = Transport.bus;
                                    break;
                                case 2:
                                    transport = Transport.avia;
                                    break;
                                case 3:
                                    transport = Transport.train;
                                    break;

                            }
                            Console.WriteLine("Введите питание путевки:\n1-нет\n2-все включено\n3-только завтрак");
                            v = Convert.ToInt32(Console.ReadLine());
                            switch (v)
                            {
                                case 1:
                                    eda = Eda.Nothing;
                                    break;
                                case 2:
                                    eda = Eda.AllInclusive;
                                    break;
                                case 3:
                                    eda = Eda.BreakfastOnly;
                                    break;
                            }

                            tput[kolp] = new Putevka(tr, dni, transport, resort, eda);
                            Console.WriteLine(tput[kolp].ToString());
                            kolp++;
                        }
                        else
                        {
                            Console.WriteLine("Туриста с таким номером нет!");
                        }
                            break;                      
                    case 3:
                        Console.WriteLine("Tourists");
                        for(int i=0;i<kol;i++)
                        {
                            Console.WriteLine((i+1)+". "+tmass[i].ToString());
                            
                        }

                        break;
                    case 4:
                        Console.WriteLine("Putevki");
                        for (int i = 0; i < kolp; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + tput[i].ToString());

                        }
                        break;
                    case 5:
                        Console.WriteLine("Сортировка путевок");

                        break;
                    case 6:
                        Console.WriteLine("The End");
                        break;

                }
            } while (x != 6);


            //Tourist tourist = new Tourist();
            //Console.WriteLine(tourist.ToString());            
            //Tourist tourist1 = new Tourist("Vladimir", "Rabochev", "DH32N21V", 19);
            //Console.WriteLine(tourist1.ToString());

            //Putevka putevka1 = new Putevka("Alexey", "Tabov", "VB23M81F", 24, 14, Transport.avia, Resort.sea,Eda.BreakfastOnly);
            //Console.WriteLine(putevka1.ToString());
            //Putevka putevka2 = new Putevka( tourist , 14, Transport.avia, Resort.sea, Eda.BreakfastOnly);
            //Console.WriteLine(putevka2.ToString());

            Console.ReadKey();


        }
    }
}
