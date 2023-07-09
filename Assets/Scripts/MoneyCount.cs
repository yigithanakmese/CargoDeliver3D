using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyCount : MonoBehaviour
{
    private TextMeshProUGUI moneycountText;

    void Start()
    {
        moneycountText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdatemoneycountText(Inventory inventory)
    {
        moneycountText.text = inventory.moneycount.ToString();
    }
}
