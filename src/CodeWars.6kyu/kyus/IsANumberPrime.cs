namespace CodeWars._6kyu.kyus;

public class IsANumberPrime
{
    
    public static bool IsPrime(int n)
    {
        var result = false;
        if(n > 1) 
        {
            if(n == 2) return true;
            result = true;
            for (var i = 3; i < (n / 2); i++)
            {
                if(n % i == 0) 
                {
                    result = false;
                }
            }
        }
        return result;
    }
}
