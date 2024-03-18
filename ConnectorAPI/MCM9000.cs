﻿// Ignore Spelling: MCM dma

namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCM9000
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCM9000.InterAppMessages;
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallBulk;
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
	using Skyline.DataMiner.Core.InterAppCalls.Common.Shared;
	using Skyline.DataMiner.Net;

	/// <summary>
	/// Represents a DataMiner element using the 'TAG Video Systems MCM-9000' connector, that can handle InterApp Messages.
	/// </summary>
#pragma warning disable S101 // Types should be named in PascalCase
	public class MCM9000
#pragma warning restore S101 // Types should be named in PascalCase
	{
		private TimeSpan defaultTimeout = TimeSpan.FromSeconds(60);

		#region Constructors
		/// <summary>
		/// Initialize a new instance of the <see cref="MCM9000"/> class.
		/// </summary>
		/// <param name="connection">The connection interface.</param>
		/// <param name="dmaId">The id of the DataMiner that is hosting the element.</param>
		/// <param name="elementId">The id of the element in DataMiner.</param>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public MCM9000(IConnection connection, int dmaId, int elementId)
		{
			if (dmaId == default)
			{
				throw new ArgumentException("Please provide a valid DMA ID.", nameof(dmaId));
			}

			if (elementId == default)
			{
				throw new ArgumentException("Please provide a valid Element ID.", nameof(elementId));
			}

			SLNetConnection = connection ?? throw new ArgumentNullException(nameof(connection));
			AgentID = dmaId;
			ElementID = elementId;
		}
		#endregion

		/// <summary>
		/// The id of the DataMiner that is hosting the element.
		/// </summary>
		public int AgentID { get; }

		/// <summary>
		/// The id of the element in DataMiner.
		/// </summary>
		public int ElementID { get; }

		/// <summary>
		/// The SLNet Connection to use.
		/// </summary>
		public IConnection SLNetConnection { get; set; }

		/// <summary>
		/// Sends the specified messages to the element using InterApp and do not wait for a response.
		/// </summary>
		/// <param name="messages">The messages that need to be send.</param>
		public void SendMessageNoResponse(params Message[] messages)
		{
			IInterAppCall myCommands = InterAppCallFactory.CreateNew();
			myCommands.ReturnAddress = new ReturnAddress(AgentID, ElementID, Constants.InterAppResponsePID);
			myCommands.Messages.AddMessage(messages);
			myCommands.Send(SLNetConnection, AgentID, ElementID, Constants.InterAppReceiverPID, Types.KnownTypes);
		}

		/// <summary>
		/// Sends the specified messages to the element using InterApp and wait for the responses.
		/// </summary>
		/// <param name="messages">The messages that need to be send.</param>
		/// <param name="timeout">The time the method needs to wait for a response.</param>
		/// <returns>The response coming from the device</returns>
		public IEnumerable<Message> SendMessages(Message[] messages, TimeSpan timeout = default)
		{
			var interAppCallTimeout = timeout;
			if (timeout == default)
			{
				interAppCallTimeout = defaultTimeout;
			}

			IInterAppCall myCommands = InterAppCallFactory.CreateNew();
			myCommands.ReturnAddress = new ReturnAddress(AgentID, ElementID, Constants.InterAppResponsePID);
			myCommands.Messages.AddMessage(messages);
			return myCommands.Send(SLNetConnection, AgentID, ElementID, Constants.InterAppReceiverPID, interAppCallTimeout, Types.KnownTypes);
		}

		/// <summary>
		/// Sends the specified message to the element using InterApp and wait for the responses.
		/// </summary>
		/// <param name="message">The message that needs to be send.</param>
		/// <param name="timeout">The time the method needs to wait for a response.</param>
		/// <returns>The response coming from the device</returns>
		public Message SendSingleResponseMessage(Message message, TimeSpan timeout = default)
		{
			var interAppCallTimeout = timeout;
			if (timeout == default)
			{
				interAppCallTimeout = defaultTimeout;
			}

			IInterAppCall myCommand = InterAppCallFactory.CreateNew();
			myCommand.ReturnAddress = new ReturnAddress(AgentID, ElementID, Constants.InterAppResponsePID);
			myCommand.Messages.AddMessage(message);
			return myCommand.Send(SLNetConnection, AgentID, ElementID, Constants.InterAppReceiverPID, interAppCallTimeout, Types.KnownTypes).First();
		}

		/// <summary>
		/// Sends the specified message to the element using InterApp and wait for the responses.
		/// </summary>
		/// <typeparam name="TResult">The type of the result message.</typeparam>
		/// <param name="message">The message that needs to be send.</param>
		/// <param name="timeout">The time the method needs to wait for a response.</param>
		/// <returns>The response coming from the device</returns>
		public TResult SendSingleResponseMessage<TResult>(Message message, TimeSpan timeout = default) where TResult : Message
		{
			return (TResult)SendSingleResponseMessage(message, timeout);
		}
	}
}
