using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType1_OffenseLogic : MonoBehaviour
{
    [SerializeField] private float instantiationPeriod;
    //the time in seconds between each shot

    [SerializeField] private Transform avatarTrans;

    private float time = 0;
    //counting the time during the game

    private EnemyType1_InstantiateProjectile instantiationScript;

    private bool beginShooting = false;
    //set to true when the enemy bot needs to start shooting the player.

    public void SetBeginShooting(bool value)
    {
        beginShooting = value;
    }

    private void Start()
    {
        instantiationScript = gameObject.GetComponent<EnemyType1_InstantiateProjectile>();
        //get the instantiation script on this game object so that the projectile can be instantiated.
    }

    private void Update()
    {
        if (beginShooting)
        {
            if (time >= instantiationPeriod)
            {
                instantiationScript.RunInstantiate(gameObject.transform.position, avatarTrans.position);
                time = 0;
            }
            else
            {
                time += Time.deltaTime;
            }
        }
    }
}
