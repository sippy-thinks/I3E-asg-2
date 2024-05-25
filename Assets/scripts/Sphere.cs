using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : CommonCollectibles
{
    public override void Collect(GameObject gameObject)
    {
        gameObject.GetComponent<StarterAssets.FirstPersonController>().MoveSpeed += 6.0f;
        Destroy(this);
    }
}
