using pesel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pesel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void buttonOdczytaj_Click(object sender, EventArgs e)
        {
            try
            {
                Pesel pesel = new Pesel(textBoxPesel.Text);

                labelPlec.Text = @"Płeć: " + pesel.Plec;

               
                labelMiesiac.Text = @"Miesiąc urodzenia: " + pesel.Miesiac;

                labelDzien.Text = @"Dzień urodzenia: " + pesel.Dzien;

                labelCyfra.Text = @"Cyfra kontrolna: " + pesel.Cyfra;

                labelRok.Text = @"Rok urodzenia: " + pesel.Rok;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Błąd");
            }
            
        }

        private void textBoxPesel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonOdczytaj.PerformClick();
                
            }
        }
    }
}
