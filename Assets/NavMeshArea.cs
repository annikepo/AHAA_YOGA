
using UnityEngine;
using UnityEngine.AI;

public class MoveAgent : MonoBehaviour
{
    public Transform target; // The point to move towards

    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        if (target != null)
        {
            agent.destination = target.position; // Set the target position
        }
        else
        {
            Debug.LogError("Target not assigned!");
        }
    }
}
