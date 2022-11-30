using hometask_8.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_8.Models
{
    internal class Human
    {
        private int _age;

        public string Name;
        public string SurName;
        public int Age
        {
            get => _age;
            set
            {
                if (value <= 0)
                    throw new AgeException();
                _age = value;   
            }
        }
    }
}
