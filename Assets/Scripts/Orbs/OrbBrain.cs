using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public abstract class OrbBrain : MonoBehaviour
{
  public void Init(Transform target)
    {
        GetComponent<AIDestinationSetter>().target = target;
    }
}
