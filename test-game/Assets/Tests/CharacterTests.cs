using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CharacterTests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void _New_Character_has_Full_Health()
        {
            // Use the Assert class to test conditions
            Assert.AreEqual(1, character.CurrentHealth() / CharacterTests.MaxHealth());
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator CharacterTestsWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
