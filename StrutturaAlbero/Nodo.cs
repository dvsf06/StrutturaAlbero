using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrutturaAlbero
{
    public class Nodo
    {
        static int nextId = 0;

        int idNodo;
        string valore;
        List<Nodo> nodiSuccessivi;

        public Nodo(string Valore)
        {
            idNodo = nextId;
            valore = Valore;
            nodiSuccessivi = new List<Nodo>();
            nextId++;
        }

        public int IdNodo { get => idNodo; set => idNodo = value; }
        public string Valore { get => valore; set => valore = value; }
        public List<Nodo> NodiSuccessivi { get => nodiSuccessivi; set => nodiSuccessivi = value;}
    }
}