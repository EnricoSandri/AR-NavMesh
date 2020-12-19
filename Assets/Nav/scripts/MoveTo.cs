using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{

    public GameObject goal;
    NavMeshAgent agent;


    void Start()
    {
        AgentDestinationSetter();

    }


    private void Update()
    {
        AgentGoalVerifier();
    }
    
    private void AgentDestinationSetter()
    {
        if (goal != null) {return;}

        goal = GameObject.FindGameObjectWithTag("Goal");
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.transform.position;
    }

    private void AgentGoalVerifier()
    {
        if (goal != null){return;} 
        Manager.AgentDestroyer();
    }
}