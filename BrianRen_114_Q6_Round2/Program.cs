Console.WriteLine("Hello, World!");

record Data(int ID, string ObjType, string MaType, float Para1, float Para2)
{
    private List<string> objs = ["Ball", "Cube", "Pyramid", "Cylinder"];
    private List<string> mats = ["Lead", "Aluminum", "Iron"];
    private float PI = 3.1415926f;

    public string OBJ => objs.Contains(ObjType) ? ObjType : "Unknown";
    public string MAT => mats.Contains(ObjType) ? MaType : "Unknown";

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
        _ => 0f
    };

    string Error => (OBJ, MAT, Para1, Para2) switch
    {
        ("Unknown", _, _, _) => "Err_object",
        (_, "Unknown", _, _) => "Err_material",
        (_, _, <= 0, _) => "Err_para1",
        (_, _, _, <= 0) or ("Ball" or "Cube", _, _,not 0) => "Err_para2",
        _ => "Normal"
    };

}