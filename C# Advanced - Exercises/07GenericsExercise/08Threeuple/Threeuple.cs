﻿
namespace _08Threeuple
{
    public class Threeuple<T,V,W>
    {
        public Threeuple(T item1, V item2, W item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        public T Item1 { get; set; }

        public V Item2 { get; set; }

        public W Item3 { get; set; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }
}
