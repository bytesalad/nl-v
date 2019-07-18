using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObjects_EventSystem : MonoBehaviour
{
    [SerializeField] private GameManager_TextOutput textOutput;

    [SerializeField] private TextAsset textFile;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "AvatarProjectile")
        {
            if (textFile != null)
            {
                textOutput.ClearConsole();
                textOutput.OutputToConsole(textFile.text);
            }
            Destroy(gameObject);
        }
    }
}
