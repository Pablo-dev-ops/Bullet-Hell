using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor;
using UnityEditor.EditorTools;
using UnityEngine;
using UnityEngine.TestTools;

public class MoveTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void MoveTestSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator MoveTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        var objeto = new GameObject();
        objeto.transform.position = Vector3.zero;

        objeto.transform.position = Vector3.right;

        //Esperamos el siguiente frame
        yield return null;

        //Comprobamos la distancia entre la posicion esperada y la actual
        Assert.IsTrue(Vector3.Distance(Vector3.right, objeto.transform.position) < 0.001f, "La distancia entre la posicion esperada y la actual es mayor de 0.1f");
    }
}
