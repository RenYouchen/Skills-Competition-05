//形狀 體積公式 重量公式
// Ball 4/3*PI*para1*para1*para1
// 密度 * 體積
// Cube para1*para1*para1
// Pyramid 1/3*para1*para1*para2
// Cylinder PI*para1*para1*para2

List<Object> objs = new List<Object>();
try
{
    using (StreamReader sr = new StreamReader("../../../2025context_obj.txt"))
    {
        string s;
        while ((s = sr.ReadLine()) != null)
        {
            var sl = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            objs.Add(new Object(int.Parse(sl[0]), sl[1], sl[2], float.Parse(sl[3]),
                float.Parse(sl[4])));
            //parse _objType to int
        }

    }
}
catch (Exception e)
{
    Console.WriteLine(e);
}


Console.WriteLine($"{"ID", 3} {"ObjType", 13} {"matType", 13} {"PARA1",13} {"PARA2",13} {"Volume",13} {"Weight",13} {"ERROR", 13}");
Console.WriteLine(string.Join("\n", objs));

Console.WriteLine($"{"ID", 3} {"ObjType", 13} {"matType", 13} {"PARA1",13} {"PARA2",13} {"Volume",13} {"Weight",13} {"ERROR", 13}");
Console.WriteLine(string.Join("\n", objs.OrderByDescending(x=> Object.map.ContainsKey(x.maType)? Object.map[x.maType] : Object.map["Unknown"])));

class Object(int _id, string _objType, string _maType, float _para1, float _para2)
{
    public int id = _id;
    public string objType = _objType;
    public string maType = _maType;
    public float para1 = _para1;
    public float para2 = _para2;

    public string error =>
        !map.ContainsKey(objType)  ? "Err_object" :
        !map.ContainsKey(maType) ? "Err_material" :
        para1 <= 0 ? "Err_para1" :
            ((objType == "Ball" || objType == "Cube") ? para2 != 0 : para2 <= 0)
                ? "Err_para2"
                : "Normal";
        // para2 <= 0 || (objType == "Ball" || objType == "Cube" && para2 == 0) ? "Err_para2" : "Normal";

    public float Volume
    {
        get
        {
            if (!map.ContainsKey(objType) || error == "Err_para1"|| error == "Err_para2") return 0f;

    switch (map [objType]) 
            {
                case 1:
                    return 4f / 3f * PI * para1 * para1 * para1;
                case 2:
                    return para1 * para1 * para1;
                case 3:
                    return 1f / 3f * para1 * para1 * para2;
                case 4:
                    return PI * para1 * para1 * para2;
                default:
                    return 0f;
            }
        }
    }

    public float Weight
    {
        get
        {
            float density;
            if (!map.ContainsKey(maType) || error == "Err_para1"|| error == "Err_para2") return 0f;
            switch (map[maType])
            {
                case 1:
                    density = 7.87f;
                    break;
                case 2:
                    density = 2.7f;
                    break;
                case 3:
                    density = 11.3f;
                    break;
                default:
                    density = 0f;
                    break;
            }

            return density * Volume;
        }
    }
    const float PI = 3.1415926f;

    static public Dictionary<string, int> map = new Dictionary<string, int>
    {
        {"Ball", 1},
        {"Cube", 2},
        {"Pyramid", 3},
        {"Cylinder", 4},
        {"Iron", 1},
        {"Aluminum", 2},
        {"Lead", 3},
        {"Unknown", -10}
    };
    

    public override string ToString()
    {
        return $"{id, 3} {objType, 13} {maType, 13} {para1,13:F3} {para2,13:F3} {Volume,13:F3} {Weight,13:F3} {error, 13}";
    }
}

// var list = new List<clazz >();
// var b = list.Select(x => new
// {
//     St=x.Students.Where(x=>x.Name=="A").Select(x=>x.Number).ToList()
// }).ToList();
//
// class student()
// {
//     public string Name;
//     public string Number;
// }
//
// class clazz
// {
//     public string name;
//     public List<student> Students;
// }

// var arr = new List<String>() { "1","2" };
// var b = arr.Select(x => Convert.ToInt32(x));

// foreach (var i in objs)
// {
//     Console.WriteLine(i);
// }

// public float GetVolume()
// {
//     switch (map[objType]) 
//     {
//         case 1:
//             return 4 / 3 * PI * para1 * para1;
//         case 2:
//             return para1 * para1 * para1;
//         case 3:
//             return 1 / 3 * para1 * para1 * para2;
//         case 4:
//             return PI * para1 * para1 * para2;
//         default:
//             return 0f;
//     }
// }

// public float GetWeight()
// {
//     float density;
//     switch (map[maType])
//     {
//         case 1:
//             density = 7.87f;
//             break;
//         case 2:
//             density = 2.7f;
//             break;
//         case 3:
//             density = 11.3f;
//             break;
//         default:
//             density = 0f;
//             break;
//     }
//
//     return density * GetVolume();
// }