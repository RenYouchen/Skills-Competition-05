using System.Text.Json;

namespace BrianRen_112_3_Q6_Account_Manage_System {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        string userData = Path.Combine(Application.StartupPath, "user.json");
        string uploadPath = "";
        List<Account> accounts = new List<Account>();
        Account currentAccount = null;

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("登出成功");
            SwitchPage(login);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            uploadPath = "";
            SwitchPage(login);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (new[] { textBox1, textBox2, textBox3 }.Any(x => string.IsNullOrWhiteSpace(x.Text)) || string.IsNullOrWhiteSpace(uploadPath))
            {
                MessageBox.Show("注冊失敗");
                return;
            }
            if (accounts.Any(x => x.account == textBox2.Text))
            {
                MessageBox.Show("注冊失敗");
                return;
            }

            var acc = new Account(textBox1.Text, textBox2.Text, textBox3.Text, uploadPath);
            accounts.Add(acc);
            Save();
            MessageBox.Show("注冊成功");
            SwitchPage(login);

        }


        void SwitchPage(Panel page)
        {
            signup.Visible = page == signup;
            login.Visible = page == login;
            account.Visible = page == account;
        }
        void Save() => File.WriteAllText(userData, JsonSerializer.Serialize(accounts));

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    uploadPath = ofd.FileName;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Clear(); textBox5.Clear();
            SwitchPage(signup);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var acc = accounts.FirstOrDefault(x => x.account == textBox4.Text && x.password == textBox5.Text, null);
            if (acc != null)
            {
                MessageBox.Show("登入成功");
                textBox4.Clear(); textBox5.Clear();
                currentAccount = acc;
                SwitchPage(account);
                pictureBox1.Image = Image.FromFile(acc.uploadPath);
                label6.Text = label6.Text.Substring(0,3) + acc.nick; //nick
                label8.Text = label8.Text.Substring(0,3) + acc.account; //account
                return;
            }
            MessageBox.Show("登入失敗");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists(userData))
            {
                accounts = JsonSerializer.Deserialize<List<Account>>(File.ReadAllText(userData));
            }
            SwitchPage(login);
        }

        record Account(string nick, string account, string password, string uploadPath);
    }
}
