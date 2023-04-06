namespace SimpleEvent_00.App
{
    public class EventService
    {
        private readonly EventPublisher _publisher;

        public SubScriberA SubScriberA { get; set; }
        public SubScriberB SubScriberB { get; set; }

        public EventService(EventPublisher publisher, SubScriberA subScriberA, SubScriberB subScriberB)
        {
            _publisher = publisher;
            SubScriberA = subScriberA;
            SubScriberB = subScriberB;
        }

        public void Publish()
        {
            _publisher.MyEvent += SubScriberA.CallbackMethod;
            _publisher.MyEvent += SubScriberB.CallbackMethod;
            _publisher.FireEvent();
        }

    }
}
