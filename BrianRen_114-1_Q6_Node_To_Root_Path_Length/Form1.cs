/*
0,999
1,0
2,1
3,1
4,3
5,3
6,1
 */

namespace BrianRen_114_1_Q6_Node_To_Root_Path_Length {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var raw = richTextBox1.Text.Split('\n').Select(x=>x.Split(','));

            var parent = new Dictionary<string, string>();
            var order = new List<string>();
            foreach(var d in raw)
            {
                parent[d[0]] = d[1];
                order.Add(d[0]);
            }

            var result = new List<string>();    
            foreach(var node in order)
            {
                int count = 0;
                string cur = node;
                while (parent[cur] != "999")
                {
                    cur = parent[cur];
                    count++;
                }
                result.Add($"{node}-{count}");
            }
            richTextBox2.Text = string.Join("\n", result);
        }

    }
}
