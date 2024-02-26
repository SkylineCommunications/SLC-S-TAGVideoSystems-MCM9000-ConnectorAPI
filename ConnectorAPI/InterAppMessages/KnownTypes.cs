// Ignore Spelling: MCM App

namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCM9000.InterAppMessages
{
	using System;
	using System.Collections.Generic;

	using Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCM9000.InterAppMessages.Channels;

	/// <summary>
	/// Static class holding the types of the InterApp Messages.
	/// </summary>
	public static class Types
	{
		/// <summary>
		/// Gets a list of all the supported InterApp Message Types.
		/// </summary>
		public static List<Type> KnownTypes { get; } = new List<Type>
		{
			// Channel
			typeof(CreateChannel),
			typeof(CreateChannelResult),
			typeof(EditChannel),
			typeof(EditChannelResult),
			typeof(DeleteChannel),
			typeof(DeleteChannelResult),
		};
	}
}
