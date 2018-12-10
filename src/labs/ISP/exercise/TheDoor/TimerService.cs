using System;
using System.Collections.Generic;
using System.Threading;

namespace TheDoor
{
    class TimerService
    {
        private Dictionary<Guid, (Timer timerId, int timeoutId)> _timers = new Dictionary<Guid, (Timer timer, int timeoutId)>();
        public void Register(int timeout, int timeOutId, ITimerClient client)
        {
            var timerId = Guid.NewGuid();
            var timer = new System.Threading.Timer((state) =>
            {
                var timerInfo = _timers[(Guid)state];
                client.Timeout(timerInfo.timeoutId);
                _timers.Remove((Guid)state);

            }, timerId, timeout, System.Threading.Timeout.Infinite);
            _timers.Add(timerId, (timer, timeOutId));
        }
    }

}