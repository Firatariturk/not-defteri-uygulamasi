using System;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;


namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        private string dosyaAdi = "notlar.txt";
        private string dosyaYolu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,  "notlar.txt");
        public Form1()
        {
            InitializeComponent();

            LoadNotesFromFile();






        }
        private void LoadNotesFromFile()
        {



            if (!File.Exists(dosyaYolu))
            {

                Directory.CreateDirectory(Path.GetDirectoryName(dosyaYolu));
                using (FileStream fs = File.Create(dosyaYolu)) { }
            }

            string[] lines = File.ReadAllLines("notlar.txt");

            foreach (string line in lines)
            {
                string[] noteParts = line.Split('|');
                string title = noteParts[0];
                
                listBoxNotlar.Items.Add(title);


            }



        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            textBoxBaslik.Text = "";
            richTextBoxNot.Text = "";
        }

        private void listBoxNotlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNotlar.SelectedIndex != -1)
            {

                string[] lines = File.ReadAllLines("notlar.txt");
                if (listBoxNotlar.SelectedIndex >= 0 && listBoxNotlar.SelectedIndex < lines.Length)
                {
                    string selectedNote = lines[listBoxNotlar.SelectedIndex];
                    string[] noteParts = selectedNote.Split('|');


                    textBoxBaslik.Text = noteParts[0];
                    richTextBoxNot.Text = noteParts[1];

                }


            }
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            string title = textBoxBaslik.Text;
            string message = richTextBoxNot.Text;

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(message))
            {

                listBoxNotlar.Items.Add(title);



                using (StreamWriter writer = new StreamWriter("notlar.txt", true))
                {
                    writer.WriteLine(title + "|" + message);
                }


                textBoxBaslik.Text = "";
                richTextBoxNot.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen baþlýk ve mesaj giriniz.");
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (listBoxNotlar.SelectedIndex != -1)
            {



                string[] lines = File.ReadAllLines("notlar.txt");
                lines = lines.Where((line, index) => index != listBoxNotlar.SelectedIndex).ToArray();
                File.WriteAllLines("notlar.txt", lines);
                listBoxNotlar.Items.RemoveAt(listBoxNotlar.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir not seçin.");
            }
        }
    }
}