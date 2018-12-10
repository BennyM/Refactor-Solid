namespace TheDoor
{
    class Door
        : IDoor, ITimerClient
    {
        private bool _isOpen;

        public virtual void Lock()
        {
            _isOpen = false;
        }

        public virtual void Unlock()
        {
            _isOpen = true;
        }

        public virtual bool IsDoorOpen()
        {
            return _isOpen;
        }

        public virtual void Timeout(int timeoutId)
        {

        }
    }
}