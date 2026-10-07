namespace SImu_114_2_Q1_School_Path_Dijkstra {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog odf = new OpenFileDialog())
            {
                odf.Filter = "Text files (*.txt)|";
                if (odf.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Text = string.Join('\n', File.ReadAllLines(odf.FileName));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var raw = richTextBox1.Text.Split('\n');
            var temp = raw[0].Split().Select(int.Parse).ToList();
            var N = temp[0];
            var M = temp[1];
            temp = raw[M+1].Split().Select(int.Parse).ToList();
            var start = temp[0]-1;
            var end = temp[1]-1;
            bool[] visited = new bool[N];
            int[] prevNode = Enumerable.Repeat(-1, N).ToArray();
            List<int> dist = Enumerable.Repeat(int.MaxValue, N).ToList();
            List<List<(int, int)>> graph = Enumerable.Repeat(0, N).Select(_ => new List<(int, int)>()).ToList(); // node, weight
            PriorityQueue<int,int> pq = new PriorityQueue<int,int>();
            var data = raw.Skip(1).ToList();
            for (int i = 0; i < M; i++)
            {
                var lineData = data[i].Split().Select(int.Parse).ToList();
                var nodeA = lineData[0]-1;
                var nodeB = lineData[1]-1;
                var weight = lineData[2];
                graph[nodeA].Add((nodeB, weight));
                graph[nodeB].Add((nodeA, weight));
            }

            dist[start] = 0;
            pq.Enqueue(start, 0);

            while(pq.Count > 0)
            {
                int node = pq.Dequeue();
                if (visited[node]) continue;
                visited[node] = true;

                if (node == end) break;

                foreach(var path in graph[node])
                {
                    int v = path.Item1;
                    int weight = path.Item2;

                    if (!visited[v] && dist[node] != int.MaxValue && dist[v] > dist[node] + weight)
                    {
                        dist[v] = dist[node] + weight;
                        prevNode[v] = node;
                        pq.Enqueue(v, dist[v]);
                    }

                }
            }

            if (dist[end] == int.MaxValue)
            {
                textBox1.Text = "Ÿo·¨µ½ß_½Küc";
                richTextBox2.Clear();
                return;
            }

            textBox1.Text = dist[end].ToString();
            int currentNode = end;
            List<int> result = new List<int>();
            while(currentNode!=-1)
            {
                result.Add(currentNode);
                currentNode = prevNode[currentNode];
            }
            result.Reverse();
            richTextBox2.Text = string.Join("->", result.Select(x=>x+1));
            
        }
    }
}
