using NUnit.Framework;

namespace TurboCollections.Test
{
    public class TurboListTests {
        [Test]
        public void NewListIsEmpty() {
            var list = new TurboList<int>();
            Assert.Zero(list.Count);
        }

        [Test]
        public void AddingElementsAndCountingListLength() {
            var list = new TurboList<int>();
            list.Add(4);
            list.Add(4);
            list.Add(4);
            Assert.AreEqual(3, list.Count);
        }
        
        [Test]
        public void GetElementFromListAtIndex() {
            var list = new TurboList<int>();
            list.Add(15);
            Assert.AreEqual(15, list.Get(0));
        }    
        
        [Test]
        public void ReplaceElementFromListAtIndex() {
            var list = new TurboList<int>();
            list.Add(42);
            list.Set(0, 13);
            Assert.AreEqual(13, list.Get(0));
        }
        
        [Test]
        public void ClearList() {
            var list = new TurboList<int>();
            list.Add(42);
            list.Clear();
            Assert.Zero(list.Count);
        }
        
        [Test]
        public void RemovesElementAtIndexAndPushesRemainingElementsBack() {
            var list = new TurboList<int>();
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.RemoveAt(1);
            Assert.AreEqual(8, list.Get(2));
        }
    }
}