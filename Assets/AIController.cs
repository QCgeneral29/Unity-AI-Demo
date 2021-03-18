using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    
    public Transform destination;

    NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(destination != null)
        {
            UpdateDestintation();
        }
    }

    private void UpdateDestintation()
    {
        Vector3 targetVector = destination.transform.position;
        navMeshAgent.SetDestination(targetVector);
    }
}
