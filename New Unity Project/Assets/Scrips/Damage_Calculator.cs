using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;
using System;

public class Damage_Calculator : MonoBehaviour
{
    public static int CalculateDamage(int amount, float mitigationPercent)
    {
        return Convert.ToInt32(amount * mitigationPercent);
        Assert.AreEqual(5, final);
    }
}
