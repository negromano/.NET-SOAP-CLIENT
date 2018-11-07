using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteSoap.ServiceFootballer;

namespace ClienteSoap.modelo
{
    class Footballer
    {
       private String id ;
       private String name;
       private String forename;
       private  String position ;
       private String club;
       private int number;
       private double height;

        public Footballer()
        {
        }

        public Footballer(string id, string forename, string name,  string position, string club, int number, double height)
        {
            this.Id = id;
            this.Forename = forename;
            this.Name = name;
            this.Position = position;
            this.Club = club;
            this.Number = number;
            this.Height = height;
        }

      

        public string Id { get => id; set => id = value; }
        public string Forename { get => forename; set => forename = value; }
        public string Name { get => name; set => name = value; }
        public string Position { get => position; set => position = value; }
        public string Club { get => club; set => club = value; }
        public int Number { get => number; set => number = value; }
        public double Height { get => height; set => height = value; }

        
        
    }
}
