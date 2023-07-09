using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Inventory inventory = other.GetComponent<Inventory>();
        if (inventory != null)
        {
            inventory.boxcollect();
            gameObject.SetActive(false);
        }
    }
}
