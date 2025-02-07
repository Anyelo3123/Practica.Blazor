namespace Practica

{
    public class Servicio
    {
        private List<Car> cars = new List<Car>();

        public List<Car> GetCars()
        {
            return cars;
        }

        public void AddCar(Car car)
        {
            car.Id = cars.Count > 0 ? cars.Max(c => c.Id) + 1 : 1;
            cars.Add(car);
        }

        public void RemoveCar(int id)
        {
            var car = cars.FirstOrDefault(c => c.Id == id);
            if (car != null)
            {
                cars.Remove(car);
            }
        }
    }
}

