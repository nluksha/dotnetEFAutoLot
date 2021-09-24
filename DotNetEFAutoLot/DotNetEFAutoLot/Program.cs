using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEFAutoLot.DAL;
using DotNetEFAutoLot.DAL.EF;
using DotNetEFAutoLot.DAL.Models;
using DotNetEFAutoLot.DAL.Repositories;

namespace DotNetEFAutoLot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            //var repo = new Repository();
            //var carId = repo.AddNewRecord(new Car { Make = "Yugo2", Color = "Brown2", CarNickName = "Brownie2" });
            //Console.WriteLine($"Added with id ={carId}");

            // repo.RemoveRecordCar(11);
            // repo.UpdateRecord(10);
            //repo.PrintAllInventory();

            // Database.SetInitializer(new MyDataInitializer());
            Console.WriteLine("*** ADO.NET EF Code First *** \n");

            using (var repo = new InventoryRepository())
            {
                foreach (var c in repo.GetAll())
                {
                    Console.WriteLine(c);
                }
            }

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
