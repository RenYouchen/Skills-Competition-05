using System.Diagnostics;

namespace BrianRen_114_3_Q3_Load_Multi_Text_File {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        string raw = "";
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog odf = new OpenFileDialog())
            {
                odf.Filter = "Text File *.txt:|*.txt";
                odf.Multiselect = true;
                if(odf.ShowDialog() == DialogResult.OK)
                {
                    raw = "";
                    foreach(var i in odf.FileNames)
                    {
                        raw += File.ReadAllText(i);
                    }

                    var g = raw.Split("\r\n", StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Split('、')).SelectMany(x=>x).ToList().GroupBy(x=>x).ToList();
                    var g1 = g.Select(x=>(x.Key, x.ToList().Count))
                        .GroupBy(x=>x.Item2)
                        .OrderByDescending(x=>x.Key)
                        .ToList()
                        .Select(x=>x.Select(y=>y.Item1).ToList())
                        .ToList();
                    textBox5.Text = string.Join('、', g1[^1]);
                    while (g1.Count < 4)
                        g1.Add([]);
                    textBox1.Text = string.Join('、', g1[0]);
                    textBox2.Text = string.Join('、', g1[1]);
                    textBox3.Text = string.Join('、', g1[2]);
                    textBox4.Text = string.Join('、', g1[3]);
                    Debug.WriteLine(raw);
                }
            }
        }
    }
}
