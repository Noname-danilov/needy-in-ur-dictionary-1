using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage_Calculator 
{
    public static int CalculateDamage(int amount, float mitigationPercent)
    {
        return Converrt.ToInt32(amount * mitigationPercent);
    }
}
