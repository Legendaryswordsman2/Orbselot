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
        GameObject newOrb = Instantiate(blueOrbPrefab, transform.position, Quaternion.identity, blueOrbSpawnParent);
        newOrb.GetComponent<BlueOrbBrain>().Init(target);

        StartCoroutine(SpawnOrb());
    }

}
