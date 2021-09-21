using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEFAutoLot.DAL.EF;

namespace DotNetEFAutoLot.DAL
{
    public class Repository
    {
        public int AddNewRecord(Car car)
        {
            using (var context = new AutoLotEntities())
            {
                try
                {
                    context.Cars.Add(car);
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

        public void AddNewRecords(IEnumerable<Car> carsToAdd)
        {
            using (var context = new AutoLotEntities())
            {
                context.Cars.AddRange(carsToAdd);
                context.SaveChanges();
            }
        }

        public void PrintAllInventory()
        {
            using (var context = new AutoLotEntities())
            {
                foreach (var car in context.Cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
