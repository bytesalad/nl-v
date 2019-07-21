using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType1_AI : MonoBehaviour
{
    [SerializeField] private Transform avatarTrans;

    [SerializeField] private float rateOfLerp;

    [SerializeField] private float stopDistance;

    [SerializeField] private float shootingDistance;

    private EnemyType1_OffenseLogic offenseLogicScript;

    private void Start()
    {
        offenseLogicScript = gameObject.GetComponent<EnemyType1_OffenseLogic>();
    }

    private void Update()
    {
        Vector2 avatarPos = avatarTrans.position;

        Vector2 enemyPos = gameObject.transform.position;

        if ((enemyPos - avatarPos).magnitude >= stopDistance)
        {
            enemyPos = Vector2.Lerp(enemyPos, avatarPos, rateOfLerp * Time.deltaTime);
        }

        if ((enemyPos - avatarPos).magnitude <= shootingDistance)
        {
            offenseLogicScript.SetBeginShooting(true);
        }

        gameObject.transform.position = enemyPos;
    }
}
