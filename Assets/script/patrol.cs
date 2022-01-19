using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour
{
    
    public Transform[] targets;
    int nextTarget;
    public float stopDistance = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, targets[nextTarget].position) < stopDistance)
        {
            nextTarget = (nextTarget + 1) % targets.Length;
        }

        
    }
}
