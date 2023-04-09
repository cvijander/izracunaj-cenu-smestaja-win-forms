namespace Cene_smestaja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            double cena = double.Parse(textBox1.Text);
            DateTime dolazak = monthCalendar1.SelectionStart;
            DateTime odlazak = monthCalendar1.SelectionEnd;
            TimeSpan razlika = odlazak - dolazak;
            int brojNocenja = razlika.Days;

            richTextBox1.Text = "Datum dolaska: " + dolazak.ToShortDateString();
            richTextBox1.Text += "\n";
            richTextBox1.Text += "Datum odlaska: " + odlazak.ToShortDateString();
            richTextBox1.Text += "\n";
            richTextBox1.Text += "Broj nocenja: " + brojNocenja;
            richTextBox1.Text += "\n";
            richTextBox1.Text += "Ukupna cena boravka : " + (brojNocenja * cena);
        }
    }
}