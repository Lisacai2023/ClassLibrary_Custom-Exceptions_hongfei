using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Player
    {
        string _name;
        string _number;

        public Player(string name, string number)
        {
            _name=name;
            _number=number;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (!value.Equals(string.Empty))
                {
                    _name = value;
                }
                else
                {
                    throw new PlayerException(" Enter a name ");
                }

            }
        }
        public string Number
        {
            get => _number;
            set
            {
                bool length = value.Length >=1 && value.Length <=3;
                int tempValue = 0;
                bool isNumber = int.TryParse(value, out tempValue);
                if (length && isNumber)
                {
                    _number= value;

                }
                else
                {
                    throw new PlayerException($" Enter number is {value}, enter a valid number between 1 and 999");
                }
            }

        }

        public override string ToString()
        {
            return $"Name - {_name}; Number - {_number}";
        }

    }
}
