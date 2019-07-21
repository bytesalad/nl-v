using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType1_Projectile_Physics : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D thisRigidBody;

    public void Activate(Vector2 unitDirVector)
    {
        thisRigidBody = gameObject.GetComponent<Rigidbody2D>();

        thisRigidBody.velocity = unitDirVector * speed;
    }
}
