using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshot : MonoBehaviour
{
    // Define the key to trigger the screenshot
    public KeyCode screenshotKey = KeyCode.P;

    // Update is called once per frame
    void Update()
    {
        // Check if the specified key is pressed
        if (Input.GetKeyDown(screenshotKey))
        {
            // Call the method to take a screenshot
            TakeScreenshot();
        }
    }

    void TakeScreenshot()
    {
        // Define the file name and path
        string fileName = "Screenshot_" + System.DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
        string filePath = System.IO.Path.Combine(Application.persistentDataPath, fileName);

        // Capture the screenshot and save it
        ScreenCapture.CaptureScreenshot(filePath);

        // Print a message to the console
        Debug.Log("Screenshot saved to: " + filePath);
    }
}
