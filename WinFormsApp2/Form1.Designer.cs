namespace WinFormsApp2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxBaslik = new TextBox();
            richTextBoxNot = new RichTextBox();
            listBoxNotlar = new ListBox();
            buttonYeni = new Button();
            buttonKaydet = new Button();
            buttonSil = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 34);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Baslik";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(551, 44);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Notlar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 76);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "Not";
            // 
            // textBoxBaslik
            // 
            textBoxBaslik.Location = new Point(154, 26);
            textBoxBaslik.Name = "textBoxBaslik";
            textBoxBaslik.Size = new Size(224, 23);
            textBoxBaslik.TabIndex = 3;
            // 
            // richTextBoxNot
            // 
            richTextBoxNot.Location = new Point(154, 76);
            richTextBoxNot.Name = "richTextBoxNot";
            richTextBoxNot.Size = new Size(330, 259);
            richTextBoxNot.TabIndex = 4;
            richTextBoxNot.Text = "";
            // 
            // listBoxNotlar
            // 
            listBoxNotlar.FormattingEnabled = true;
            listBoxNotlar.ItemHeight = 15;
            listBoxNotlar.Location = new Point(551, 76);
            listBoxNotlar.Name = "listBoxNotlar";
            listBoxNotlar.Size = new Size(187, 259);
            listBoxNotlar.TabIndex = 5;
            listBoxNotlar.SelectedIndexChanged += listBoxNotlar_SelectedIndexChanged;
            // 
            // buttonYeni
            // 
            buttonYeni.Location = new Point(154, 354);
            buttonYeni.Name = "buttonYeni";
            buttonYeni.Size = new Size(75, 23);
            buttonYeni.TabIndex = 6;
            buttonYeni.Text = "Yeni";
            buttonYeni.UseVisualStyleBackColor = true;
            buttonYeni.Click += buttonYeni_Click;
            // 
            // buttonKaydet
            // 
            buttonKaydet.Location = new Point(409, 354);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(75, 23);
            buttonKaydet.TabIndex = 7;
            buttonKaydet.Text = "Kaydet";
            buttonKaydet.UseVisualStyleBackColor = true;
            buttonKaydet.Click += buttonKaydet_Click;
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(551, 354);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(75, 23);
            buttonSil.TabIndex = 8;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSil);
            Controls.Add(buttonKaydet);
            Controls.Add(buttonYeni);
            Controls.Add(listBoxNotlar);
            Controls.Add(richTextBoxNot);
            Controls.Add(textBoxBaslik);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxBaslik;
        private RichTextBox richTextBoxNot;
        private ListBox listBoxNotlar;
        private Button buttonYeni;
        private Button buttonKaydet;
        private Button buttonSil;
    }
}
