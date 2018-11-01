using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class item : MonoBehaviour
{
    [SerializeField]private int maxAmountOfItems;
    private int amoutOfItems = 0;
    public int AmoutOfItems
    {
        get
        {
            return amoutOfItems;
        }
        set
        {
            if (amoutOfItems + value > maxAmountOfItems)
            {
                Drop((value + amoutOfItems)-maxAmountOfItems);
                amoutOfItems = maxAmountOfItems;
                print(maxAmountOfItems);
                return;
            }
            amoutOfItems += value;
            print(amoutOfItems);
        }
    }

    public abstract void Use();
    public abstract void Drop(int amount);
}
