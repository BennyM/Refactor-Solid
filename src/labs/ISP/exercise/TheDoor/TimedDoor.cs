namespace TheDoor
{
    class TimedDoor
        : Door
    {
        private Alarm _alarm;
        private TimerService _service;
        private int _timoutId = 1;
        public TimedDoor(TimerService service)
        {
            _alarm = new Alarm();
            _service = service;
        }
        public override void Timeout(int timeoutId)
        {
            if (_timoutId - 1 == timeoutId && this.IsDoorOpen())
            {
                _alarm.Start();
            }
        }


        public override void Lock()
        {
            base.Lock();
        }

        public override void Unlock()
        {
            base.Unlock();
            _service.Register(1000, _timoutId++, this);
        }

    }
}