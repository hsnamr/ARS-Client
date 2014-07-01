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
    public partial class JobDoneForm : Form
    {

        StreamReader reader;
        StreamWriter writer;
        string ticketNumber;

        public JobDoneForm()
        {
            InitializeComponent();
        }

        public JobDoneForm(StreamReader reader, StreamWriter writer, string ticketNumber)
        {
            InitializeComponent();
            this.reader = reader;
            this.writer = writer;
            this.ticketNumber = ticketNumber;
        }

        public void sendUpdateInfo()
        {
            writer.WriteLine("Update Status2");
            writer.Flush();

            writer.WriteLine(ticketNumber);
            writer.Flush();

            sendAttachment();

            writer.WriteLine(txtJobDone.Text);
            writer.Flush();

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

        private void sendAttachment()
        {
            writer.WriteLine(lstAttachments.Items.Count);//sending the number of files
            writer.Flush();

            for (int i = 0; i < lstAttachments.Items.Count; i++)
            {
                try
                {
                    string temp = (String)lstAttachments.Items[i];
                    string actualName = temp.Substring(temp.LastIndexOf('\\') + 1);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sendUpdateInfo();
        }
    }
}