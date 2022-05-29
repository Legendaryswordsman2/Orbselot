using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempOrbBrain : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spawner"))
        {
            collision.gameObject.GetComponent<EnemySpawner>().Damage(1);
            Destroy(gameObject);
        }
    }
}
