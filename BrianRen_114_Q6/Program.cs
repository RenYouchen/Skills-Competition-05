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

foreach (var i in objs)
{
    Console.WriteLine(i);
}

class Object(int _id, string _objType, string _maType, float _para1, float _para2)
{
    public int id = _id;
    public string objType = _objType;
    public string maType = _maType;
    public float para1 = _para1;
    public float para2 = _para2;
    const float PI = 3.1415926f;

    static public Dictionary<string, int> map = new Dictionary<string, int>
    {
        {"Ball", 1},
        {"Cube", 2},
        {"Pyramid", 3},
        {"Cylinder", 4},
        {"Iron", 1},
        {"Aluminum", 2},
        {"Lead", 3}
    };
    
    public float GetVolume()
    {
        switch (map[objType]) 
        {
            case 1:
                return 4 / 3 * PI * para1 * para1;
            case 2:
                return para1 * para1 * para1;
            case 3:
                return 1 / 3 * para1 * para1 * para2;
            case 4:
                return PI * para1 * para1 * para2;
            default:
                return 0f;
        }
    }

    public float GetWeight()
    {
        float density;
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

        return density * GetVolume();
    }

    public override string ToString()
    {
        return
            $"{nameof(id)}: {id}, {nameof(objType)}: {objType}, {nameof(maType)}: {maType}, {nameof(para1)}: {para1}, {nameof(para2)}: {para2}";
    }

    // public string GetError()
    // {
    //     
    // }
}
