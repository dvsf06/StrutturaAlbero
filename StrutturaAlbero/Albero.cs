using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrutturaAlbero
{
    public class Albero
    {
        Nodo radice;

        public Albero(string Valore)
        {
            radice = new Nodo(Valore);
        }

        public void AggiungiNodo(string Valore, int IdNodoPrecedente)
        {
            Nodo x = new Nodo(Valore);
        }
    }
}
