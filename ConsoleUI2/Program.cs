using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach(var item in carManager.GetAll())
            {
                Console.WriteLine("Car Name  : " +item.CarName);
            }
          

            Console.ReadKey();
        }
    }
}
