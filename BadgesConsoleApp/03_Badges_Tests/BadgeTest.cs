using System;
using System.Collections.Generic;
using BadgesConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Badges_Tests
{
    [TestClass]
    public class BadgeTest
    {
        BadgesRepository _badgesRepository = new BadgesRepository();
        private void Seed()
        {
            _badgesRepository.AddBadgeDictionaryEntry(1150, new Badge(1150, "Smith", new List<string>() { "A5", "B7", "B9", "C10" }));
            _badgesRepository.AddBadgeDictionaryEntry(1151, new Badge(1151, "Jefferson", new List<string>() { "A6", "B7", "C10" }));
            _badgesRepository.AddBadgeDictionaryEntry(1152, new Badge(1152, "Johnson", new List<string>() { "A5", "A6", "B7" }));
        }

        //Tests
        [TestMethod]
        public void AddBadgeDictionaryEntryTest()
        {
            Badge badge = new Badge();
            Seed();
            Assert.IsTrue(_badgesRepository.AddBadgeDictionaryEntry(2000, badge));
            Assert.IsFalse(_badgesRepository.AddBadgeDictionaryEntry(1150, badge));
        }
        [TestMethod]
        public void AddDoorOnBadgeListTest()
        {
            Seed();
            bool result = false;
            _badgesRepository.AddDoorOnBadgeList("A6", 1150);
            foreach (string door in _badgesRepository.GetDoorList(1150))
            {
                if (door == "A6")
                {
                    result = true;
                }
            }
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ViewAllBadgeDataTest()
        {
            Seed();
            int result = _badgesRepository.ViewAllBadgeData().Count;
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void GetDoorListTest()
        {
            Seed();
            int result = _badgesRepository.GetDoorList(1150).Count;
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void RemoveDoorOnBadgeTest()
        {
            Seed();
            Assert.IsTrue(_badgesRepository.RemoveDoorOnBadge("A5", 1150));
            Assert.IsFalse(_badgesRepository.RemoveDoorOnBadge("A6", 1150));
        }
        [TestMethod]
        public void DeleteAllDoorsOnBadgeTest()
        {
            Seed();
            Assert.IsTrue(_badgesRepository.DeleteAllDoorsOnBadge(1150));
            Assert.IsFalse(_badgesRepository.DeleteAllDoorsOnBadge(2000));
        }
        [TestMethod]
        public void DeleteBadgeDictionaryEntryTest()
        {
            Seed();
            Assert.IsTrue(_badgesRepository.DeleteBadgeDictionaryEntry(1150));
            Assert.IsFalse(_badgesRepository.DeleteBadgeDictionaryEntry(2000));
        }
    }
}
