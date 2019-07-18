using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Startup : MonoBehaviour
{
    private GameManager_TextOutput console;

    private string startupString;

    private void Start()
    {
        startupString = ">> NL-V Startup" + "\n" +
            ">> This program is set to load automatically on first time boot" + "\n" +
            ">> Name: First Run Calibration" + "\n" +
            ">> Neuro-Link - Visual Version 1.0.165" + "\n" +
            ">> Use the mouse_construct and point_click_method() to shoot the data_file.";
        console = gameObject.GetComponent<GameManager_TextOutput>();
        console.ClearConsole();
        console.OutputToConsole(startupString);
    }
}
