using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashDiskUtility
{
    public static class EventSink
    {
        public delegate void OnError(string message);
        public static event OnError Error;

        public static void InvokeError(string message)
        {
            Error?.Invoke(message);
        }
    }
}
