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
    public partial class LeaderForm : Form
    {
        StreamReader reader;
        StreamWriter writer;
        NetworkStream stream;
        public LeaderForm()
        {
            InitializeComponent();
        }

        public LeaderForm(Form previous, NetworkStream stream, StreamReader reader, StreamWriter writer)
        {
            InitializeComponent();
            this.reader = reader;
            this.writer = writer;
            this.stream = stream;
            previous.Hide();
            lstHeader.Text = "Number/tIssue Date/tStatus/tDue Date";

            string ticketInfo = reader.ReadLine();

            while(!ticketInfo.Equals("."))
            {
                lstTickets.Items.Add((String)ticketInfo.Replace("##","\t"));
                ticketInfo = reader.ReadLine();
            }
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            new MemberCreationForm(reader, writer).ShowDialog();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            new TicketCreationForm(stream, reader, writer).ShowDialog();
        }

        private void lstTickets_DoubleClick(object sender, EventArgs e)
        {
            string title = (string)lstTickets.SelectedItem;
            String[] tokens = title.Split('\t');
            new ShowTicketForm(reader, writer, tokens[0],tokens[2]).ShowDialog();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            writer.WriteLine("Quit");
            writer.Flush();
            base.OnClosing(e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new MemberDeletionForm(reader, writer).ShowDialog();
        }
    }
}