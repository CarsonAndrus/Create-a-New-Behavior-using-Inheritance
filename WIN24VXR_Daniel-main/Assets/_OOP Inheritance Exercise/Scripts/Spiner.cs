using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Faster enemy that spins towards the target
public class Spiner : EnemyHitTarget
{
    [SerializeField] private Vector3 rotation;
    

    protected override void Update()
    {
        Move();
        this.transform.Rotate(rotation * 1 * Time.deltaTime);

    }



}
