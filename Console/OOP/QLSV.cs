namespace OOP
{
    class QLSV
    {
        private static QLSV _Instance;
        public static QLSV Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLSV();
                return _Instance;
            }
            private set
            {
                _Instance = value;
            }
        }
        private SV[] list { get; set; }
        private int n { get; set; }

        public QLSV()
        {
            list = null;
            n = 0;
        }
        public override string ToString()
        {
            string s = "";
            foreach (SV i in list)
            {
                s += i.ToString() + "\n";
            }
            return s;
        }
        public void Add(SV s)
        {
            if (n == 0)
            {
                list = new SV[n + 1];
                list[n] = s;
            }
            else
            {
                SV[] temp = new SV[n];
                for (int i = 0; i < n; i++)
                    temp[i] = list[i];
                list = new SV[n + 1];
                for (int i = 0; i < n; i++)
                    list[i] = temp[i];
                list[n] = s;
            }
            n++;
        }
        public int indexOf(SV s)
        {
            int data = -1;
            for (int i = 0; i < n; i++)
            {
                if (list[i] == s)
                {
                    data = i;
                    break;
                }
            }
            return data;
        }
        public void RemoveAt(int index)
        {
            if (n == 1)
            {
                list = null;
            }
            else
            {
                SV[] temp = new SV[n];
                for (int i = 0; i < n; i++)
                    temp[i] = list[i];
                list = new SV[n - 1];
                for (int i = 0; i < n - 1; i++)
                {
                    if (i < index)
                    {
                        list[i] = temp[i];
                    }
                    if (i >= index)
                    {
                        list[i] = temp[i + 1];
                    }
                }
            }
            n--;
        }
        public void Remove(SV s)
        {
            int index = indexOf(s);
            if (index >= 0)
            {
                RemoveAt(index);
            }
        }
        public int GetIndexSVByMSSV(int m)
        {
            int index = -1;
            for (int i = 0; i < n; i++)
            {
                if (list[i]._MSSV == m)
                {
                    index = i;
                }
            }
            return index;
        }
        public void Update(int m)
        {
            int index = GetIndexSVByMSSV(m);
            list[index]._nameSV = "abc";
        }

        public void Insert(int m, SV s)
        {
            int index = indexOf(s);
            if(index == -1 ){

            }else{
                //chen vao vi tri m
            }
        }

    }
}