namespace MyPracticeProject
{
    public struct Seq<T>()
    {
        public uint Count = 0;
        public T[] Data = new T[0];

        public void Add(T value)
        {
            T[] temp = new T[Count + 1];
            for (uint i = 0; i < Count; i++)
            {
                temp[i] = Data[i];
            }
            temp[Count] = value;
            Data = temp;
            Count++;
        }

        public void RemoveAt(uint index)
        {
            T[] temp = new T[Count - 1];
            for (uint i = 0, j = 0; i < Count; i++)
            {
                if (i == index) continue;
                temp[j++] = Data[i];
            }

            Data = temp;
            Count--;
        }
    }
}