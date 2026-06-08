List<Data> datas = new List<Data>();
using(StreamReader sr = new StreamReader("..\\..\\..\\2025context_obj.txt"))
{
    string line;
    while((line = sr.ReadLine()) != null)
    {
        var d = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        datas.Add(
            new Data(
                int.Parse(d[0]),
                d[1],
                d[2],
                float.Parse(d[3]),
                float.Parse(d[4])
            )
        );
    }
}

void Print()
{
    var lens = datas[0].ToString().Length;
    var halfLen = (lens-"Display Data".Length)/2;
    Console.WriteLine($"{new string('*', halfLen)}Display Data{new string('*', halfLen)}*");
    foreach (var i in datas)
    {
        Console.WriteLine(i);    
    }
    Console.WriteLine(new string('*',lens));
}

Console.WriteLine("排序前：");
Print();
Console.WriteLine("排序後：");
List<string> sorts = ["Lead", "Aluminum", "Iron", "Unknown"];
datas = sorts.Join(
    datas,
    m=> m,
    d => d.MAT,
    (m,d) => d
).ToList();
Print();
record Data(int ID, string ObjType, string MaType, float Para1, float Para2)
{
    private List<string> objs = ["Ball", "Cube", "Pyramid", "Cylinder"];
    private List<string> mats = ["Lead", "Aluminum", "Iron"];
    private float PI = 3.1415926f;

    public string OBJ => objs.Contains(ObjType) ? ObjType : "Unknown";
    public string MAT => mats.Contains(MaType) ? MaType : "Unknown";

    public float Volume => Error is "Err_object" or "Err_para1" or "Err_para2" ? 0f : OBJ switch
    {
        "Ball" => 4f/3f*PI*Para1*Para1*Para1,
        "Cube" => Para1*Para1*Para1,
        "Pyramid" => 1f/3f*Para1*Para1*Para2,
        "Cylinder" => PI*Para1*Para1*Para2
    };
    public float Weight => MAT switch
    {
        "Lead" => 11.3f*Volume,
        "Aluminum" => 2.7f*Volume,
        "Iron" => 7.87f*Volume,
        _ => 0f,
    };

    string Error => (OBJ, MAT, Para1, Para2) switch
    {
        ("Unknown", _, _, _) => "Err_object",
        (_, "Unknown", _, _) => "Err_material",
        (_, _, <= 0, _) => "Err_para1",
        (not ("Ball" or "Cube"), _, _, <= 0) or ("Ball" or "Cube", _, _,not 0) => "Err_para2",
        _ => "Normal"
    };

    public override string ToString()
    {
        return $"{ID, 3} {OBJ, 13} {MAT, 13} {Para1, 13:F3} {Para2, 13:F3} {Volume, 13:F3} {Weight, 13:F3} {Error, 13}";
    }
}