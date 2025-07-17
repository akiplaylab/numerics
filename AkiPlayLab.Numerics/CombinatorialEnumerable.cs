namespace AkiPlayLab.Numerics;

public static class CombinatorialEnumerable
{
    public static IEnumerable<T[]> Combinations<T>(T[] source, int k)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(k);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(k, source.Length);

        if (k == 0)
        {
            yield return Array.Empty<T>();
            yield break;
        }

        int[] indices = [.. Enumerable.Range(0, k)];
        while (true)
        {
            yield return indices.Select(i => source[i]).ToArray();
            int i;
            for (i = k - 1; i >= 0 && indices[i] == source.Length - k + i; i--) ;
            if (i < 0) break;
            indices[i]++;
            for (int j = i + 1; j < k; j++)
                indices[j] = indices[j - 1] + 1;
        }
    }
}
