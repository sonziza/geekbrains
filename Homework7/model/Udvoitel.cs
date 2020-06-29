using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Udvoitel
    {
        int current = 1;//текущей число
        int count = 0;//количество шагов
        public int Finish { get; private set; }
        Stack<int> history = new Stack<int>();//история игры в виде стека (https://ru.wikipedia.org/wiki/%D0%A1%D1%82%D0%B5%D0%BA)


        public int Current
        {
            get { return current; }
        }


        public int Count
        {
            get { return count; }
        }

        //минимальное кол-во ходов
        public int Steps
        {
            get
            {
                int f = Finish;
                int i = 0;
                while (f != 1)
                {
                    f = f % 2 == 0 ? f / 2 : f - 1;
                    i++;
                }
                return i;
            }
        }

        public Udvoitel(int min, int max)
        {
            Finish = new Random().Next(min, max + 1);
        }

        public Udvoitel()
        {
            Finish = new Random().Next(10, 101);
        }

        public Udvoitel(int finish)
        {
            this.Finish = finish;
        }


        public int Plus()
        {
            count++;
            history.Push(current);
            current++;
            return current;
        }

        public int Multi()
        {
            count++;
            history.Push(current);
            current *= 2;
            return current;
        }

        public void Reset()
        {
            current = 1;
            history.Clear();
            count = 0;
        }

        public int Back()
        {
            if (history.Count != 0) return history.Pop(); else return 1;
        }

        public override string ToString()
        {
            return current.ToString();
        }


    }
}
