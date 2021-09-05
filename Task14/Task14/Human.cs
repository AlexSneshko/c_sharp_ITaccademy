using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Task14
{
    public class Human
    {
        [Pattern(@"^[A-Za-z]+$")]
        private string Name { get; }
        [Pattern(@"^[A-Za-z]+$")]
        private string Surname { get; }
        [Pattern(@"^\d{1,2}$")]
        private int Age { get; }

        public Human(string name, string surname, int age) => (Name, Surname, Age) = (name, surname, age);

        public bool CheckProperties()
        {
            var properties = GetType().GetProperties(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach(var property in properties)
            {
                foreach (var attribute in property.GetCustomAttributes(false))
                {
                    if(attribute is PatternAttribute)
                    {
                        var customAttribute = attribute as PatternAttribute;                 

                        if (!customAttribute.CheckPattern(property.GetValue(this).ToString()))
                        {
                            Console.WriteLine("Property {0} has mistake", property.Name);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public override string ToString() => $"{Name} {Surname}, age: {Age}";
    }
}
