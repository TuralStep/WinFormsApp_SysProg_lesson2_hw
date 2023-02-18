namespace WinFormsApp_SysProg_lesson2_hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txt_fileSource.Enabled = false;
        }

        string fileSource;

        private void btn_fileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Text Files (*.txt)|*.txt";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                fileSource = choofdlog.FileName;
                txt_fileSource.Text = choofdlog.FileName;     
            }

        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            string pass = txt_password.Text;
            string end = "";

            if (rBtn_encrypt.Checked)
            {
                char xorKey = 'P';

                String outputString = "";

                int len = pass.Length;

                for (int i = 0; i < len; i++)
                {
                    outputString = outputString +
                    char.ToString((char)(pass[i] ^ xorKey));
                }

                Console.WriteLine(outputString);
                end = outputString;
            }

            await File.WriteAllTextAsync(fileSource, end);

        }
    }
}