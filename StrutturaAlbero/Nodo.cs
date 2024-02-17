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
        int idNodoPrecedente;
        List<Nodo> nodiSuccessivi;

        public Nodo(string Valore)
        {
            idNodo = nextId;
            valore = Valore;
            nodiSuccessivi = new List<Nodo>();
            nextId++;
        }

        public Nodo(string Valore, int IdNodoPrecedente)
        {
            idNodo = nextId;
            valore = Valore;
            idNodoPrecedente = IdNodoPrecedente;
            nodiSuccessivi = new List<Nodo>();
            nextId++;
        }

        public int IdNodo { get => idNodo; set => idNodo = value; }
        public string Valore { get => valore; set => valore = value; }
        public int IdNodoPrecedente { get => idNodoPrecedente; set => idNodoPrecedente = value; }
        public List<Nodo> NodiSuccessivi { get => nodiSuccessivi; set => nodiSuccessivi = value;}
    }
}