using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryUIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string> userDetails = new Dictionary<string, string>() ;

        private void clear()
        {
            idTextBox.Clear();
            detailsTextBox.Clear();

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            userDetails.Add(idTextBox.Text,detailsTextBox.Text);
            MessageBox.Show("Data Have Been saved :)");
            clear();
            idTextBox.Focus();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (userDetails.ContainsKey(idSearchTextBox.Text))
            {

                MessageBox.Show("id:" + " " + idSearchTextBox.Text +"/n"+""+ userDetails[idSearchTextBox.Text]);
            }

            MessageBox.Show(" Please Inter Velid Id");
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            string massage = string.Empty;

            foreach (KeyValuePair<string,string> details in userDetails)
            {
                massage = massage + details.Key +" "+ details.Value +"/n";
            }
            MessageBox.Show(massage);
        }
    }
}
