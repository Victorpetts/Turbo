using System;

namespace TurboCollections {
    public class TurboList<T> {
        private T[] turboList = Array.Empty<T>();
        public int Count => turboList.Length;

        public void Add(T item) {
            var newArray = new T[Count + 1];
            
            for (int i = 0; i < Count; i++) {
                newArray[i] = turboList[i];
            }

            newArray[Count] = item;
            turboList = newArray;
        }

        public T Get(int index) {
            if (index >= turboList.Length || index < 0) throw new Exception("Array index does not exist");
            return turboList[index];
        }

        public void Set(int index, T value) {
            if (index >= turboList.Length || index < 0) throw new Exception("Array index does not exist");
            turboList[index] = value;
        }

        public void Clear() {
            turboList = Array.Empty<T>();
        }

        public void RemoveAt(int index) {
            if (index >= turboList.Length || index < 0) throw new Exception("Array index does not exist");
            
            var newArray = new T[Count - 1];
            
            for (int i = 0; i < index; i++) {
                newArray[i] = turboList[i];
            }

            for (int i = index; i < Count -1 ; i++) {
                newArray[i] = turboList[i + 1];
            }
            
            turboList = newArray;
        }
    }
}