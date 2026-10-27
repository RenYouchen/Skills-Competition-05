using System.Text;
using System.Text.Json;


using System.Text.Json.Nodes;

namespace BrianRen_114_4_Simu_Q3_JSON_Analyzer {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Json File *.json|*.json";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var a = JsonDocument.Parse(File.ReadAllText(ofd.FileName));
                        StringBuilder sb = new StringBuilder();
                        sb.Append("Root" + '\n');
                        PrintChilden(a.RootElement, "", sb);
                        richTextBox1.Text = sb.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Json Format Error");
                    }
                }

            }

        }

        void PrintChilden(JsonElement el, string prefix, StringBuilder sb)
        {
            var item = el.ValueKind == JsonValueKind.Object
                ? el.EnumerateObject().Select(p=> (p.Name, p.Value)).ToList()
                : el.EnumerateArray().Select((v,i) => ($"[{i}]", v)).ToList();

            for(int i = 0; i < item.Count; i++)
            {
                bool isLast = i == item.Count - 1;
                var (label, value) = item[i];
                sb.AppendLine(prefix + (isLast ? "©¸©¤©¤" : "©À©¤©¤") + Describe(label, value));

                if(value.ValueKind is JsonValueKind.Array or JsonValueKind.Object)
                {
                    PrintChilden(value, prefix + (isLast ? "    " : "©¦   "), sb);
                }
            }
        }

        string Describe(string label, JsonElement v) => v.ValueKind switch
        {
            JsonValueKind.String => $"{label}: {v.GetString()} (String)",
            JsonValueKind.Number => $"{label}: {v.GetRawText()} (Number)",
            JsonValueKind.Object => $"{label} {{}}",
            JsonValueKind.Array => $"{label} []",
            JsonValueKind.True or JsonValueKind.False => $"{label} {v.GetRawText()} (Boolean)",
            _ => $"{label}: null (Null)" 
        };
    }
}
