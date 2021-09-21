using System;
using System.Collections.Generic;
using System.Text;

namespace S6_ListViewExample {
    public class Docente 
    { 
        public string Name { get; set; }

        public string LastName { get; set; }

        public string DisplayName
        {
            get
            {
                return $"{Name}, {LastName}";
            }
        }

    }

    public class DocenteList : List<Docente>
    {
        public string Cabecera { get; set; }

        public List<Docente> Docentes => this;

        public DocenteList(string Cabecera)
        {
            Cabecera = Cabecera;
        }

        public DocenteList()
        {
        }





    }

    
}
