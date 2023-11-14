using System.Threading.Channels;

namespace es6c_
{
    public class Animals
    {
        public string Name { get; set; }

        public Animals(string name)
        {
            this.Name = name;
        }

        public virtual void Speak()
        {
            Console.WriteLine($"verso del {Name}");
        }
    }
}
