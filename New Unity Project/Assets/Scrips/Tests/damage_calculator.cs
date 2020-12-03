using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class damage_calculator
    {

        [Test]
        public void set_damage_to_half_with_50_percent_mititgationSimplePasses()
        {
            int finalDamage = DamageCalculator.DamageCalculate(10, 0.5f);
            Assert.AreEqual(5, finalDamage);
        }


    }
}

