using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEFAutoLot.DAL;
using DotNetEFAutoLot.DAL.EF;

namespace DotNetEFAutoLot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            var repo = new Repository();
            //var carId = repo.AddNewRecord(new Car { Make = "Yugo2", Color = "Brown2", CarNickName = "Brownie2" });
            //Console.WriteLine($"Added with id ={carId}");

            repo.PrintAllInventory();

            Console.ReadLine();
        }
    }
}
