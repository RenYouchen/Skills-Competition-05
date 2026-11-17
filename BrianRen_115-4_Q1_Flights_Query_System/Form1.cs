using System.Configuration;
using System.Security.Claims;

namespace BrianRen_115_4_Q1_Flights_Query_System {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        List<Flight> flights = new List<Flight>();
        List<string> origins = new List<string>();
        List<string> destinatios = new List<string>();
        List<string> cabins = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            flights = File.ReadAllLines("flights.csv")
                .Skip(1)
                .Select(s => s.Split(','))
                .Select(d => new Flight(d[0], d[1], d[2], d[3], DateTime.Parse(d[4]), DateTime.Parse(d[5]), d[6], int.Parse(d[7]))).ToList();

            comboBox1.DataSource = flights.Select(x => x.Origin).Distinct().ToList();
            comboBox2.DataSource = flights.Select(x => x.Destination).Distinct().ToList();
            comboBox3.DataSource = new[] { "不拘" }.Concat(flights.Select(x => x.Cabin).Distinct().ToList()).ToList();
            comboBox4.DataSource = "總票價 總時間 轉機次數".Split();
            comboBox5.DataSource = "遞增 遞減".Split();

            dataGridView1.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ori = comboBox1.Text, dest = comboBox2.Text, cabin = comboBox3.Text;
            result.Clear();

            if (ori != dest)
                DFS(ori, dest, cabin, new List<Flight>(), new HashSet<string>() { ori });
            var sorted = Sort(result);
            dataGridView1.DataSource = sorted;
            label6.Text = $"共 {sorted.Count} 筆行程";

        }

        List<Itinerary> result = new List<Itinerary>();
        void DFS(string cur, string dest, string cabin, List<Flight> path, HashSet<string> visited)
        {
            if (cur == dest)
            {
                result.Add(rtResult(path));
                return;
            }

            foreach (var v in flights.Where(x => x.Origin == cur))
            {
                if (visited.Contains(v.Destination)) continue;
                if (cabin != "不拘" && v.Cabin != cabin) continue;
                if (path.Count > 0 && v.Departure < path[^1].Arrival) continue;

                path.Add(v);
                visited.Add(v.Destination);
                DFS(v.Destination, dest, cabin, path, visited);
                path.RemoveAt(path.Count - 1);
                visited.Remove(v.Destination);
            }
        }

        List<Itinerary> Sort(List<Itinerary> list)
        {
            Func<Itinerary, int> key = comboBox4.Text switch
            {
                "總時間" => x => x.Minutes,
                "轉機次數" => x => x.Transfers,
                _ => x => x.Price
            };

            var ordered = comboBox5.Text == "遞減" ? list.OrderByDescending(key) : list.OrderBy(key);

            return ordered.ThenBy(x => x.Price)
                .ThenBy(x => x.Minutes)
                .ThenBy(x => x.Transfers)
                .ThenBy(x => x.Route, StringComparer.Ordinal)
                .ThenBy(x => x.Flights, StringComparer.Ordinal)
                .ToList();
        }

        Itinerary rtResult(List<Flight> path) =>
            new(Route: string.Join("->", new[] { path[0].Origin }.Concat(path.Select(x => x.Destination))),
                Flights: string.Join(", ", path.Select(x => $"{x.Airline}/{x.FlightNo}")),
                Class: string.Join(", ", path.Select(x => x.Cabin)),
                Price: path.Sum(x => x.Price),
                Minutes: (int)(path[path.Count - 1].Arrival - path[0].Departure).TotalMinutes,
                Transfers: path.Count - 1
                );

        

        record Flight(string Airline, string FlightNo, string Origin, string Destination, DateTime Departure, DateTime Arrival, string Cabin, int Price);

        record Itinerary(string Route, string Flights, string Class, int Price, int Minutes, int Transfers) {
            public string TimeText => $"{Minutes / 60}小時{Minutes % 60}分";
        };
    }
}
