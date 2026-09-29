namespace BrianRen_109_Q2_Image_Label {
    internal static class Program {
        static void Main()
        {
            var input = File.ReadAllLines("../../../LabelData.txt").Select(x=>x.Split(' '));
            Console.WriteLine("開始繪製圖框！");
            foreach(var s in input)
            {
                string filePath = s[0];
                int count = int.Parse(s[1]);
                var img = Image.FromFile($"../../../{filePath}");
                var g = Graphics.FromImage(img);
                int i = 2;
                while ((count--) > 0) 
                {
                    int x = int.Parse(s[i++]);
                    int y = int.Parse(s[i++]);
                    int w = int.Parse(s[i++]) - x;
                    int h = int.Parse(s[i++]) - y;
                    g.DrawRectangle(Pens.Red, x, y, w, h);
                }
                img.Save($"../../../imageOUT/{filePath}");
                Console.WriteLine($"在  ./{filePath} 圖檔中加框，以相同檔名存入imageOUT中");
            }
            Console.ReadKey();
        }
    }
}