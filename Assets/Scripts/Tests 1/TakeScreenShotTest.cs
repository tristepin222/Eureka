using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TakeScreenShotTest : MonoBehaviour
{

    [SerializeField] private TakeScreenShot TakeScreenShot;

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    //check the recttransform local scale with a value of 1

    [UnityTest]
    public IEnumerator TakeScreenShotTestSingleCapture()
    {
        TakeScreenShot = (new GameObject("test")).AddComponent<TakeScreenShot>();
       
        TakeScreenShot.takeScreenShot();
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
    [UnityTest]
    public IEnumerator TakeScreenShotTestTwoCaptures()
    {
        TakeScreenShot.takeScreenShot();
        TakeScreenShot.takeScreenShot();
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
    [UnityTest]
    public IEnumerator TakeScreenShotTestThreeCaptures()
    {
        TakeScreenShot.takeScreenShot();
        TakeScreenShot.takeScreenShot();
        TakeScreenShot.takeScreenShot();
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
    [UnityTest]
    public IEnumerator TakeScreenShotTestCaptureWithoutFolder()
    {
        TakeScreenShot = (new GameObject("test")).AddComponent<TakeScreenShot>();
        System.IO.Directory.Delete(Application.persistentDataPath + "/Screenshots", true);
        TakeScreenShot.takeScreenShot();
       
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
