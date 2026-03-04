using System.ComponentModel;
using System.Net.Sockets;
using System.IO;

namespace RemedyClient;

public partial class LoginForm : Form
{
    private readonly NetworkStream? _stream;
    private readonly StreamReader? _reader;
    private readonly StreamWriter? _writer;

    public LoginForm()
    {
        InitializeComponent();
        try
        {
            var client = new TcpClient("localhost", 9090);
            _stream = client.GetStream();
            _reader = new StreamReader(_stream);
            _writer = new StreamWriter(_stream) { AutoFlush = true };
        }
        catch
        {
            lblMessage.Text = "Cannot connect to the server";
        }
    }

    private void btnAuth_Click(object? sender, EventArgs e)
    {
        if (_reader is null || _writer is null)
        {
            lblMessage.Text = "Not connected to the server";
            return;
        }
        try
        {
            lblMessage.Text = _reader.ReadLine() ?? "No response";
            _writer.WriteLine("Auth");
            _writer.WriteLine(txtUserName.Text);
            _writer.WriteLine(txtPassword.Text);

            string? authStatus = _reader.ReadLine();
            lblMessage.Text = authStatus ?? "";

            if (authStatus?.Contains("not", StringComparison.OrdinalIgnoreCase) == true)
                return;

            string? role = _reader.ReadLine();
            lblMessage.Text = role ?? "";

            if (role?.Contains("Leader", StringComparison.OrdinalIgnoreCase) == true)
                new LeaderForm(this, _stream, _reader, _writer).ShowDialog();
            else if (role?.Contains("System", StringComparison.OrdinalIgnoreCase) == true)
                new SystemForm(this, _reader, _writer).ShowDialog();
            else if (role?.Contains("Member", StringComparison.OrdinalIgnoreCase) == true)
                new MemberForm(this, _stream, _reader, _writer).ShowDialog();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message;
        }
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        if (_writer is not null)
        {
            try
            {
                _writer.WriteLine("Quit");
                _writer.Flush();
            }
            catch { /* ignore on close */ }
        }
        base.OnFormClosing(e);
    }
}
