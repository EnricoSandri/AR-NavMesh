using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static GameObject[] agentClones;

    // Update is called once per frame
    void Update()
    {
        agentClones = GameObject.FindGameObjectsWithTag("Player");
    }
    
    public static void AgentDestroyer()
    {
        foreach (GameObject agent in agentClones)
        {
            Destroy(agent.gameObject);

        }
    }
}
