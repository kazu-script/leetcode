using System.Runtime.Versioning;
using Microsoft.VisualBasic;

namespace Solutions.P0300_0399.P0347_TopKFrequentElements;

public static class P0347TopKFrequentElements
{
    public static int[] TopKFrequent(int[] nums, int k) {
        if (nums.Length == k)
        {
            return nums;
        }

        var frequencyCounter = FrequencyCounter(nums);

        var priorityQueue = FrequencyPriorityQueue(frequencyCounter);

        return GetTopKElements(priorityQueue, k);
    }

    private static Dictionary<int, int> FrequencyCounter(int[] nums)
    {
        Dictionary<int, int> counter = [];
        
        foreach (var number in nums)
        {
            if (!counter.TryAdd(number, 1))
            {
                counter[number]++;
            }
        }

        return counter;
    }

    private static PriorityQueue<int, int> FrequencyPriorityQueue(Dictionary<int, int> frequencyCounter)
    {
        PriorityQueue<int, int> priorityQueue = new ();

        foreach (var entry in frequencyCounter)
        {
            // PriorityQueue is a min heap.
            // To put the most frequent elements on top, the frequency must be multiplied by -1 (-entry.Value)
            priorityQueue.Enqueue(entry.Key, -entry.Value);
        }

        return priorityQueue;
    }
    
    private static int[] GetTopKElements(PriorityQueue<int, int> priorityQueue, int k)
    {
        int[] topKElements = new int[k];

        for (var i = 0; i < k; i++)
        {
            topKElements[i] = priorityQueue.Dequeue();
        }

        return topKElements;
    }
}