using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObj : MonoBehaviour
{
    public string tagToDestroy = "Enemy";

    // Function to destroy all GameObjects with the specified tag
    public void DestroyObjectsWithTag()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tagToDestroy);

        foreach (GameObject obj in objectsWithTag)
        {
            Destroy(obj);
        }
    }
}
