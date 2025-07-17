namespace AkiPlayLab.Numerics.Tests;

[TestClass()]
public class CombinatorialEnumerableTests
{
    [TestMethod()]
    public void CombinationsTest()
    {
        int[] source = [1, 2, 3, 4, 5];
        int k = 3;
        int[][] expected =
        [
            [1, 2, 3],
            [1, 2, 4],
            [1, 2, 5],
            [1, 3, 4],
            [1, 3, 5],
            [1, 4, 5],
            [2, 3, 4],
            [2, 3, 5],
            [2, 4, 5],
            [3, 4, 5]
        ];
        var result = CombinatorialEnumerable.Combinations(source, k).ToArray();
        Assert.AreEqual(expected.Length, result.Length);
        for (int i = 0; i < expected.Length; i++)
        {
            CollectionAssert.AreEqual(expected[i], result[i]);
        }
    }
}
