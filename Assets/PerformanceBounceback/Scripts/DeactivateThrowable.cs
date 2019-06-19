using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateThrowable : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Throwable") other.gameObject.SetActive(false);
    }
}
