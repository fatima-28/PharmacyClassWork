using System;
using System.Collections.Generic;
using System.Text;

namespace Task14APRIL
{
    class Medicine
    {
       
        public  int Id { get { return temp; }  }
        public int temp;
        private static int _id;
        public string  Name { get; set; }
        public double Price { get; set; }
             public int Count { get; set; }
        public bool IsDeleted { get; set; }
        public Medicine(string name,double price,int count,bool isDeleted)
        {
            
            _id++;
            temp = _id;
            Name = name;
            Price = price;
            Count = count;
            IsDeleted = isDeleted;

        }
        public void Sell()
        {
            Count--;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Price: {Price}, Count: {Count}, IsDeleted:{IsDeleted}");
        }

    }
}
