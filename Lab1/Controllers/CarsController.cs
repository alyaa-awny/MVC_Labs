using Lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public enum Status
    {
        list,
        table

    }
    public class CarDetails
    {
        public Car? car { get; set; }
        public Status? status { get; set; }
    }
    public class CarsController : Controller
    {
        public IActionResult GetAll()
        {
            var cars = Car.GetCars();
            return View(cars);//here you send model to view now you need to write the model inside the view
        }
        public IActionResult GetDetails(string carModel, Status? status)
        {
            var car = Car.GetCars().First(c => c.Model == carModel);
            CarDetails details = new CarDetails();
            details.car = car;
            details.status = status;
            return View(details);
        }
    }
}
