// See https://aka.ms/new-console-template for more information
class Armstrong
{
    public static void Main(String[] args)
    {
        Console.WriteLine("ENter number");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine((IsArmstrong(num)) ? "The given number is Armstrong number" : "The given number is not Armstrong number");
    }
    public static bool IsArmstrong(int num)
    {
        int numberOfDigit = CountDigits(num);
        int temp = num;
        int sum = 0;
        while (temp > 0) {
            sum += Power(temp % 10,numberOfDigit);
            temp /= 10;
        }
        bool check = (sum == num) ? true:false;
        return check;
    }

    public static int CountDigits(int num)
    {
        int count = 0;
        while (num > 0)
        {
            count++;
            num /= 10;

        }
        return count;
    }

    public static int Power(int num, int power) { 
        if(power == 1)
        {
            return num;
        }
        return num * Power(num,power-1);
    }
}
