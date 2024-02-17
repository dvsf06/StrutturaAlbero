namespace StrutturaAlbero
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAggiungi = new Button();
            textBoxValore = new TextBox();
            textBoxIdPrecedente = new TextBox();
            listBox1 = new ListBox();
            buttonRimuovi = new Button();
            textBoxIdDaRimuovere = new TextBox();
            SuspendLayout();
            // 
            // buttonAggiungi
            // 
            buttonAggiungi.Location = new Point(12, 70);
            buttonAggiungi.Name = "buttonAggiungi";
            buttonAggiungi.Size = new Size(108, 23);
            buttonAggiungi.TabIndex = 0;
            buttonAggiungi.Text = "Aggiungi Nodo";
            buttonAggiungi.UseVisualStyleBackColor = true;
            buttonAggiungi.Click += buttonAggiungi_Click;
            // 
            // textBoxValore
            // 
            textBoxValore.Location = new Point(12, 12);
            textBoxValore.Name = "textBoxValore";
            textBoxValore.Size = new Size(108, 23);
            textBoxValore.TabIndex = 1;
            // 
            // textBoxIdPrecedente
            // 
            textBoxIdPrecedente.Location = new Point(12, 41);
            textBoxIdPrecedente.Name = "textBoxIdPrecedente";
            textBoxIdPrecedente.Size = new Size(108, 23);
            textBoxIdPrecedente.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(126, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(189, 184);
            listBox1.TabIndex = 3;
            // 
            // buttonRimuovi
            // 
            buttonRimuovi.Location = new Point(12, 128);
            buttonRimuovi.Name = "buttonRimuovi";
            buttonRimuovi.Size = new Size(108, 23);
            buttonRimuovi.TabIndex = 4;
            buttonRimuovi.Text = "Rimuovi Nodo";
            buttonRimuovi.UseVisualStyleBackColor = true;
            buttonRimuovi.Click += buttonRimuovi_Click;
            // 
            // textBoxIdDaRimuovere
            // 
            textBoxIdDaRimuovere.Location = new Point(12, 99);
            textBoxIdDaRimuovere.Name = "textBoxIdDaRimuovere";
            textBoxIdDaRimuovere.Size = new Size(108, 23);
            textBoxIdDaRimuovere.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxIdDaRimuovere);
            Controls.Add(buttonRimuovi);
            Controls.Add(listBox1);
            Controls.Add(textBoxIdPrecedente);
            Controls.Add(textBoxValore);
            Controls.Add(buttonAggiungi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAggiungi;
        private TextBox textBoxValore;
        private TextBox textBoxIdPrecedente;
        private ListBox listBox1;
        private Button buttonRimuovi;
        private TextBox textBoxIdDaRimuovere;
    }
}