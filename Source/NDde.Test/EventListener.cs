using System.Collections.Generic;
using System.Threading;

namespace NDde.Test
{
  internal sealed class EventListener
  {
    private readonly ManualResetEvent _Received = new ManualResetEvent(false);

    public List<DdeEventArgs> Events { get; } = new List<DdeEventArgs>();

    public WaitHandle Received => _Received;

    public void OnEvent(object sender, DdeEventArgs args)
    {
      Events.Add(args);
      _Received.Set();
    }
  } // class
} // namespace