using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _8._6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XElement data = CreateXelement();
            UploadFile(data);

        }

        private static XElement CreateXelement()
        {
            XElement xPerson = new XElement("Person");
            xPerson.SetAttributeValue("name",GetString("Введите имя: "));
            
            XElement Adress = new XElement("Adress", 
                new XElement("Street",GetString("Введите название улицы")),
                new XElement ("HouseNumber",GetString("Введите номер дома")),
                new XElement("FlatNumber",GetString("Введите название квартиры")));
            xPerson.Add(Adress);

            XElement Phones = new XElement("Phones",
                new XElement("MobilePhone",GetString("Введите номер телефона")),
                new XElement("FlatPhone",GetString("Введите номер домашнего телефона")));
            xPerson.Add(Phones);
            return xPerson;

        } 
        private static string GetString(string text)
        {
            Console.WriteLine(text);
            string answer = Console.ReadLine();
            return answer;


        }
        private static void UploadFile(XElement data) {

            using (Stream stream = new FileStream("./file.xml", FileMode.Append, FileAccess.Write))
            {
                data.Save(stream);
                
            }

        }


    }
}
