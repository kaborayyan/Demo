using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Car
    {
        #region Properties
        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }

        public override string ToString()
        {
            return $"Car Id: {Id}\nModel Name: {Model}\nCar Speed: {Speed}";
        }
        #endregion
        
        #region Constructors        
        public Car(int id, string model, double speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
        }

        // Constructor Overloading
        // Must be different in numbers of passed parameters or
        // their order or type of parameters
        // Constructor chaining is used to avoid repeating the code

        //public Car(int id, string model) // Constructor OverLoading
        //{
        //    Id = id;
        //    Model = model;
        //    Speed = 200;
        //}
        
        public Car(int id, string model):this(id, model,200) // Constructor Chaining
        {            
        }

        //public Car(int id) // Constructor Overloading
        //{
        //    Id = id;
        //    Model = "Toyota";
        //    Speed = 200;
        //}

        public Car(int id):this(id,"Toyota") // Constructor Chaining
        {            
        }

        #endregion
    }
}
