using System.ComponentModel;
using System.Diagnostics;

namespace 任宥臣_Q2 {
    public partial class Form1 : Form {
        BindingList<ClassData> classes = new BindingList<ClassData>();
        BindingList<ReverseData> reverseDatas = new BindingList<ReverseData>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = classes;
            dataGridView1.Columns["id"].HeaderText = "教室編號";
            dataGridView1.Columns["name"].HeaderText = "教室名稱";
            dataGridView2.DataSource = reverseDatas;
            dataGridView2.Columns["id"].HeaderText = "預約編號";
            dataGridView2.Columns["cls"].Visible = false;
            dataGridView2.Columns["clsId"].DisplayIndex = 1;
            dataGridView2.Columns["clsName"].DisplayIndex = 2;
            dataGridView2.Columns["clsId"].HeaderText = "教室編號";
            dataGridView2.Columns["clsName"].HeaderText = "教室名稱";
            dataGridView2.Columns["person"].HeaderText = "預約人";
            dataGridView2.Columns["start"].HeaderText = "開始時間";
            dataGridView2.Columns["end"].HeaderText = "結束時間";

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;

            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = classes;

            dtp1.Format = DateTimePickerFormat.Custom;
            dtp1.CustomFormat = "HH:mm";
            dtp1.ShowUpDown = true;
            dtp1.Value = DateTime.Parse("09:00");

            dtp2.Format = DateTimePickerFormat.Custom;
            dtp2.CustomFormat = "HH:mm";
            dtp2.ShowUpDown = true;
            dtp2.Value = DateTime.Parse("10:00");

            textBox1.Text = $"R{1:000}";
            textBox4.Text = $"B{1:000}";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var clsID = textBox1.Text;
            var clsName = textBox2.Text;
            if (string.IsNullOrWhiteSpace(clsName))
            {
                MessageBox.Show("教室名稱不可爲空");
                return;
            }
            else if (classes.Any(x => x.name == clsName))
            {
                MessageBox.Show("教室名稱不可重複");
                return;
            }
            classes.Add(new ClassData(clsID, clsName));
            textBox1.Text = $"R{int.Parse(clsID[1..]) + 1:000}";

        }

        ClassData select;
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("教室名稱不可爲空");
                return;
            }

            if (classes.Any(x => x.name == textBox2.Text))
            {
                MessageBox.Show("教室名稱不可重複");
                return;
            }

            var update = select with { name = textBox2.Text };
            classes[classes.IndexOf(classes.First(x => x.id == update.id))] = update;

            var target = reverseDatas.Where(x => x.cls.id == update.id).ToList();
            foreach (var x in target)
                reverseDatas[reverseDatas.IndexOf(x)] = x with { cls = update };

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var selectItem = dataGridView1.SelectedRows[0];
            select = (ClassData)selectItem.DataBoundItem;
            Debug.WriteLine(select.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (reverseDatas.Any(x => x.cls.id == select.id))
            {
                MessageBox.Show("教室仍有預約 不可刪除");
                return;
            }
            classes.Remove(select);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text) || comboBox1.Text == "")
            {
                MessageBox.Show("不可爲空");
                return;
            }

            

            if (dtp1.Value >= dtp2.Value)
            {
                MessageBox.Show("Start Time Must Before End Time");
                return;
            }

            var conflict = reverseDatas.FirstOrDefault(x=>
                x.cls.id == comboBox1.SelectedValue &&
                TimeOnly.FromDateTime(dtp1.Value) < x.end && x.start < TimeOnly.FromDateTime(dtp2.Value)
            );

            if(conflict != null )
            {
                MessageBox.Show($"衝突 id:{conflict.id}");
                return;
            }

            reverseDatas.Add(new ReverseData(
                textBox4.Text,
                classes.First(x => x.id == comboBox1.SelectedValue),
                textBox5.Text,
                TimeOnly.FromDateTime(dtp1.Value),
                TimeOnly.FromDateTime(dtp2.Value)
                ));
            textBox4.Text = $"B{int.Parse(textBox4.Text[1..]) + 1:000}";

            var sorted = reverseDatas.OrderBy(x => x.cls.id)
                .ThenBy(x => x.start)
                .ThenBy(x => x.id).ToList();
            reverseDatas.Clear(); 
            foreach( var item in sorted) 
                reverseDatas.Add(item);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            dtp1.Value = DateTime.Parse("09:00");
            dtp2.Value = DateTime.Parse("10:00");
        }
        ReverseData reverseSelect;
        private void button5_Click(object sender, EventArgs e)
        {

            if (reverseDatas.Count == 0) return;
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("不可爲空");
                return;
            }
            if (dtp1.Value >= dtp2.Value)
            {
                MessageBox.Show("Start Time Must Before End Time");
                return;
            }

            var conflict = reverseDatas.FirstOrDefault(x =>
               x.cls.id == comboBox1.SelectedValue && x.id != reverseSelect.id &&
               TimeOnly.FromDateTime(dtp1.Value) < x.end && x.start < TimeOnly.FromDateTime(dtp2.Value)
           );

            if (conflict != null)
            {
                MessageBox.Show("衝突");
                return;
            }

            var update = reverseSelect with
            {
                cls = classes.Where(x => x.id == comboBox1.SelectedValue).First(),
                person = textBox5.Text,
                start = TimeOnly.FromDateTime(dtp1.Value),
                end = TimeOnly.FromDateTime(dtp2.Value)
            };
            reverseDatas[reverseDatas.IndexOf(reverseDatas.First(x => x.id == update.id))] = update;

            var sorted = reverseDatas.OrderBy(x => x.cls.id)
                .ThenBy(x => x.start)
                .ThenBy(x => x.id).ToList();
            reverseDatas.Clear();
            foreach (var item in sorted)
                reverseDatas.Add(item);
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0) return;
            var selectItem = dataGridView2.SelectedRows[0];
            reverseSelect = (ReverseData)selectItem.DataBoundItem;
            Debug.WriteLine(select.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reverseDatas.Remove(reverseSelect);
        }
    }

    record ClassData(string id, string name);

    record ReverseData(string id, ClassData cls, string person, TimeOnly start, TimeOnly end)
    {
        public string clsID => cls.id;
        public string clsName => cls.name;
    };
}
