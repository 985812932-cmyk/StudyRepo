using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class InteractableObject : MonoBehaviour
{
    public void Onclick(NavMeshAgent playerAgent)
    {
        playerAgent.stoppingDistance = 2f;
        playerAgent.SetDestination(this.transform.position);
        StartCoroutine(WaitForArrival(playerAgent));
    }

    private IEnumerator WaitForArrival(NavMeshAgent playerAgent)
    {
        while (playerAgent.pathPending)
        {
            yield return null;  //暂停等待路径计算完毕
        }
        while (playerAgent.remainingDistance > playerAgent.stoppingDistance)
        {
            yield return null;  //暂停等待玩家到达目的地
        }
        Interact();
    }

    protected virtual void Interact()
    {
        Debug.Log("Interacting with " + this.name);
    }
}
