using TwoSum;

int[] nums = { 2,7,11,15 };
int target = 9;

Method method = new Method();
int[] result = method.TwoSum(nums, target);
if (result.Length > 1)
{
    Console.WriteLine($"{result[0]},{result[1]}");
}
    


