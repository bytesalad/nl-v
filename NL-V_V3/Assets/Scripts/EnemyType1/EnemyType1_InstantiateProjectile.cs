using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType1_InstantiateProjectile : MonoBehaviour
{
    [SerializeField] private float offsetMagnitude;

    [SerializeField] private GameObject prefab;

    public void RunInstantiate(Vector2 enemyPosition, Vector2 destinationPosition)
    {
        Vector2 unitDirVector = (destinationPosition - enemyPosition) / (destinationPosition - enemyPosition).magnitude;

        Vector3 instantiatePosition = offsetMagnitude * unitDirVector;

        Instantiate(prefab, gameObject.transform.position + instantiatePosition, Quaternion.identity).gameObject.GetComponent<EnemyType1_Projectile_Physics>().Activate(unitDirVector);
        //tell the object to run it's velocity/movement script.
    }
}
