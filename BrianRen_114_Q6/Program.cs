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
            // List<>
        }
        
    }
} catch(Exception e) {}

class Object(int _id, int _objType, int _maType, float _para1, float _para2)
{
    public int id = _id;
    public int objType = _objType;
    public int maType = _maType;
    public float para1 = _para1;
    public float para2 = _para2;
    const float PI = 3.1415926f;

    public Dictionary<string, int> map = new Dictionary<string, int>
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
        switch (objType) 
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
        switch (maType)
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

    // public string GetError()
    // {
    //     
    // }
}
