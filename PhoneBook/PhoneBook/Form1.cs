using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> phoneBook;

        public Form1()
        {
            InitializeComponent();

            this.phoneBook = new Dictionary<string, string>();
            this.phoneBook.Add("山田一郎","xxx-3456-4343");
            this.phoneBook.Add("山田二郎", "xxx-8823-9434");
            this.phoneBook.Add("山田三郎", "xxx-1693-7364");
            this.phoneBook.Add("山田四郎", "xxx-7763-2117");

            foreach(KeyValuePair<string,string> data in phoneBook)
            {
                this.nameList.Items.Add(data.Key);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NameSelected(object sender, EventArgs e)
        {
            string name = this.nameList.Text;
            this.phoneNumber.Text = this.phoneBook[name];

        }
    }
}
