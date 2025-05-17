namespace Dictionary
{
    public class Dictionary<K,V>
    {
        private int Capacity { init; get; } = 5;
        private K[] keys;
        private V[] values;

        public Dictionary()
        {
            keys = new K[Capacity];
            values = new V[Capacity];
        }
        public V  this[K index]
        {

            get
            {

                int hashind = Hash(index);

                if (hashind>=0 && hashind<Capacity )
                    {
                    if(keys[hashind] != null && keys[hashind].Equals(index))
                        return values[hashind];
                    }


                throw new KeyNotFoundException($"Key '{index}' not found.");
            }
            set
            {


                int hashind = Hash(index);
                if (hashind >= 0 && hashind < Capacity)
                {
                    if (keys[hashind] == null || (keys[hashind].Equals(index)))
                    {
                        keys[hashind] = index;
                        values[hashind] = value;
                        return;
                    }
                }


                throw new KeyNotFoundException($"Key '{index}' not found.");
            }

        }
        public void Add(K key,V value)
        {
            int hash = Hash(key);
            Console.WriteLine(hash);
            if(hash>=0 && hash < Capacity && values[hash].Equals(default(V)))
            {

                values[hash] = value;

            }
            

        }
        public bool TryAdd(K key ,V value)

        {
            int hash = Hash(key);
            if (hash > 0 && hash < Capacity && values[hash].Equals(default(V)))
            {

                values[hash] = value;
                return true;

            }
            if (values[hash].Equals(default(V)) == false)
            {
                return false;   
            }
            return false;
        }
        public int Hash(K key)
        {
            int hashCode = key.GetHashCode();
            return Math.Abs(hashCode) % Capacity;
        }
        public void Print()
        {
            for(int i = 0; i < Capacity; i++)
            {
                if (!(Equals(default(K), keys[i])))
                {
                    int hash = Hash(keys[i]);
                    Console.WriteLine($"key:{keys[i]} value:{values[hash]}");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string,int>();
            dict.Add("Edita",20);
            dict.Add("Anna",0);
            dict.Add("Mareta",18);
            dict.Print();

        }
    }
}
