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
    public partial class TicketCreationForm : Form
    {
        int sequenceLength = 1;
        bool seqSent = false;
        StreamReader reader;
        StreamWriter writer;
        NetworkStream stream;
        bool flag = false;

        public TicketCreationForm()
        {
            InitializeComponent();
            btnTicketCreate.Enabled = false;
        }

        public TicketCreationForm(NetworkStream stream, StreamReader reader, StreamWriter writer)
        {
            InitializeComponent();
            this.reader = reader;
            this.writer = writer;
            this.stream = stream;
            writer.WriteLine("Create Ticket");
            writer.Flush();

            
            btnSeqAdd.Text = "Add Sequence #" + sequenceLength;

            dTP.MinDate = DateTime.Now;
            dTP.Format = DateTimePickerFormat.Short;

            int membersCount = int.Parse(reader.ReadLine());

            for (int j = 0; j < membersCount; j++)
                cmboAssigned.Items.Add((String)reader.ReadLine());
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] files = dlg.FileNames;
                    // display files using list box
                    int i = 0;
                    while (i < files.Length)
                    {
                        lstAttachments.Items.Add(files[i]);
                        i++;
                    }
                }
                catch (FileLoadException)
                {
                    lblMessage.Text = "File Load Exception!, You may not have permissions to load the file..";
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int i = lstAttachments.SelectedIndex;
            lstAttachments.Items.RemoveAt(i);
        }

        private void btnTicketCreate_Click(object sender, EventArgs e)
        {
            
            
            writer.WriteLine(sequenceLength);
            writer.Flush();

            for (int k = 0; k < sequenceLength; )
            {
                if (flag)
                {
                    sendTicket();
                    lblMessage.Text = "Sequence " + k + " sent..";
                    btnSeqAdd.Text = "Add Sequence #" + sequenceLength;
                    k++;
                }
            }
            reader.ReadLine();//read the OK message
        }//do not use it

        private void txtSeqLength_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sequenceLength = int.Parse((string)cmboSeqLength.SelectedItem);
                btnSeqAdd.Text = "" + sequenceLength;
            }
            catch
            {
                lblMessage.Text = "Sequence Length must be a number greater than or equal 1";
            }
        }

        private void sendTicket()
        {

            writer.WriteLine((string)cmboAssigned.SelectedItem);
            writer.Flush();

            sendAttachment();

            writer.WriteLine(txtRequirments.Text);
            writer.Flush();

            writer.WriteLine(dTP.Text);
            writer.Flush();
        }

        private void sendAttachment()
        {
            writer.WriteLine(lstAttachments.Items.Count);//sending the number of files
            writer.Flush();

            for (int i = 0; i < lstAttachments.Items.Count; i++)
            {
                try
                {
                    string temp = (String)lstAttachments.Items[i];
                    string actualName = temp.Substring(temp.LastIndexOf('\\')+1);
                    FileStream inFile = new FileStream((String)lstAttachments.Items[i], FileMode.Open, FileAccess.Read);
                    writer.WriteLine(actualName);//sending the filename
                    writer.Flush();
                    writer.WriteLine(inFile.Length);//sending the file length
                    writer.Flush();
                    byte[] buffer2 = new byte[1024];
                    int tillNow = 0;
                    while (tillNow < inFile.Length)
                    {
                        int read = inFile.Read(buffer2, 0, buffer2.Length);
                        stream.Write(buffer2, 0, read);
                        tillNow += read;
                    }
                    MessageBox.Show("I have finished sending");
                    inFile.Close();
                }
                catch (FileNotFoundException)
                {
                    lblMessage.Text = "Sorry, File not found";
                }
                catch (FieldAccessException)
                {
                    lblMessage.Text = "Sorry, Can't access file";
                }
                catch
                {
                    lblMessage.Text = "Some exception occured!";
                }
            }
        }

        private void btnSeqAdd_Click(object sender, EventArgs e)
        {
            if (!seqSent)
            {
                sequenceLength = int.Parse((string)cmboSeqLength.SelectedItem);
                writer.WriteLine(sequenceLength);
                writer.Flush();
                cmboSeqLength.Enabled = false;
                seqSent = true;
            }
            writer.WriteLine((string)cmboAssigned.SelectedItem);//send the assigned
            writer.Flush();

            sendAttachment();
            
            writer.WriteLine(txtRequirments.Text);//sending the requirements
            writer.Flush();

            writer.WriteLine(dTP.Text);//sending the due date
            writer.Flush();
            btnSeqAdd.Text = "Send Seq #: " + --sequenceLength;
            if (sequenceLength == 0)
            {
                reader.ReadLine();//read the OK message
                this.Close();
            }
            flag = true;
        }

        private void cmboSeqLength_MouseClick(object sender, MouseEventArgs e)
        {
            btnSeqAdd.Text = "Add Sequence # " + (String)cmboSeqLength.SelectedItem;
        }
    }
}