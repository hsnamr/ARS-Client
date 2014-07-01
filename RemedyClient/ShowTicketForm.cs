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
    public partial class ShowTicketForm : Form
    {
        string TicketNumber, assigned;
        StreamReader reader;
        StreamWriter writer;
        string[] tokens;
        public ShowTicketForm(StreamReader reader, StreamWriter writer, string TicketNumber, string assigned)
        {
            InitializeComponent();
            this.reader = reader;
            this.writer = writer;
            this.TicketNumber = TicketNumber;
            this.assigned = assigned;
            sendRequest();
            readResponse();

        }

        public void sendRequest()
        {
            writer.WriteLine("Ticket Info");
            writer.Flush();
            writer.WriteLine(TicketNumber);
            writer.Flush();
            writer.WriteLine(assigned);
            writer.Flush();
        }

        public void readResponse()
        {
            string input = reader.ReadLine();
            tokens = input.Replace("##", "\t").Split('\t');

            int numberOfTokens = tokens.Length;

            txtTicketNumber.Text = tokens[0];
            txtDate.Text = tokens[1];
            txtName.Text = tokens[2];
            txtJobDone.Text = tokens[3];
            txtStatus.Text = tokens[4];
            txtSequence.Text = tokens[5];
            txtDueDate.Text = tokens[6];
            txtRequirments.Text = tokens[7];

            for (int i = 8; i < numberOfTokens; i++ )
            {
                if(tokens[i]!="")
                    lstAttachments.Items.Add(tokens[i]);
            }
            reader.ReadLine();//read the dot
            reader.ReadLine();//commad has been accepted
        }

        private void lstAttachments_DoubleClick(object sender, EventArgs e)
        {
            DownloadAttachment();
        }

        public void DownloadAttachment()
        {
            try
            {
                writer.WriteLine("Get Attachment");
                writer.Flush();
                FileStream inFile = new FileStream((string)lstAttachments.SelectedItem, FileMode.Create);
                //txtMonitor.Text += tokens[0];
                writer.WriteLine(tokens[0]);
                writer.Flush();
                //txtMonitor.Text += "\r\n" + tokens[2];
                writer.WriteLine(tokens[2]);
                writer.Flush();
                //txtMonitor.Text += "\r\n" + (string)lstAttachments.SelectedItem;
                writer.WriteLine((string)lstAttachments.SelectedItem);
                writer.Flush();
                int fileLength = int.Parse(reader.ReadLine());
                //txtMonitor.Text += "\r\nthe file length is" + fileLength;
                char[] buffer = new char[1024];
                int sofar = 0;
                if (fileLength < buffer.Length)
                {
                    int read = reader.Read(buffer, 0, fileLength);
                    inFile.Write(Encoding.ASCII.GetBytes(buffer), 0, read);
                    sofar += read;
                }
                else
                {
                    while (sofar < fileLength)
                    {
                        int read = reader.Read(buffer, 0, buffer.Length);
                        inFile.Write(Encoding.ASCII.GetBytes(buffer), 0, read);
                        sofar += read;
                    }
                }
                inFile.Close();
                reader.ReadLine();//I have read the OK message
            }

            catch(Exception w)
            {
                lblMessage.Text = w.ToString();
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }
    }
}