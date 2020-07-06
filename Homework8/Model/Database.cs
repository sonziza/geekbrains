using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework8.Model
{
    public class Taxi
    {
        public string Name { get; set; }//Название таксопарка
        public string Adress { get; set; }//Адрес
        public string Phone { get; set; }//Телефон таксопарка
        public string Email { get; set; }//Электронная почта

        //Для сериализации должен быть пустой конструктор.
        public Taxi()
        {
        }

        public Taxi(string name, string adress, string phone, string email)
        {
            this.Name = name;
            this.Adress = adress;
            this.Phone = phone;
            this.Email = email;

        }
    }

    class Database
    {
        //уведомление об изменении текущего элемента
        public Action ChangeCurrent { get; private set; }

        List<Taxi> taxiList;
        int current = -1;

        public int Current
        {
            get
            {
                return current;
            }
            private set
            {
                current = value;
                ChangeCurrent?.Invoke();
            }

        }

        public Database()
        {
            taxiList = new List<Taxi>();
            Current = -1;
        }

        public Database(Action updateInfo)
        {
            taxiList = new List<Taxi>();
            Current = -1;
            ChangeCurrent = updateInfo;
        }

        public void Add(Taxi question)
        {
            taxiList.Add(question);
            Current = taxiList.Count - 1;
        }

        public void RemoveCurrent()
        {
            if (current == -1) return;
            taxiList.RemoveAt(Current);
            Current--;
        }

        public void Next()
        {
            if (current + 1 < taxiList.Count) Current++;

        }

        public void Prev()
        {
            if (current > 0) Current--;
        }

        public Taxi GetCurrent
        {
            get
            {
                if (current == -1) return null;
                else return taxiList[current];
            }
        }

        public int Count
        {
            get { return taxiList.Count; }
        }

        public void Save(string filename)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Taxi>));
            Stream fStream = new FileStream(filename, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, taxiList);
            fStream.Close();
        }

        public void Load(string filename)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Taxi>));
            Stream fStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            taxiList = (List<Taxi>)xmlFormat.Deserialize(fStream);
            Current = 0;
            fStream.Close();
        }

    }
}
