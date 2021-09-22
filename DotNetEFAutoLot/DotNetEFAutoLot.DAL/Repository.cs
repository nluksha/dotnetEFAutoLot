using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEFAutoLot.DAL.EF;
using DotNetEFAutoLot.DAL.Models;

namespace DotNetEFAutoLot.DAL
{
    public class Repository
    {
        public int AddNewRecord(Inventory car)
        {
            using (var context = new AutoLotEntities())
            {
                try
                {
                    context.Inventory.Add(car);
                    context.SaveChanges();

                    return car.CarId;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.InnerException?.Message);
                    return 0;
                }
            }
        }

        public void AddNewRecords(IEnumerable<Inventory> carsToAdd)
        {
            using (var context = new AutoLotEntities())
            {
                context.Inventory.AddRange(carsToAdd);
                context.SaveChanges();
            }
        }

        public void PrintAllInventory()
        {
            using (var context = new AutoLotEntities())
            {
                foreach (var car in context.Inventory)
                {
                    Console.WriteLine(car);
                }
            }
        }

        public void RemoveRecordCar(int carId)
        {
            using (var context = new AutoLotEntities())
            {
                Inventory carToDelete = context.Inventory.Find(carId);

                if (carToDelete != null)
                {
                    context.Inventory.Remove(carToDelete);
                    context.SaveChanges();
                }
            }
        }

        public void UpdateRecord(int carId)
        {
            using (var context = new AutoLotEntities())
            {
                Inventory carToUpdate = context.Inventory.Find(carId);

                if (carToUpdate != null)
                {
                    Console.WriteLine(context.Entry(carToUpdate).State);
                    carToUpdate.Color = "Blue";
                    Console.WriteLine(context.Entry(carToUpdate).State);

                    context.SaveChanges();
                }
            }
        }
    }
}
