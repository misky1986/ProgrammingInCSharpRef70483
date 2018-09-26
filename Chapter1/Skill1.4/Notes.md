# Skill 1.4 Create and implement events and callbacks
Delegates contains references to multiple methods and call them when needed.
So, you create numbers of methods as you need and attach it to delegates.
At runtime, an event gets fired and delegates dynamically call the function and return the result.

## Evenhandlers
Eventhandlers are used when you want an object to notify another object that something has happend.

An object can be made to *publish* events to which other objects can *subscribe*.

Components that communicate using events are described as *loosly coupled*.

### Delegates and events
As stated above delegates caontains a reference to a particular method in a class.

You can think of a delegate as a "phone number" to a a method in a class.

An event publishers is given a delegate that describes the method in the subscriber.

The publishers can then call that delegate when the given event occurs and the method will run in the subscriber.

### Action delegates
The .NET libraries provide a numbers of pre-defined delegate types.

The simplest Action delegate represents a reference to a method that does not return a result (the method is of type void) and doesn't accept any parameters.

### Event subscribers
Subscribers bind to a publisher by using the ````+=``` operator

```
// Connect the two listner methods
alarm.OnAlarmRaised += AlarmListner1;
alarm.OnAlarmRaised += AlarmListner2;
```

In this example ```OnAlarmRaised``` is a Action delegate and ```AlarmListner1 and 2``` are the methods subscribed.

## Unsubscribing from a delegate
The ```-=``` operator is used to unsubscribe from events.

```
// Connect the two listner methods
alarm.OnAlarmRaised -= AlarmListner1;    
```

## Using events

C# provides an ```event``` construction that allows delegates to be specified as an event.
The keyword ```event``` is added before the definition of the delegate.

The event is defined in the following way ```public event Action OnAlarmRaised = delegate { };```

This makes the event more secure, because no external classes can assign values to the ```OnAlarmRaised``` event.

## Create events with built-in delegate types

## Create delegates

## Use lambda expressions (anonymous methods)

## Anonymous methods