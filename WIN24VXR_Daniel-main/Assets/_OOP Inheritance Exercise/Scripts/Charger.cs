using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class Charger : EnemyHitTarget
{
    [SerializeField] EnemyHitTarget enemyPrefab;
    [SerializeField] GameObject charger;
    float timeTillCharge = 10;

    IEnumerator ChargeTimer()
    {
        while (timeTillCharge > 0f)
        {
            timeTillCharge--;
            yield return new WaitForSeconds(1);
            Debug.Log(timeTillCharge);
        }
        if (timeTillCharge == 0f)
        {
            //charger.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }



    void Start()
    {
        //charger.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        StartCoroutine(ChargeTimer());

    }
}
