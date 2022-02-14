using System;

namespace Task_01
{
    class BTnode<T>
        where T: IComparable
    {
        private T Value { get; }
        private int Count { get; set; }
        public BTnode<T> Left { get; private set; }
        public BTnode<T> Right { get; private set; }
        
        public BTnode(T value, BTnode<T> left=null, BTnode<T> right=null) => (Value, Left, Right, Count) = (value, left, right, 1);
        
        public void InsertValue(T newValue)
        {
            // switch (newValue.CompareTo(Value))
            // {
            //     case > 0:
            //         Right ??= new BTnode<T>(newValue);
            //         Right.InsertValue(newValue);
            //         break;
            //     case < 0:
            //         Left ??= new BTnode<T>(newValue);
            //         Left.InsertValue(newValue);
            //         break;
            // }
            if (newValue.CompareTo(Value) > 0)
            {
                if (Right is null)
                {
                    Right = new BTnode<T>(newValue);
                    return;
                }
                Right.InsertValue(newValue);
            }
            else if (newValue.CompareTo(Value) < 0)
            {
                if (Left is null)
                {
                    Left = new BTnode<T>(newValue);
                    return;
                }
                Left.InsertValue(newValue);
            }

            Count++;
        }

        public override string ToString() => $"{Value} = {Count}";
    }
}