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
        public void sets_damage_to_half_with_50_percent_mitigation()
        {
            int finalDamage = DamageCalculator.CalculateDamege(10, 0.5f);
        }

    }
}
