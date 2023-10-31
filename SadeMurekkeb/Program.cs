Console.WriteLine(num(11));
bool num (int n)
{
    int result = 0;
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            result++;
            if (result > 1)
            {
                return true;
            }
        }
    }
    return false;
}