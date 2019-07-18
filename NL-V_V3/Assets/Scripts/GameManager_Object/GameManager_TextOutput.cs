using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager_TextOutput : MonoBehaviour
{
    [SerializeField]
    private Text consoleText;

    [SerializeField] private float timeBetweenCharacters;

    private float time = 0f;

    int stringCount = 0;

    private string outputString;

    public void OutputToConsole(string outputString_)
    {
        outputString = outputString_;
        stringCount = 0;
    }

    public void ClearConsole()
    {
        consoleText.text = "";
    }

    private void Update()
    {
        //This script should add a character of text one after the other to the console. They are to be seperated by a certain time interval in
        //seconds.
        if (stringCount < outputString.Length)
        {
            time += Time.deltaTime;

            if (time >= timeBetweenCharacters)
            {
                consoleText.text += outputString[stringCount];
                stringCount++;
                time = 0;
            }
        }
    }
}
