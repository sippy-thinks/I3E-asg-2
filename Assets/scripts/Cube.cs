using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : CommonCollectibles
{
    public override void Collect(GameObject gameObject)
    {
        gameObject.GetComponent<StarterAssets.FirstPersonController>().JumpHeight += 5.0f;
        Destroy(this);
    }
    
}
