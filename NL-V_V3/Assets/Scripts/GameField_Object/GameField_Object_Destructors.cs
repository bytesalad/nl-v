using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameField_Object_Destructors : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "AvatarProjectile")
        {
            Destroy(collision.gameObject);
        }
    }
}
