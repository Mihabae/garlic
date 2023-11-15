Console.WriteLine("Введите 2 координаты ");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double sum = 1, sum1 = -1, sum2 = -1, sum3 = -1, x1, m, pr = 1;
sum = (Math.Cos(a) * 4) + (0.3 * a);
sum1 = (Math.Cos(a) * -4);
sum2 = (Math.Cos(b) * 4) + (0.3 * b);
sum3 = ((Math.Cos(b) * -4) * -1);
m = Math.Abs((Math.Sin(a) * -4) + 0.3);
Console.WriteLine($"min = {Math.Round(m, 5)}");
if (sum > 0 && sum1 > 0 || sum < 0 && sum1 < 0)
{

}
if (sum2 > 0 && sum3 > 0 || sum2 < 0 && sum3 < 0)
{
    while (pr > 0.001)
    {
        x1 = ((b * sum) - (a * sum2)) / (sum - sum2);
        pr = (Math.Abs((Math.Cos(x1) * 4) + (0.3 * x1))) / m;
        a = x1;
        sum = (Math.Cos(x1) * 4) + (0.3 * x1);
        Console.WriteLine($"x= {x1}    {sum}   ,точность = {Math.Round(pr, 7)}");
    }
}
Console.WriteLine($"Корень ур-ия по методу хорд = {Math.Round(pr, 7)}");