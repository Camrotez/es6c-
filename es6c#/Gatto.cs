
namespace es6c_
{
    public class Gatto : Animals
    {
        public Gatto(string name) : base(name)
        {
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} miao");
        }
    }
}
