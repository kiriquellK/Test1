namespace Classes
{
    internal class MyStack
    {
        private int _count;
        private int _item;
        private int[] _items;
        

        private int Item
        {
            get
                {
                return _item;
            }
            set             
            {
                _item = value;
            }
        }
        private int Count
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }

        public MyStack()
        { }
        public MyStack(int count)
        {
            _count = count;
        }

        public void Push()
        {
            
        }
    }
}
