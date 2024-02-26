// Ignore Spelling: MCM dma

namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCM9000
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCM9000.InterAppMessages;
	using Skyline.DataMiner.Core.DataMinerSystem.Common;
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallBulk;
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
	using Skyline.DataMiner.Core.InterAppCalls.Common.Shared;
	using Skyline.DataMiner.Net;

	/// <summary>
	/// Represents a DataMiner element using the 'TAG Video Systems MCM-9000' connector, that can handle InterApp Messages.
	/// </summary>
	public class MCM9000
	{
		private TimeSpan defaultTimeout = TimeSpan.FromSeconds(60);

		#region Constructors
		/// <summary>
		/// Initialize a new instance of the <see cref="MCM9000"/> class.
		/// </summary>
		/// <param name="connection">The connection interface.</param>
		/// <param name="element">The element in DataMiner.</param>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public MCM9000(IConnection connection, IDmsElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException(nameof(element));
			}

			if (element.Protocol.Name != Constants.ProtocolName)
			{
				throw new ArgumentException($"The element is not running protocol '{Constants.ProtocolName}'", nameof(element));
			}

			Element = element;
			SLNetConnection = connection ?? throw new ArgumentNullException(nameof(connection));
		}

		/// <summary>
		/// Initialize a new instance of the <see cref="MCM9000"/> class.
		/// </summary>
		/// <param name="connection">The connection interface.</param>
		/// <param name="elementName">The name of the element in DataMiner.</param>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public MCM9000(IConnection connection, string elementName)
		{
			if (elementName == null)
			{
				throw new ArgumentNullException(nameof(elementName));
			}

			Element = connection.GetDms().GetElement(elementName);
			if (Element == null)
			{
				throw new ArgumentException($"The element with name '{elementName}', could not be found.", nameof(elementName));
			}

			if (Element.Protocol.Name != Constants.ProtocolName)
			{
				throw new ArgumentException($"The element is not running protocol '{Constants.ProtocolName}'", nameof(elementName));
			}

			SLNetConnection = connection ?? throw new ArgumentNullException(nameof(connection));
		}

		/// <summary>
		/// Initialize a new instance of the <see cref="MCM9000"/> class.
		/// </summary>
		/// <param name="connection">The connection interface.</param>
		/// <param name="elementId">The element id in DataMiner.</param>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public MCM9000(IConnection connection, DmsElementId elementId)
		{
			if (elementId == default)
			{
				throw new ArgumentNullException(nameof(elementId));
			}

			Element = connection.GetDms().GetElement(elementId);
			if (Element == null)
			{
				throw new ArgumentException($"The element with name '{elementId}', could not be found.", nameof(elementId));
			}

			if (Element.Protocol.Name != Constants.ProtocolName)
			{
				throw new ArgumentException($"The element is not running protocol '{Constants.ProtocolName}'", nameof(elementId));
			}

			SLNetConnection = connection ?? throw new ArgumentNullException(nameof(connection));
		}

		/// <summary>
		/// Initialize a new instance of the <see cref="MCM9000"/> class.
		/// </summary>
		/// <param name="connection">The connection interface.</param>
		/// <param name="dmaId">The id of the DataMiner that is hosting the element.</param>
		/// <param name="elementId">The id of the element in DataMiner.</param>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public MCM9000(IConnection connection, int dmaId, int elementId) : this(connection, new DmsElementId(dmaId, elementId))
		{
		}
		#endregion

		/// <inheritdoc/>
		public IConnection SLNetConnection { get; set; }

		/// <inheritdoc/>
		public IDmsElement Element { get; private set; }

		/// <inheritdoc/>
		public void SendMessageNoResponse(params Message[] messages)
		{

			IInterAppCall myCommands = InterAppCallFactory.CreateNew();
			myCommands.ReturnAddress = new ReturnAddress(Element.DmsElementId.AgentId, Element.DmsElementId.ElementId, Constants.InterAppResponsePID);
			myCommands.Messages.AddMessage(messages);
			myCommands.Send(SLNetConnection, Element.DmsElementId.AgentId, Element.DmsElementId.ElementId, Constants.InterAppReceiverPID, Types.KnownTypes);
		}

		/// <inheritdoc/>
		public IEnumerable<Message> SendMessages(Message[] messages, TimeSpan timeout = default)
		{
			var interAppCallTimeout = timeout;
			if (timeout == default)
			{
				interAppCallTimeout = defaultTimeout;
			}

			IInterAppCall myCommands = InterAppCallFactory.CreateNew();
			myCommands.ReturnAddress = new ReturnAddress(Element.DmsElementId.AgentId, Element.DmsElementId.ElementId, Constants.InterAppResponsePID);
			myCommands.Messages.AddMessage(messages);
			return myCommands.Send(SLNetConnection, Element.DmsElementId.AgentId, Element.DmsElementId.ElementId, Constants.InterAppReceiverPID, interAppCallTimeout, Types.KnownTypes);
		}

		/// <inheritdoc/>
		public Message SendSingleResponseMessage(Message message, TimeSpan timeout = default)
		{
			var interAppCallTimeout = timeout;
			if (timeout == default)
			{
				interAppCallTimeout = defaultTimeout;
			}

			IInterAppCall myCommand = InterAppCallFactory.CreateNew();
			myCommand.ReturnAddress = new ReturnAddress(Element.DmsElementId.AgentId, Element.DmsElementId.ElementId, Constants.InterAppResponsePID);
			myCommand.Messages.AddMessage(message);
			return myCommand.Send(SLNetConnection, Element.DmsElementId.AgentId, Element.DmsElementId.ElementId, Constants.InterAppReceiverPID, interAppCallTimeout, Types.KnownTypes).First();
		}
	}
}
