using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashDiskUtility
{
    public static class EventSink
    {
        public delegate void OnError(string message);
        public delegate void OnWritten(FileInfo info);

        public static event OnError Error;
        public static event OnWritten Written;
         
        public static void InvokeError(string message)
        {
            Error?.Invoke(message);
        }

        internal static void InvokeWritten(FileInfo handle)
        {
            Written?.Invoke(handle);
        }
    }
}
