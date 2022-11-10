using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class FootballPlayer
    {   /// <summary>
        /// 1) Vi har nogle restrictioner:
        /// Id:         int         id > 0
        /// Name:       string      Minimum 2 characters
        /// 2) Få bruget "Pæren" ude i venstre side for syntax hjælp (hover over den del du vil arbejde med for forskellige muligheder)
        /// </summary>
        private int _shirtNumber;
        private string _name;

        public int Id { get; set; }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length < 2) throw new ArgumentException("Name: Has to be between 2 - 20 characters");
                _name = value;
            }
        }

        public int Age { get; set; }
        public int ShirtNumber
        {
            get { return _shirtNumber; }
            set
            {
                if (value < 1 || value > 99) throw new ArgumentOutOfRangeException("Shirt#: Range 1-99");
                _shirtNumber = value;
            }
        }


        public FootballPlayer(int id, string name, int age, int shirtNumber)
        {
            Id = id;
            Name = name;
            Age = age;
            ShirtNumber = shirtNumber;
        }

        /// <summary>
        /// På et tidspunkt skal objecter gemmes i en fil og åbnes fra en fil.
        /// Når man gemmer obj gemmes det som string - ikke objekter ("String" er en class)
        /// De skal laves om til objecter!
        /// Denne tomme constructor sørger for 
        /// </summary>
        public FootballPlayer()
        {

        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Age)}={Age.ToString()}, {nameof(ShirtNumber)}={ShirtNumber.ToString()}}}";
        }


    }
}
