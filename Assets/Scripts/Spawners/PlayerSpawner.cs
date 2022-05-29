using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : Spawner
{
    [Space]

    [SerializeField] GameObject blueOrbPrefab;

    [SerializeField] Transform blueOrbSpawnParent;

    [Space]

    [SerializeField] Transform target;
    private void Awake()
    {
        StartCoroutine(SpawnOrb());
    }
    IEnumerator SpawnOrb()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        int xPivot = Random.Range(-2, 3);
        int yPivot = Random.Range(-2, 3);

        Vector3 spawnPosition = new Vector3(transform.position.x + xPivot, transform.position.y + yPivot, 0);

        GameObject newOrb = Instantiate(blueOrbPrefab, spawnPosition, Quaternion.identity, blueOrbSpawnParent);
        newOrb.GetComponent<BlueOrbBrain>().Init(target);

        StartCoroutine(SpawnOrb());
    }

}
