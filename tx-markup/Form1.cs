using System;
using System.IO;
using System.Windows.Forms;

namespace tx_markup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textControl1_Changed(object sender, EventArgs e)
        {
            UpdateView(); 
        }

        private void UpdateView()
        {
            textControl2.LoadMarkdown(textControl1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textControl1.Text = File.ReadAllText("sample.md");
            textControl2.Zoom(TXTextControl.ZoomOption.WholePage);

            UpdateView();
        }

        private void textControl2_Resize(object sender, EventArgs e)
        {
            textControl2.Zoom(TXTextControl.ZoomOption.WholePage);
        }
    }

   
}
