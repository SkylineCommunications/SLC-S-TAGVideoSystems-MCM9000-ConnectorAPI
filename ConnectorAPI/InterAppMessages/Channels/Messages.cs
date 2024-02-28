// Ignore Spelling: MCM App

namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCM9000.InterAppMessages.Channels
{
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	/// <summary>
	/// Inter-App Message allowing to add new channels.
	/// </summary>
	public class CreateChannel : Message
	{
		/// <summary>
		/// The object that hold the channel data.
		/// </summary>
		public ChannelData Data { get; set; }
	}

	/// <summary>
	/// InterApp result message from the <see cref="CreateChannel"/> Message.
	/// </summary>
	public class CreateChannelResult : Message
	{
		/// <summary>
		/// Indicates if the InterApp Call was successful or not
		/// </summary>
		public bool Success { get; set; }

		/// <summary>
		/// A human readable text representing the response of the InterApp Call.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The InterApp Message that triggered this response.
		/// </summary>
		public CreateChannel Request { get; set; }
	}

	/// <summary>
	/// Inter-App Message allowing to edit an existing channel.
	/// </summary>
	public class EditChannel : Message
	{
		/// <summary>
		/// Instantiates a new instance of the <see cref="EditChannel"/> class.
		/// </summary>
		/// <param name="channelId">The ID of the to be edited channel.</param>
		public EditChannel(int channelId)
		{
			this.ChannelId = channelId;
		}

		/// <summary>
		/// The object that hold the channel data.
		/// </summary>
		public ChannelData Data { get; set; }

		/// <summary>
		/// The ID of the to be edited channel.
		/// </summary>
		public int ChannelId { get; set; }
	}

	/// <summary>
	/// InterApp result message from the <see cref="EditChannel"/> Message.
	/// </summary>
	public class EditChannelResult : Message
	{
		/// <summary>
		/// Indicates if the InterApp Call was successful or not
		/// </summary>
		public bool Success { get; set; }

		/// <summary>
		/// A human readable text representing the response of the InterApp Call.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The InterApp Message that triggered this response.
		/// </summary>
		public EditChannel Request { get; set; }
	}

	/// <summary>
	/// Inter-App Message allowing to delete existing channels.
	/// </summary>
	public class DeleteChannel : Message
	{
		/// <summary>
		/// Instantiates a new instance of the <see cref="DeleteChannel"/> class.
		/// </summary>
		/// <param name="channelId">The ID of the to be removed channel.</param>
		public DeleteChannel(int channelId)
		{
			ChannelId = channelId;
		}


		/// <summary>
		/// The ID of the to be removed channel.
		/// </summary>
		public int ChannelId { get; set; }
	}

	/// <summary>
	/// InterApp result message from the <see cref="DeleteChannel"/> Message.
	/// </summary>
	public class DeleteChannelResult : Message
	{
		/// <summary>
		/// Indicates if the InterApp Call was successful or not
		/// </summary>
		public bool Success { get; set; }

		/// <summary>
		/// A human readable text representing the response of the InterApp Call.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The InterApp Message that triggered this response.
		/// </summary>
		public DeleteChannel Request { get; set; }
	}
}
