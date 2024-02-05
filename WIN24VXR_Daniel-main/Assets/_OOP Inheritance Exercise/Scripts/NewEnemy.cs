using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is a new Enemy Type that you will create. Inherit from EnemyHitTarget instead of MonoBehaviour and override the Attack, 
/// Move, and/or Destroy methods to fit your design behavior. 
/// Utilize methods and attributes that are already available in the parent class to avoid code repetition and add new ones if needed to fit your design.
/// Remember that to override a method in a child class, in the parent class, it has to contain the modifier public or protected, as well as the modifier virtual. 
/// Similarly, in the child class, it must also contain the modifier protected or public, but instead of virtual, it must contain the modifier override.
/// </summary>
public class NewEnemy : EnemyHitTarget
{
    [SerializeField] EnemyHitTarget enemyPrefab;
    float timeTillCharge = 10;
    bool canwalk = false;
    [SerializeField] GameObject charger;

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
            canwalk = true;
            //charger.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    void Start()
    {
        //charger.GetComponent<Rigidbody>().isKinematic = true;
        StartCoroutine(ChargeTimer());
    }
    


    // Update is called once per frame
    void Update()
    {
        
    }
}
