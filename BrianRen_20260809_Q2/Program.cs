using static System.Console;

Write("輸入：");
List<double> nums = ReadLine().Split(' ').Select(double.Parse).ToList();
int count = 0;

WriteLine($"排序前的資料: {string.Join(' ',nums)}");

// for (int i = 0; i < 4; i++)
// {
//     if (nums[i] > nums[^1])
//     {
//         (nums[i], nums[^1]) = (nums[^1], nums[i]);
//         count++;
//         
//     }WriteLine($"第 {i+1} 次選擇: {string.Join(' ',nums)}");
// }
List<int> sortedNum = new List<int>();
for (int i = 0; i < 4; i++)
{
    // int indexMin = nums.IndexOf(nums.Where(x=>!sortedNum.Contains((int)x)).Min());
    int indexMin = nums.IndexOf(nums[i..].Min());
    sortedNum.Add((int)nums[indexMin]);
    (nums[i], nums[indexMin]) = (nums[indexMin], nums[i]);
    WriteLine($"第 {i+1} 次選擇: {string.Join(' ',nums)}");
    
}

WriteLine($"算數平均數： {nums.Sum()/nums.Count:F6}" +
          $"調和平均數： {nums.Count/ nums.Select(x=>1/x).Sum():F6} " +
          $"幾何平均數：{Math.Pow(nums.Aggregate((acc, next) => acc*next), (double)1/nums.Count):F6}");
var center = nums.Count % 2 == 1 ? nums[nums.Count / 2] : (nums[nums.Count / 2] + nums[nums.Count / 2 + 1]) / 2;
WriteLine($"中位數：{ center }");

