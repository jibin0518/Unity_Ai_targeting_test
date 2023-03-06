using System;
using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.AI;

public class AI2 : MonoBehaviour
{
    public Type enemytype;
    public Transform target;

    Rigidbody rigid;
    BoxCollider boxcol;
    NavMeshAgent nav;
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        boxcol = GetComponent<BoxCollider>();
        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (nav.enabled)
        {
            nav.SetDestination(target.position);
        }
    }
}
