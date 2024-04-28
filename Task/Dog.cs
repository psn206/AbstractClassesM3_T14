using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Dog : Animal
    {

        private string name;
        private string voice;
        public Dog(string name, string voice) : base(name)
        {
            this.voice = voice;
        }
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public string Voice
        {
            get => voice;
            set => voice = value;
        }
        public override void Say()
        {
            Console.WriteLine(Voice);
        }
    }
}

