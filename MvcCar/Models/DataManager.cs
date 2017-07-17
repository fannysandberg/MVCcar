using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCar.Models
{
    static public class DataManager
    {
        static List<Car> listOfCars = new List<Car>();

        public static CarsIndexVM[] ListCars()
        {
            return listOfCars
                .Select(c => new CarsIndexVM
                {
                    Brand = c.Brand,
                    ShowAsFast = c.TopSpeed > 250
                })
                .ToArray();
        }

        public static void AddCar(CarsCreateVMcs viewModel)
        {
            Car carToAdd = new Car();
            carToAdd.Brand = viewModel.Brand;
            carToAdd.Doors = viewModel.Doors;
            carToAdd.TopSpeed = viewModel.TopSpeed;


            var tempList = listOfCars
                .Select(c => c.Id)
                .OrderByDescending(c => c)
                .ToArray();

            if (tempList.Length <= 0)
                carToAdd.Id = 1;

            else
            carToAdd.Id = tempList[0] + 1;

            listOfCars.Add(carToAdd);
                
                
        }


        //Innehåller metoden AddCar(CarsCreateVM viewModel) som tar emot en vy-modell och konverterar 
        //den till en bil som sedan adderas till listan
    }
}
