using System;
using System.Collections.Generic;
using System.Linq;

namespace Grandomizer
{
    /// <summary>
    /// Call to create <b>Generate</b> session.
    /// </summary>
    public class Generate
    {
        /// <summary>
        /// <b>Generated</b> numbers stored in this list.
        /// </summary>
        public readonly List<Int64> Generated = new List<Int64>();
        /// <summary>
        /// Call to start <b>generate</b> numbers with interval.
        /// </summary>
        /// <param name="From">From</param>
        /// <param name="To">To</param>
        public void Generating(Int64 From, Int64 To)
        {
            for (Int64 i = From; i < To + 1; i++)
                Generated.Add(i);
        }
    }

    /// <summary>
    /// Call to create <b>Shuffle</b> session.
    /// </summary>
    public class Shuffle
    {
        /// <summary>
        /// <b>Shuffled</b> numbers stored in this list.
        /// </summary>
        public readonly List<object> Shuffled = new List<object>();
        /// <summary>
        /// Call to start <b>shuffle</b> numbers with interval.
        /// </summary>
        /// <param name="nums">Number(s) object array</param>
        public void Shuffling(object[] nums)
        {
            Random r = new Random();
            List<object> shuffled = nums.OrderBy(x => r.Next()).ToList();
            Shuffled.AddRange(shuffled);
        }
    }
}
