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
		/// The object that hold the channel data.
		/// </summary>
		public ChannelData Data { get; set; }
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
		/// The object that hold the channel data.
		/// </summary>
		public ChannelData Data { get; set; }
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
