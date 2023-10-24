using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveUsellesObjects : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Remover"))
        {
            Destroy(this.gameObject);
        }
    }
}
