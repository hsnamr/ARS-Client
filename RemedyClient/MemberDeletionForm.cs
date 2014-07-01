using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace RemedyClient
{
    public partial class MemberDeletionForm : Form
    {
        StreamReader reader;
        StreamWriter writer;

        public MemberDeletionForm()
        {
            InitializeComponent();
        }

        public MemberDeletionForm(StreamReader reader, StreamWriter writer)
        {
            InitializeComponent();
            this.reader = reader;
            this.writer = writer;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                writer.WriteLine("Delete Member");
                writer.Flush();

                writer.WriteLine(txtMemberName.Text);
                writer.Flush();
            }

            catch
            {
                lblMessage.Text = "An Exception occured, make sure you provided an existing member name";
            }
        }
    }
}