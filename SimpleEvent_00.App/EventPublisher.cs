using System;

namespace SimpleEvent_00.App
{
    public class EventPublisher
    {
        public event MyDelegate MyEvent;

        public void FireEvent()
        {
            MyEvent();
        }
    }
}
