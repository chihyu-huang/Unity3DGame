using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miss : MonoBehaviour
{
    public GameObject objectToDisable;


    void OnCollisionEnter(Collision collision)
    {
        // Debug.Log(objectToDisable.name);

            objectToDisable.SetActive(false);
        // }
    }
}
