// Ignore Spelling: MCM App

namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCM9000
{
	/// <summary>
	/// Contains constant values used in the ConnectorAPI.
	/// </summary>
	public static class Constants
	{
		/// <summary>
		/// The protocol name of the TAG Video Systems MCM-9000 Connector InterApp Calls.
		/// </summary>
		public const string ProtocolName = "TAG Video Systems MCM-9000";

		/// <summary>
		/// The ID of the parameter that will receive the InterApp Messages
		/// </summary>
		public const int InterAppReceiverPID = 9000000;

		/// <summary>
		/// The ID of the parameter that will hold the responses for the InterApp Messages
		/// </summary>
		public const int InterAppResponsePID = 9000001;
	}
}
