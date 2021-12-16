using System;
namespace Inheritance
{
    public class Bird:Animal
    {
        public Bird()
        {
            IsLiving = true;
            Name = "bird";
            CanReproduce = true;
            Age = 0;

        }
       
        public bool HasWings { get; set; }
        public string Color { get; set; }
        public int WingSpan { get; set; }
        public bool LaysEggs { get; set; }
    }
}
