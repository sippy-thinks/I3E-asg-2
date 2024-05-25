using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// base (common) class for all collectibles
/// </summary>
public class CommonCollectibles : MonoBehaviour
{
    /// <summary>
    /// common method for collecting a collectibles
    /// to be overridden by children
    /// </summary>
    public virtual void Collect(GameObject gameObject)
    {
        return;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("your colliding into me mf");
        Collect(collision.gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("fuk off trigga");
        Collect(other.gameObject);
    }
}
