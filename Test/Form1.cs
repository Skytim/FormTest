using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
           
        }

        private void Scrape_Click(object sender, System.EventArgs e)
        {
            var data = new Dictionary<string,string>();
            data.Add("1", "1,2,3,4,5,6,7,8,9,10");
            data.Add("2", "1,2,3,4,5,6,7,8,9,10");
            data.Add("3", "1,2,3,4,5,6,7,8,9,10");
            data.Add("4", "1,2,3,4,5,6,7,8,9,10");
            data.Add("5", "1,2,3,4,5,6,7,8,9,10");
            data.Add("6", "1,2,3,4,5,6,7,8,9,10");
            data.Add("7", "1,2,3,4,5,6,7,8,9,10");
            data.Add("8", "1,2,3,4,5,6,7,8,9,10");
            data.Add("9", "1,2,3,4,5,6,7,8,9,10");
            data.Add("10", "1,2,3,4,5,6,7,8,9,10");
            Products.DataSource = DataSourceSpecial.CreateSource(Products, data);
        }
    }
}
