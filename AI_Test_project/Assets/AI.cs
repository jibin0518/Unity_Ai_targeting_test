using System;
using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public enum Type {A,B};
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
        nav.SetDestination(target.position);
    }
}
