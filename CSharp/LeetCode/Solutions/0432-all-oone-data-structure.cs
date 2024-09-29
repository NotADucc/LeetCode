using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0432 : IRunProgram
{
    public void Run()
    {

    }

    internal class AllOne
    {
        private Dictionary<string, int> freq = new Dictionary<string, int>();
        private Dictionary<int, List<string>> testing = new Dictionary<int, List<string>>();
        public AllOne() { }

        public void Inc(string key)
        {
            if (!freq.TryAdd(key, 1))
            {
                int count = freq[key];
                freq[key]++;
                testing[count].Remove(key);
                if (testing[count].Count == 0) testing.Remove(count);
                if (!testing.ContainsKey(freq[key])) testing.Add(freq[key], new List<string>());

                testing[freq[key]].Add(key);
            }
            else
            {
                if (!testing.ContainsKey(1)) testing.Add(1, new List<string>());
                testing[1].Add(key);
            }
        }

        public void Dec(string key)
        {
            int count = freq[key];
            testing[count].Remove(key);
            if (testing[count].Count == 0) testing.Remove(count);
            if (count == 1)
            {
                freq.Remove(key);
            }
            else
            {
                freq[key]--;
                if (!testing.ContainsKey(freq[key])) testing.Add(freq[key], new List<string>());
                testing[freq[key]].Add(key);
            }
        }

        public string GetMaxKey()
        {
            string key = "";
            int max = int.MinValue;

            foreach (var kvp in testing)
            {
                if (kvp.Key > max)
                {
                    max = kvp.Key;
                    key = kvp.Value[0];
                }
            }

            return key;
        }

        public string GetMinKey()
        {
            string key = "";
            int min = int.MaxValue;

            foreach (var kvp in testing)
            {
                if (kvp.Key < min)
                {
                    min = kvp.Key;
                    key = kvp.Value[0];
                }
            }

            return key;
        }
    }
}
