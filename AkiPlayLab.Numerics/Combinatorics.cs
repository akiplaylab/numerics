namespace AkiPlayLab.Numerics;

public static class Combinatorics
{
    public static long Factorial(int n)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(n);

        if (n == 0 || n == 1) return 1;

        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    public static long Combination(int n, int k)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(n);
        ArgumentOutOfRangeException.ThrowIfNegative(k);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(k, n);

        if (k == 0 || k == n) return 1;

        if (k > n / 2) k = n - k;
        long numerator = 1;
        long denominator = 1;
        for (int i = 0; i < k; i++)
        {
            numerator *= (n - i);
            denominator *= (i + 1);
        }
        return numerator / denominator;
    }

    public static long Permutation(int n, int k)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(n);
        ArgumentOutOfRangeException.ThrowIfNegative(k);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(k, n);

        if (k == 0) return 1;

        long result = 1;
        for (int i = 0; i < k; i++)
        {
            result *= (n - i);
        }
        return result;
    }
}
