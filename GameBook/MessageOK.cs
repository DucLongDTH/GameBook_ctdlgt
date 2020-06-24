using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBook
{
    public partial class MessageOK : Form
    {
        public MessageOK()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string Caption
        {
            get => lbCaption.Text; set => lbCaption.Text = value;
        }
        public string Message
        {
            get => lbMessage.Text; set => lbMessage.Text = value;
        }
    }
}
