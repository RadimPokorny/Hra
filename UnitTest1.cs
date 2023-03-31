using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        
        //true
        [TestMethod]
        public void Name_POSITIVE()
        {
            string name = "Michael";
            Assert.IsTrue(name.Length<=10);

        }
        [TestMethod]
        public void Name_NEGATIVE()
        {
            string name = "longerThanTen";
            Assert.IsTrue(name.Length <= 10);

        }
        [TestMethod]
        public void CharacterInitialized_POSITIVE()
        {
            int numLevel = 1;
            int numX = 0;
            int numY = 0;
            int numXP = 0;
            Assert.IsTrue( 1 == numLevel && 0 == numX && 0 == numY && 0 == numXP);

        }
        [TestMethod]
        public void CharacterInitialized_NEGATIVE()
        {
            int numLevel = 1;
            int numX = 1;
            int numY = 1;
            int numXP = 1;
            Assert.IsTrue(1 == numLevel && 0 == numX && 0 == numY && 0 == numXP);

        }
        
        [TestMethod]
        public void ClassBelongs_POSITIVE()
        {
            string Classes ="Wizard/Berserker/Engineer/Outsider";
            string currentClass = "Wizard";
            Assert.IsTrue(Classes.Contains(currentClass)); 
        }
        [TestMethod]
        public void ClassBelongs_NEGATIVE()
        {
            string Classes = "Wizard/Berserker/Engineer/Outsider";
            string currentClass = "Cleric";
            Assert.IsTrue(Classes.Contains(currentClass));
        }
        [TestMethod]
        public void PlayerInitialized_POSITIVE()
        {
            int numFace = 0;
            int numHair = 0;
            int numHairColor = 0;
            
            Assert.IsTrue(0 == numFace && 0 == numHair && 0 == numHairColor);

        }
        [TestMethod]
        public void PlayerInitialized_NEGATIVE()
        {
            int numFace = 1;
            int numHair = 1;
            int numHairColor = 1;

            Assert.IsTrue(0 == numFace && 0 == numHair && 0 == numHairColor);

        }
        [TestMethod]
        public void XPAdded_POSITIVE()
        {
            int currentXP = 100;
            int newXP = currentXP + 10;
            Assert.AreNotEqual(currentXP, newXP);
        }
        [TestMethod]
        public void XPAdded_NEGATIVE()
        {
            int currentXP = 100;
            int newXP = currentXP;
            Assert.AreNotEqual(currentXP, newXP);
        }
        [TestMethod]
        public void PositionChanged_POSITIVE()
        {
            int currentX = 0;
            int currentY = 0;
            int newX = currentX + 20;
            int newY = currentY - 10;
            Assert.IsFalse(currentX == newX && currentY == newY);
        }
        [TestMethod]
        public void PositionChanged_NEGATIVE()
        {
            int currentX = 0;
            int currentY = 0;
            int newX = currentX;
            int newY = currentY;
            Assert.IsFalse(currentX == newX && currentY == newY);
        }
        [TestMethod]
        public void Job_POSITIVE()
        {
            string jobs = "Enemy;Citizen;Guard;Trader";
            string currentJob = "Guard";
            Assert.IsTrue(jobs.Contains(currentJob));
        }
        [TestMethod]
        public void Job_NEGATIVE()
        {
            string jobs = "Enemy;Citizen;Guard;Trader";
            string currentJob = "Pilgrim";
            Assert.IsTrue(jobs.Contains(currentJob));
        }
        [TestMethod]
        public void LevelUp_POSITIVE()
        {
            int level = 1;
            int currentXP = 100;
            Assert.IsTrue(currentXP >= level * 100);
        }
        [TestMethod]
        public void LevelUp_NEGATIVE()
        {
            int level = 3;
            int currentXP = 100;
            Assert.IsTrue(currentXP >= level * 100);
        }
        [TestMethod]
        public void StrengthInitialized_POSITIVE()
        {
            int strength = 0;
            Assert.IsTrue(strength >= 0);
        }
        [TestMethod]
        public void StrengthInitialized_NEGATIVE()
        {
            int strength = -1;
            Assert.IsTrue(strength >= 0);
        }
        [TestMethod]
        public void IsBoss_POSITIVE()
        {
            int strength = 15;
            Assert.IsTrue(strength > 0);
        }
        [TestMethod]
        public void IsBoss_NEGATIVE()
        {
            int strength = 0;
            Assert.IsTrue(strength > 0);
        }
    }
}
