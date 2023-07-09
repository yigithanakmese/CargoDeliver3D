using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseCollide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Inventory inventory = other.GetComponent<Inventory>();
        if (inventory != null)
        {
            inventory.boxdeposit();
            gameObject.SetActive(false);

        }
    }
}
