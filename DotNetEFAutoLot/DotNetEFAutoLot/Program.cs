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

        private static void AddNewRecords(Inventory car)
        {
            using (var repo  = new InventoryRepository())
            {
                repo.Add(car);
            }
        }

        private static void UpdateRecord(int carId)
        {
            using (var repo = new InventoryRepository())
            {
                var carToUpdate = repo.GetOne(carId);
                if(carToUpdate == null)
                {
                    return;
                }

                carToUpdate.Color = "Blue";
                repo.Save(carToUpdate);
            }
        }

        private static void RemoveRecordByCar(Inventory car)
        {
            using (var repo = new InventoryRepository())
            {
                repo.Delete(car);
            }
        }

        private static void RemoveRecordById(int carId, byte[] timeStamp)
        {
            using (var repo = new InventoryRepository())
            {
                repo.Delete(carId, timeStamp);
            }
        }
    }
}
