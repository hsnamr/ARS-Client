using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace RemedyClient
{
    public partial class LoginForm : Form
    {

        NetworkStream stream;
        StreamReader reader;
        StreamWriter writer;

        public LoginForm()
        {
            InitializeComponent();
            try
            {
                TcpClient client = new TcpClient("localhost", 9090);

                stream = client.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);
            }
            catch
            {
                lblMessage.Text = "Can not connect to the server";
            }
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = reader.ReadLine();//reading the welcome message

                writer.WriteLine("Auth");
                writer.Flush();
                writer.WriteLine(txtUserName.Text);
                writer.Flush();
                writer.WriteLine(txtPassword.Text);
                writer.Flush();

                string authStatus = reader.ReadLine();//reading the authuntication status
                lblMessage.Text = authStatus;

                if (authStatus.Contains("not"))
                    goto Skip;

                string role = reader.ReadLine();// reading the welcome ROLE message
                lblMessage.Text = role;

                if (role.Contains("Leader"))
                    new LeaderForm(this, stream, reader, writer).ShowDialog();

                if (role.Contains("System"))
                    new SystemForm(this, reader, writer).ShowDialog();

                if (role.Contains("Member"))
                    new MemberForm(this, stream, reader, writer).ShowDialog();
                /*
                string conString = "Driver={Microsoft Access Driver (*.mdb)};DBQ=Remedy.mdb";
                //check http://www.connectionstrings.com/ for accessing other databases/adapters
                OdbcConnection dbConn = new OdbcConnection(conString);
                dbConn.Open();
                string auth = "SELECT * FROM User_Information WHERE Name='"+UserNameTxt.Text+
                    "' AND Password='"+PasswordTxt.Text+"'"; 
                /*string sqlString = "INSERT INTO Student (ID, Name, Major, LecSec, LabSec)" +
                    "VALUES ('" + txtID.Text + "', '" + txtName.Text.ToUpper() + "', '" + 
                 txtMajor.Text.ToUpper() + "','" + txtLec.Text + "','" + txtLab.Text + "')";
                 */
                /*
                OdbcCommand sqlCommand = new OdbcCommand(auth, dbConn);
                sqlCommand.ExecuteNonQuery();
                OdbcDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount - 1; i++)
                        MessagesLbl.Text += reader.GetString(i) + "\t";
                    MessagesLbl.Text += reader.GetString(reader.FieldCount - 1) + "\r\n";
                }
                reader.Close();
                MessagesLbl.Text += "Done you are Autharized" + "\r\n";
                 */

                Skip:
                ;

            }
            catch (Exception ee)
            {
                lblMessage.Text = ee.ToString();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            writer.WriteLine("Quit");
            writer.Flush();
            base.OnClosing(e);
        }
    }
}