using System;

namespace TurboCollections
{
    public class TurboStack<T> {
        public int Count { get; private set; }
        private T[] turboStack = Array.Empty<T>();
        
        public void Push(T item) {
            var newArray = new T[Count + 1];
            
            for (int i = 0; i < Count; i++) {
                newArray[i] = turboStack[i];
            }
            
            newArray[Count++] = item;
            turboStack = newArray;
        }

        public T Peek() {
            return turboStack[Count - 1];
        }

        public T Pop() {
            var lastItem = turboStack[Count - 1];
            turboStack[Count - 1] = default;
            Count--;
            return lastItem;
        }

        public void Clear() {
            turboStack = Array.Empty<T>();
            Count = 0;
        }
    }
}