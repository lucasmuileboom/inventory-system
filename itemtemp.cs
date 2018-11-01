using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemtemp : item
{
    public override void Use()
    {
        print("I have been used");
    }

    public override void Drop(int amount)
    {
        print("drop:"+ amount);
        //Destroy(this.gameObject);
    }
}
