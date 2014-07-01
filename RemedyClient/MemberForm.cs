using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace RemedyClient
{
    public partial class MemberForm : Form
    {
        StreamReader reader;
        StreamWriter writer;
        NetworkStream stream;
        String[] tokens;

        public MemberForm()
        {
            InitializeComponent();
        }

        public MemberForm(Form previous, NetworkStream stream, StreamReader reader, StreamWriter writer)
        {
            InitializeComponent();
            this.reader = reader;
            this.writer = writer;
            this.stream = stream;
            previous.Hide();
            lstHeader.Text = "Number/tIssue Date/tStatus/tDue Date";

            string ticketInfo = reader.ReadLine();

            while (!(ticketInfo.Equals(".")))
            {
                lstTickets.Items.Add((String)ticketInfo.Replace("##", "\t"));
                ticketInfo = reader.ReadLine();
            }
        }

        private void lstTickets_DoubleClick(object sender, EventArgs e)
        {
            string title = (string)lstTickets.SelectedItem;
            tokens = title.Split('\t');
            new ShowTicketForm(reader, writer, tokens[0], tokens[2]).ShowDialog();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            writer.WriteLine("Quit");
            writer.Flush();
            base.OnClosing(e);
        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            string title = (string)lstTickets.SelectedItem;
            tokens = title.Split('\t');
            grpCombo.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (radJobDone.Checked)
                new JobDoneForm(reader, writer, tokens[0]);
            else if (radWorkOnProgress.Checked)
            {
                writer.WriteLine("Update Status1");
                writer.Flush();

                writer.WriteLine(tokens[0]);
                writer.Flush();
            }
        }
    }
}