using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

public class TestMatematicas
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestMatematicasSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestMatematicasWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
    [Test]
    public void TestSumaDosPositivos()
    {
        int resultado = PrimerTest.Add(2, 3);
        Assert.AreEqual(5, resultado);
    }
    [Test]
        public void TestSumaDosNegativos()
    {
        int resultado = PrimerTest.Add(-2, -3);
        Assert.AreEqual(-5, resultado);
    }
    [Test]
    public void TestRestaDosPositivos()
    {
        int resultado = PrimerTest.Subtract(8, 3);
        Assert.AreEqual(5, resultado);
    }
    [Test]
       public void TestRestaDosNegativos()
    {
        int resultado = PrimerTest.Subtract(-8, -3);
        Assert.AreEqual(-5, resultado);
    }
}
