using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace RemedyClient
{
    public partial class SystemForm : Form
    {
        StreamReader reader;
        StreamWriter writer;

        public SystemForm()
        {
            InitializeComponent();
        }

        public SystemForm(Form previous,StreamReader reader, StreamWriter writer)
        {
            InitializeComponent();
            this.reader = reader;
            this.writer = writer;
            previous.Hide();
        }

        private void LeaderCreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;

                if (!(email.Contains("@")))
                {
                    lblMessage.Text = "Invalid E-mail Address!!";
                    return;
                }

                writer.WriteLine("Create Leader");
                writer.Flush();

                writer.WriteLine(txtLeaderName.Text);
                writer.Flush();

                writer.WriteLine(txtEmail.Text);
                writer.Flush();

                writer.WriteLine(txtPass.Text);
                writer.Flush();


                lblMessage.Text = reader.ReadLine();
            }

            catch
            {
                lblMessage.Text = "An Exception Occured, make sure all fields have proper data";
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            writer.WriteLine("Quit");
            writer.Flush();
            base.OnClosing(e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                writer.WriteLine("Delete Leader");
                writer.Flush();

                writer.WriteLine(txtLeaderName.Text);
                writer.Flush();

                lblMessage.Text = reader.ReadLine();
            }

            catch
            {
                lblMessage.Text = "An Exception Occured, Please provide an existing Leader name";
            }
        }
    }
}