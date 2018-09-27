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
Programs that use events should use the ```EventHandler``` class instead of an Action delegate.
The ```EventHandler``` class i part of .NET designed to allow subscriberts to be given data about an event.
Eventhandlers is used throughout the .NET framework to manage events.

An ```EventHnalder``` canm deliver data or signal that an event has taken place.

The ```EventHnalder``` delegate refers to a subscriber method that will accept two arguments.
* The first is a reference to the object raising the event
* The second is a reference to an object of type ```EventArgs``` that provides information about the event.

## Create delegates
It is possible to create custom delegates.
It is furthermore possible to create a delegate that refers to a single method in an object.

To declare a delegate type the ```delegate``` keyword is used.

The statement belowcreate a delegate type called ```IntOperation``` that can refer to a method of type integer that accepts two integer parameters.
```
delegate IntOperation(int a, int b)
```
### Delegate vs delegate
The ```delegate``` keyword instruct the compiler to create a delegate type.

The ```Delegate``` is an abstract class that defines the behavior of delegate instances.

When a delegate has been created it will be an instance of the ````Delegate``` instaces.

## Use lambda expressions (anonymous methods)

## Anonymous methods