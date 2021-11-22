using System;

namespace IEquatablePractic
{
    internal class Program : IEquatable<Program>
    {
        public string exampleData;

        static void Main(string[] args)
        {
            
        }

        public bool Equals(Program other)
        {
            if(other == null)
            {
                return false;
            }

            return exampleData.GetHashCode().Equals(other.exampleData.GetHashCode());
        }
    }
}
