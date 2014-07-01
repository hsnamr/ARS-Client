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
    public partial class MemberCreationForm : Form
    {
        StreamReader reader;
        StreamWriter writer;

        public MemberCreationForm()
        {
            InitializeComponent();
        }

        public MemberCreationForm(StreamReader reader, StreamWriter writer)
        {
            InitializeComponent();
            this.reader = reader;
            this.writer = writer;
        }

        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            string email = txtMemberEmail.Text;

            if (!(email.Contains("@")))
            {
                lblMessage.Text = "Invalid E-mail Address!!";
                return;
            }
            writer.WriteLine("Create Member");
            writer.Flush();
            writer.WriteLine(txtMemberName.Text);
            writer.Flush();
            writer.WriteLine(txtMemberEmail.Text);
            writer.Flush();
            writer.WriteLine(txtPassword.Text);
            writer.Flush();

            string response = reader.ReadLine();

            lblMessage.Text = response;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            writer.WriteLine("Quit");
            writer.Flush();
            base.OnClosing(e);
        }
    }
}