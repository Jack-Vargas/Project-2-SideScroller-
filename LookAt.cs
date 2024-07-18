using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] string playerTag = "Player";
    [SerializeField] Transform towerTransform;
    [SerializeField] float lookDistance;
    [SerializeField] float transitionTime;


    // Update is called once per frame
    void Update()
    {
        GameObject playerTransform = GameObject.FindWithTag(playerTag);

        float distanceToPlayer = Vector3.Distance(playerTransform.transform.position, towerTransform.position);

        if (distanceToPlayer <= lookDistance)
        {
            FacePlayer();
        }
        else
        {
            ResetTowerRotation();
        }

    }

    void FacePlayer()
    {
        GameObject playerTransform = GameObject.FindWithTag(playerTag);
        Vector3 directionToPlayer = playerTransform.transform.position - towerTransform.position;
        Quaternion lookRotation = Quaternion.LookRotation(directionToPlayer);
        towerTransform.rotation = Quaternion.Slerp(towerTransform.rotation, lookRotation, Time.deltaTime * transitionTime);

    }

    private void ResetTowerRotation()
    {
        Quaternion lookRotation = Quaternion.identity;
        towerTransform.rotation = Quaternion.Slerp(towerTransform.rotation, lookRotation, Time.deltaTime * transitionTime);
    }
}
