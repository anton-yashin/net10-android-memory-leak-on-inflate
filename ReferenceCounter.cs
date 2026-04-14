using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AndroidApp2
{
    internal static class ReferenceCounter
    {
        private static ConditionalWeakTable<CustomView, Tag> _table = new();
        private static Tag _tag = new();

        public static void AddReferenceAndPrint(CustomView view)
        {
            int count;
            lock (_table)
            {
                _table.Add(view, _tag);
                count = _table.Count();
            }
            System.Diagnostics.Debug.WriteLine($"count of custom views {count}");
        }

        public static int Count
        {
            get
            {
                lock (_table)
                    return _table.Count();
            }
        }

        public static void InvokeGC()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private sealed class Tag { }
    }
}
