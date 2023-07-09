using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoxCount : MonoBehaviour
{
    private TextMeshProUGUI boxcountText;

    void Start()
    {
        boxcountText = GetComponent<TextMeshProUGUI>();
    }

    public void updateboxcountText (Inventory inventory)
    {
        boxcountText.text = inventory.boxcount.ToString();

    }
}
