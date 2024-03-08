# Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCM9000

## About

Connector API (Inter-App Calls/Messages) for DataMiner elements running the 'TAG Video System MCM-9000' connector.

## How to use

The entry point to send and receive InterApp messages is a MCM9000 object. You can create a new MCM9000 object by giving it a IConnection and information about the TAG Video System MCM-9000 element.

The MCM9000 class has 3 methods you can use to send/receive InterApp messages:
```csharp
// Send a message and don't wait for a response
public void SendMessageNoResponse(params Message[] messages)

// Send a bunch of messages and wait for a response
public IEnumerable<Message> SendMessages(Message[] messages, TimeSpan timeout = default)

// Send a single of message and wait for a response
public Message SendSingleResponseMessage(Message message, TimeSpan timeout = default)
```

To get started create a new instance of the MCM9000 class as follows:

#### From Automation
```csharp
var tag = new MCM9000(engine.GetUserConnection(), "TAG Element A");
```

#### From QAction
```csharp
var tag = new MCM9000(protocol.SLNet.RawConnection, "TAG Element A");
```


Now that you have an instance of the MCM9000 class, you can start sending InterApp Messages. Currently 3 types of messages are supported:
- CreateChannel
- EditChannel
- DeleteChannel

When you want to send a message, create a new instance of the message and fill in the information.
##### For example edit the title of channel 5:
```csharp
var tag = new MCM9000(engine.GetUserConnection(), "DUB_DEV_MVWR_DSC_DCA - AMA");
var editmessage = new EditChannel(5)
{
    Data = new ChannelData
    {
        Title = "New Channel Name",
    },
};
var response = tag.SendSingleResponseMessage(editmessage);
```

### Error handling

Every response from the TAG element will contains at least 2 properties "Success" and "Description"
- Success: will indicate if the InterApp message was successfull or not.
- Description: contains a human readable message indicating what happened.

A message can also go into timeout if the element takes too long to response. The 'SendSingleResponseMessage' and 'SendMessages' will throw a TimeoutException if this happens.

## Projects

* For more information about Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCM9000, see [ConnectorAPI.TAGVideoSystems.MCM9000/README.md](ConnectorAPI.TAGVideoSystems.MCM9000/README.md).

### About DataMiner

DataMiner is a transformational platform that provides vendor-independent control and monitoring of devices and services. Out of the box and by design, it addresses key challenges such as security, complexity, multi-cloud, and much more. It has a pronounced open architecture and powerful capabilities enabling users to evolve easily and continuously.

The foundation of DataMiner is its powerful and versatile data acquisition and control layer. With DataMiner, there are no restrictions to what data users can access. Data sources may reside on premises, in the cloud, or in a hybrid setup.

A unique catalog of 7000+ connectors already exists. In addition, you can leverage DataMiner Development Packages to build your own connectors (also known as "protocols" or "drivers").

> **Note**
> See also: [About DataMiner](https://aka.dataminer.services/about-dataminer).

### About Skyline Communications

At Skyline Communications, we deal with world-class solutions that are deployed by leading companies around the globe. Check out [our proven track record](https://aka.dataminer.services/about-skyline) and see how we make our customers' lives easier by empowering them to take their operations to the next level.

<!-- Uncomment below and add more info to provide more information about how to use this package. -->
<!-- ## Getting Started -->
