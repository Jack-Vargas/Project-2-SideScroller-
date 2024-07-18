using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnPoint;
    public float minTimeToSpawn;
    public float maxTimeToSpawn;
    public float randoNum;

    void Start()
    {
        StartCoroutine(SpawnBallCoroutine());
        StartCoroutine(MoveSpawn());
    }

    void Update()
    {
        //Debug.Log(randoNum);
    }

    IEnumerator SpawnBallCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minTimeToSpawn, maxTimeToSpawn));

            Instantiate(ballPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
    IEnumerator MoveSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            Debug.Log("pauf0asuhf");

            float randoNum = (Random.Range(-10f, 10f));
            gameObject.transform.position = new Vector2(randoNum, 2.7f);
        }
    }
}
