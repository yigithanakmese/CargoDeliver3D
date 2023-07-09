using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inventory : MonoBehaviour
{
    public int boxcount { get; private set; }
    public int moneycount { get; private set; }

    public UnityEvent<Inventory> Onboxcollect;
    public UnityEvent<Inventory> Onboxdeposit;

    public void boxcollect()
    {
        boxcount++;
        Onboxcollect.Invoke(this);
    }
    public void boxdeposit() 
    {
        boxcount--;
        moneycount++;
        Onboxdeposit.Invoke(this);

       
    }

}
