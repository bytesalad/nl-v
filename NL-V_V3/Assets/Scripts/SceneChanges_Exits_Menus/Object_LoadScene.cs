using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Object_LoadScene : MonoBehaviour
{
    [SerializeField] private string sceneName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "AvatarProjectile")
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
