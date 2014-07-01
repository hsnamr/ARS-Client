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
    public partial class MailerForm : Form
    {
        StreamReader reader;
        StreamWriter writer;

        public MailerForm(StreamReader reader, StreamWriter writer)
        {
            InitializeComponent();

            this.reader = reader;
            this.writer = writer;

            writer.WriteLine("Member List");
            writer.Flush();

            int membersCount = int.Parse(reader.ReadLine());

            for (int j = 0; j < membersCount; j++)
                cmboList.Items.Add((String)reader.ReadLine());
        }

        private void cmboList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtToList.Text += (String)cmboList.SelectedItem + "; ";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            txtToList.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            writer.WriteLine(txtToList.Text);
            writer.Flush();

            writer.WriteLine(txtMessage.Text);
            writer.Flush();
        }

    }
}