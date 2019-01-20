using System;
using MediaBrowser.Model.System;

namespace Emby.Server.Implementations
{
    public class SystemEvents : ISystemEvents
    {
        public event EventHandler Resume;
        public event EventHandler Suspend;
        public event EventHandler SessionLogoff;
        public event EventHandler SystemShutdown;
    }
}
