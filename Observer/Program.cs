global using Observer;
global using Observer.Interfaces;


Channel channel = new Channel();
IObserver subscriberA = new SubscriberA();
IObserver subscriberB = new SubscriberB();

channel.Attach(subscriberA);
channel.Attach(subscriberB);

channel.Upload("ADD", "Record 1");

channel.Detach(subscriberA);

channel.Upload("ADD", "Record 2");