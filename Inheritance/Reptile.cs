using System;
namespace Inheritance
{
    public class Reptile:Animal
    {
        public Reptile()
        {
            IsLiving = true;
            Name = "reptile";
            CanReproduce = true;
            Age = 2;
        }

        public int Eyes { get; set; }
        public bool HasScales { get; set; }
        public bool IsColdBlooded { get; set; }
        public int Length { get; set; }
    }
}
