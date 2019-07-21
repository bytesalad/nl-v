using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Startup : MonoBehaviour
{
    private GameManager_TextOutput console;

    [SerializeField] private TextAsset textFile;

    private void Start()
    {
        console = gameObject.GetComponent<GameManager_TextOutput>();
        console.ClearConsole();
        console.OutputToConsole(textFile.text);
    }
}
