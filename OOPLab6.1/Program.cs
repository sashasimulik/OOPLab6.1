using System;

namespace OOPLab6._1
{
    public interface ICatalog
    {
        public void print();
    }

    class Catalog : ICatalog

    {

        string[] Mark = { "Mercedes e55", "Dodge Viper", "Nissan Murano", "Fiat Linea", "Daewoo Matiz", "VW Passat", "Skoda Octavia", "Mercedes c220", "Ford Focus", "VW Golf VII" };

        string[] Colour = { "Чорний", "Жовтий", "Бордо", "Мiдний", "Бiлий", "Латунь", "Вишня", "Фiолет", "Iскра", "Зелений" };

        string[] Number = { "АО2002ОА", "АО6666ВП", "AО1339ВВ", "АО5282ВН", "АО7668АМ", "AO4467СВ", "АО7831СК", "АО7080КЛ", "AО1032АА", "АО5553ВК" };

        string[] Year = { "2004", "2000", "2010", "2012", "2008", "2006", "2011", "2006", "2003", "2016" };

        string[] OwnerData = { "Симулик О.О. 2002р.н.", "Кикало В.В. 1985р.н.", "Логойда В.М. 2001р.н.", "Симулик О.Д. 1967р.н.", "Симулик В.М. 1977р.н.", "Фiлiмонов Р.Е. 2002р.н.", "Фогел Д.Д. 1999р.н.", "Чопик О.С. 2002р.н.", "Мусловий Б.М. 1988р.н.", "Голперт А.М. 2002р.н. " };

        public Catalog()

        {
        }

        public void print()

        {
            Console.WriteLine("Марка, модель: \tКолiр: \tНомер: \t Piк: \tIнформацiя про власника: ");

            for (int i = 0; i < 10; i++)

            {

                Console.WriteLine("" + Mark[i] + "\t" + Colour[i] + "\t" + Number[i] + " " + Year[i] + "\t" + OwnerData[i]);

            }

        }

        public static void Main()

        {

            Catalog s1 = new Catalog();

            s1.print();

        }

    }

}


