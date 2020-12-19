using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject agent;
    public GameObject startPoint;

    // Start is called before the first frame update
    void Start()
    {
        SpawnAgentAtStartPoint();
    }

    private void SpawnAgentAtStartPoint()
    {
        startPoint = GameObject.FindGameObjectWithTag("StartPoint");
        
        if (startPoint != null)
        {
            Instantiate(agent, startPoint.transform.position, startPoint.transform.rotation);
        }
    }
}
