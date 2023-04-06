namespace SimpleEvent_00.App
{
    public static class EventService2
    {
        public static void Publish(EventPublisher publisher, SubScriberA subScriberA, SubScriberB subScriberB)
        {
            publisher = new();
            subScriberA = new();
            subScriberB = new();

            publisher.MyEvent += subScriberA.CallbackMethod;
            publisher.MyEvent += subScriberB.CallbackMethod;
            publisher.FireEvent();
        }
    }
}