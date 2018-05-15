namespace OOPExample.Classes.Example1
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual string Species { get; set; } = "Mammel";
        public Dog()
        {
            
        }
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Description()
        {
            return $"{Name} is {Age} years old!";
        }
        public string Speak(string sound)
        {
            return $"{Name} says {sound}";
        }
    }
}
