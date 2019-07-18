using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Tracker : MonoBehaviour
{
    [SerializeField]
    private Transform leader;

    [SerializeField]
    private Vector3 offset;

    private void Update()
    {
        gameObject.transform.position = leader.position + offset;
    }
}
