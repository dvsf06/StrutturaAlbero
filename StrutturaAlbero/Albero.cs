using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
            Nodo x = new Nodo(Valore, IdNodoPrecedente);
            Nodo NodoPrecedente = TrovaNodoDaId(IdNodoPrecedente);
            NodoPrecedente.NodiSuccessivi.Add(x);
        }

        public void RimuoviNodo(int IdNodo)
        {
            Nodo daRimuovere = TrovaNodoDaId(IdNodo);
            Nodo precedente = TrovaNodoDaId(daRimuovere.IdNodoPrecedente);
            precedente.NodiSuccessivi.Remove(daRimuovere);
        }

        private Nodo TrovaNodoDaId(int IdNodo)
        {
            Nodo output = null;

            if(radice.IdNodo != IdNodo)
            {
                for (int i = 0; i < radice.NodiSuccessivi.Count; i++)
                {
                    if (radice.NodiSuccessivi[i].IdNodo == IdNodo)
                    {
                        output = radice.NodiSuccessivi[i];
                    }
                    if (output == null)
                    {
                        output = TrovaNodoDaId(IdNodo, radice.NodiSuccessivi[i]);
                        if(output != null)
                        {
                            return output;
                        }
                    }
                    else
                    {
                        return output;
                    }
                }
                return null;
            }
            else
            {
                return radice;
            }
        }

        private Nodo TrovaNodoDaId(int IdNodo, Nodo NodoPartenza)
        {
            Nodo output;

            if (NodoPartenza.IdNodo != IdNodo)
            {
                for (int i = 0; i < NodoPartenza.NodiSuccessivi.Count; i++)
                {
                    if (NodoPartenza.NodiSuccessivi[i].IdNodo == IdNodo)
                    {
                        return NodoPartenza.NodiSuccessivi[i];
                    }
                    else if (NodoPartenza.NodiSuccessivi[i].NodiSuccessivi.Count != 0)
                    {
                        output = TrovaNodoDaId(IdNodo, NodoPartenza.NodiSuccessivi[i]);
                        if (output != null)
                        {
                            return output;
                        }
                    }
                }
                return null;
            }
            else
            {
                return NodoPartenza;
            }
        }

        public void Serializza()
        {
            File.WriteAllText("../../../albero.json", JsonConvert.SerializeObject(this));
        }

        public static Albero Deserializza()
        {
            Albero x = JsonConvert.DeserializeObject<Albero>(File.ReadAllText("../../../albero.json"));
            return x;
        }

        public Nodo Radice { get => radice; set => radice = value; }
    }
}
