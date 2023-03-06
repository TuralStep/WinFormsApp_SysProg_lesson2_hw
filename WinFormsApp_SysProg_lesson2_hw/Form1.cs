using System.Text;

namespace WinFormsApp_SysProg_lesson2_hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txt_fileSource.Enabled = false;
            btn_cancel.Enabled = false;
            btn_start.Enabled = false;
            txt_password.Enabled = false;
        }

        string fileSource = "";
        private CancellationTokenSource _cancelTS = new CancellationTokenSource();

        private void btn_fileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt";
            openFile.FilterIndex = 1;
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileSource = openFile.FileName;
                txt_fileSource.Text = openFile.FileName;
                btn_start.Enabled = true;
                txt_password.Enabled = true;
            }

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new();

            if (string.IsNullOrWhiteSpace(fileSource))
            {
                MessageBox.Show("Enter File Path\n");
                return;
            }

            if (!File.Exists(fileSource))
                sb.Append($"File '{fileSource}' was not found\n");

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                sb.Clear();
                return;
            }

            _cancelTS = new CancellationTokenSource();

            if (rBtn_encrypt.Checked)
            {
                if (string.IsNullOrWhiteSpace(txt_password.Text))
                    sb.Append("Enter encryption key\n");

                if (sb.Length > 0)
                {
                    MessageBox.Show(sb.ToString());
                    sb.Clear();
                    return;
                }

                encryptText(_cancelTS.Token);
                btn_cancel.Enabled = true;
            }
            else
            {
                btn_cancel.Enabled = true;
                decryptText(_cancelTS.Token);
            }

        }

        private void encryptText(CancellationToken _cancel)
        {
            progBar.Value = 0;

            ThreadPool.QueueUserWorkItem(o =>
            {
                string pass = txt_password.Text;
                string end = "";

                char xorKey = 'O';

                string outputString = "";

                int len = pass.Length;

                for (int i = 0; i < len; i++)
                {
                    if (_cancel.IsCancellationRequested)
                    {
                        progBar.Value = 0;
                        break;
                    }
                    outputString = outputString +
                    char.ToString((char)(pass[i] ^ xorKey));

                    Thread.Sleep(300 + Random.Shared.Next(50, 300));
                    progBar.Value += 100 / len;
                }
                end = outputString;

                File.WriteAllTextAsync(fileSource, end);
                progBar.Value = 100;

                MessageBox.Show("Completed");
                progBar.Value = 0;

            });

        }

        private void decryptText(CancellationToken _cancel)
        {
            progBar.Value = 0;

            ThreadPool.QueueUserWorkItem(o =>
            {
                string pass = File.ReadAllText(fileSource);
                MessageBox.Show($"{fileSource} - {pass}");

                string end = "";

                char xorKey = 'O';

                string outputString = "";

                int len = pass.Length;

                for (int i = 0; i < len; i++)
                {
                    if (_cancel.IsCancellationRequested)
                    {
                        progBar.Value = 0;
                        break;
                    }
                    outputString = outputString +
                    char.ToString((char)(pass[i] ^ xorKey));

                    Thread.Sleep(300 + Random.Shared.Next(50, 300));
                    progBar.Value += 100 / len;
                }
                end = outputString;

                File.WriteAllTextAsync(fileSource, end);
                progBar.Value = 100;

                MessageBox.Show("Completed");
                progBar.Value = 0;

            });

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            _cancelTS.Cancel();
            btn_cancel.Enabled = false;
        }
    }
}