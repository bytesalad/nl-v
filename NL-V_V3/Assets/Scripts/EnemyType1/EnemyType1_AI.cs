using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType1_AI : MonoBehaviour
{
    [SerializeField] private Transform avatarTrans;

    [SerializeField] private float rateOfLerp;

    [SerializeField] private float minimumDistance;

    private void Update()
    {
        Vector2 avatarPos = avatarTrans.position;

        Vector2 enemyPos = gameObject.transform.position;

        if ((enemyPos - avatarPos).magnitude >= minimumDistance)
        {
            enemyPos = Vector2.Lerp(enemyPos, avatarPos, rateOfLerp * Time.deltaTime);
        }

        gameObject.transform.position = enemyPos;
    }
}
