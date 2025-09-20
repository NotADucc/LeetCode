using LeetCode.Solutions.Shared;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace LeetCode.Solutions;
internal class Solution3508 : IRunProgram
{
    public void Run()
    {
        //Router router = new(3);
        //router.AddPacket(1, 4, 90).Print();
        //router.AddPacket(2, 5, 90).Print();
        //router.AddPacket(1, 4, 90).Print();
        //router.AddPacket(3, 5, 95).Print();
        //router.AddPacket(4, 5, 105).Print();
        //router.ForwardPacket().Print();
        //router.AddPacket(5, 2, 110).Print();
        //router.GetCount(5, 100, 110).Print();

        Router router = new(4);
        router.AddPacket(4, 2, 1).Print();
        router.AddPacket(3, 2, 1).Print();
        router.GetCount(2, 1, 1).Print();
    }

    private class Router
    {
        private readonly HashSet<(int source, int destination, int timestamp)> 
            packets = new();
        private readonly Dictionary<int, List<int>> 
            destinations = new();
        private readonly LinkedList<(int source, int destination, int timestamp)> 
            linked_list = new();
        private readonly int limit;
        public Router(int memoryLimit)
        {
            limit = memoryLimit;
        }

        public bool AddPacket(int source, int destination, int timestamp)
        {
            bool added = packets.Add((source, destination, timestamp));

            if (added)
            {
                linked_list.AddLast((source, destination, timestamp));
                if (!destinations.TryAdd(destination, [timestamp]))
                    destinations[destination].Add(timestamp);
            }

            if (linked_list.Count > limit)
            {
                var remove = linked_list.First!.Value;
                linked_list.RemoveFirst();
                packets.Remove(remove);
                destinations[remove.destination].Remove(remove.timestamp);
            }

            return added;
        }

        public int[] ForwardPacket()
        {
            if (linked_list.Count <= 0)
                return [];

            var packet_info = linked_list.First!.Value;
            linked_list.RemoveFirst();
            packets.Remove(packet_info);
            destinations[packet_info.destination].Remove(packet_info.timestamp);

            return [
                packet_info.source,
                packet_info.destination,
                packet_info.timestamp
            ];
        }

        public int GetCount(int destination, int startTime, int endTime)
        {
            if (!destinations.TryGetValue(destination, out var timestamps))
                timestamps ??= [];

            int start_idx = search_left(timestamps, startTime);
            int end_idx = search_right(timestamps, endTime);
            if (start_idx == -1 || end_idx == -1)
                return 0;

            return end_idx - start_idx + 1;
        }

        int search_left(List<int> list, int target)
        {
            int l = 0, r = list.Count - 1, idx = -1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (list[mid] >= target)
                {
                    idx = mid;
                    r = mid - 1;
                }
                else l = mid + 1;
            }
            return idx;
        }
        int search_right(List<int> list, int target)
        {
            int l = 0, r = list.Count - 1, idx = -1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (list[mid] <= target)
                {
                    idx = mid;
                    l = mid + 1;
                }
                else r = mid - 1;
            }
            return idx;
        }
    }
}
