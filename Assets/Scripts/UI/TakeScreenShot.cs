using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeScreenShot : MonoBehaviour
{
   //take a screen shot of the current screen
   public void takeScreenShot()
    {

        StartCoroutine(screenshot());

    }
    //coroutine that waits the end of frame, so all texture is drawn, and the screenshot can be taken, 
    //saving the screen shot under %userprofile%\AppData\LocalLow\DefaultCompany\Eurêka!\Screenshots, if folder doesn't exist, it's created, 
    //screenshot will always be overwritten
    IEnumerator screenshot()
    {
        yield return new WaitForEndOfFrame();

        if (!System.IO.Directory.Exists(Application.persistentDataPath + "/Screenshots"))
        { 
            System.IO.Directory.CreateDirectory(Application.persistentDataPath + "/Screenshots");
        }
        ScreenCapture.CaptureScreenshot(Application.persistentDataPath + "/Screenshots/capture.png");
        

    }
}

