using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObjects_EventSystem_PointBased : MonoBehaviour
{
    [SerializeField] private GameManager_TextOutput textOutput;

    [SerializeField] private TextAsset textFile;

    [SerializeField] private int pointsRemaining;
    //if the avatar makes a direct hit with the game object, it reduces the pointsRemaining by 1 point.
    //when it reaches zero, the game object is destroyed and the textFile.text is output as with the simplified InteractableObjects_EventSystem script

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "AvatarProjectile")
        {
            pointsRemaining--;
            if (pointsRemaining <= 0)
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
}
