
namespace es6c_
{
    public class Cane : Animals
    {
        public Cane(string name) : base(name) 
        {
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} woof");
        }
    }
}
