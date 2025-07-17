namespace AkiPlayLab.Numerics.Tests;

[TestClass()]
public class CombinatoricsTests
{
    [TestMethod()]
    public void FactorialTest()
    {
        Assert.AreEqual(1, Combinatorics.Factorial(0));
        Assert.AreEqual(1, Combinatorics.Factorial(1));
        Assert.AreEqual(2, Combinatorics.Factorial(2));
        Assert.AreEqual(6, Combinatorics.Factorial(3));
        Assert.AreEqual(24, Combinatorics.Factorial(4));
        Assert.AreEqual(120, Combinatorics.Factorial(5));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => Combinatorics.Factorial(-1));
    }

    [TestMethod()]
    public void CombinationTest()
    {
        Assert.AreEqual(1, Combinatorics.Combination(0, 0));
        Assert.AreEqual(1, Combinatorics.Combination(5, 0));
        Assert.AreEqual(1, Combinatorics.Combination(5, 5));
        Assert.AreEqual(10, Combinatorics.Combination(5, 2));
        Assert.AreEqual(120, Combinatorics.Combination(10, 3));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => Combinatorics.Combination(-1, 0));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => Combinatorics.Combination(5, -1));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => Combinatorics.Combination(5, 6));
    }

    [TestMethod()]
    public void PermutationTest()
    {
        Assert.AreEqual(1, Combinatorics.Permutation(0, 0));
        Assert.AreEqual(1, Combinatorics.Permutation(5, 0));
        Assert.AreEqual(120, Combinatorics.Permutation(5, 5));
        Assert.AreEqual(20, Combinatorics.Permutation(5, 2));
        Assert.AreEqual(120, Combinatorics.Permutation(6, 3));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => Combinatorics.Permutation(-1, 0));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => Combinatorics.Permutation(5, -1));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => Combinatorics.Permutation(5, 6));
    }
}
