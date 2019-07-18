using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar_Projectile_Behaviour : MonoBehaviour
{
    [SerializeField]
    private float projectileSpeed;

    public void OnInstantiate(Vector3 unitDirVector)
    {
        Rigidbody2D thisBody = gameObject.GetComponent<Rigidbody2D>();
        Transform thisTrans = gameObject.GetComponent<Transform>();

        thisBody.velocity = unitDirVector * projectileSpeed;
    }
}
