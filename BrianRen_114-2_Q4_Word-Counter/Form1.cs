using System.Formats.Tar;
using System.Text.RegularExpressions;

namespace BrianRen_114_2_Q4_Word_Counter {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "Innovation drives progress, and progress inspires innovation.  \r\nWhen people share ideas, new possibilities appear.  \r\nEducation builds knowledge, and knowledge builds confidence.  \r\nConfidence drives creativity, and creativity brings progress.  \r\nWhen technology meets creativity, innovation grows faster.  \r\nProgress depends on the courage to keep learning and improving every day.  \r\nTrue innovation begins when creativity and knowledge work together for a better world.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Black;
            var n = int.Parse(textBox1.Text);
            string rawStr = richTextBox1.Text.ToLower();
            var matches = Regex.Matches(rawStr, "[a-z]+");
            var target = matches
                .GroupBy(x => x.Value)
                .Where(g=>g.Count() == n)
                .Select(g=>g.Key)
                .ToList();
            var set = target.ToHashSet();

            foreach(Match match in matches)
            {
                if(set.Contains(match.Value))
                {
                    richTextBox1.Select(match.Index, match.Length);
                    richTextBox1.SelectionColor = Color.Red;
                }
            }
            richTextBox2.Text = string.Join('\n', set);
        }
    }
}
