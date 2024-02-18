namespace StrutturaAlbero
{
    public partial class Form1 : Form
    {
        Albero alb;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            string valore = textBoxValore.Text;
            int idNodoPadre = Convert.ToInt32(textBoxIdPrecedente.Text);

            if (alb == null)
            {
                alb = new Albero(valore);
            }
            else
            {
                alb.AggiungiNodo(valore, idNodoPadre);
            }

            Visualizza();
        }
        private void buttonRimuovi_Click(object sender, EventArgs e)
        {
            alb.RimuoviNodo(Convert.ToInt32(textBoxIdDaRimuovere.Text));
            Visualizza();
        }

        private void buttonSerialzza_Click(object sender, EventArgs e)
        {
            alb.Serializza();
            listBox1.Items.Clear();
            listBox1.Items.Add("Serialzzato");
        }

        private void buttonDeserializza_Click(object sender, EventArgs e)
        {
            alb = Albero.Deserializza();
            Visualizza();
        }

        public void Visualizza()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(alb.Radice.Valore);
            VisualizzaDaNodo(alb.Radice, 1);
        }

        public void VisualizzaDaNodo(Nodo Nodo1, int Profondita)
        {
            for (int i = 0; i < Nodo1.NodiSuccessivi.Count; i++)
            {
                listBox1.Items.Add(String.Concat(Enumerable.Repeat("  ", Profondita)) + Nodo1.NodiSuccessivi[i].Valore);
                if (Nodo1.NodiSuccessivi[i].NodiSuccessivi.Count != 0)
                {
                    VisualizzaDaNodo(Nodo1.NodiSuccessivi[i], Profondita + 1);
                }
            }
        }
    }
}