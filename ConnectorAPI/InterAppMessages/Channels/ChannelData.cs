// Ignore Spelling: Ip descrambling MCM App Multicast Hls Codecs Playlist Overscan

namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCM9000.InterAppMessages.Channels
{
	using System;

	/// <summary>
	/// Class that represents the data for a channel.
	/// </summary>
	[Serializable]
	public class ChannelData
	{
		/// <summary>
		/// The id of the channel.
		/// </summary>
		public int? Id { get; set; }

		/// <summary>
		/// The name or title  of the channel.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Gets or sets the channel source stream information: IP address.
		/// </summary>
		public string IpAddress { get; set; }

		/// <summary>
		/// Gets or sets the channel source stream information: Secondary IP address.
		/// </summary>
		public string SecondaryIpAddress { get; set; }

		/// <summary>
		/// Gets or sets the channel source stream information: Port.
		/// </summary>
		public int? Port { get; set; }

		/// <summary>
		/// Gets or sets the channel source stream information: Secondary Port.
		/// </summary>
		public int? SecondaryPort { get; set; }

		/// <summary>
		/// Gets or sets the channel source stream information: program number.
		/// </summary>
		public int? ProgramNumber { get; set; }

		/// <summary>
		/// Gets or sets the type of the channel.
		/// </summary>
		public ChannelType? Type { get; set; }

		/// <summary>
		/// Gets or sets the descrambling state of the channel.
		/// </summary>
		public bool? IsDescrambling { get; set; }

		/// <summary>
		/// Gets or sets the encryption type of the channel.
		/// </summary>
		public ChannelEncryption? Encryption { get; set; }

		/// <summary>
		/// Gets or sets the transport stream ID.
		/// </summary>
		public int? TransportStreamID { get; set; }

		/// <summary>
		/// Gets or sets the channel source specific multicast address.
		/// </summary>
		public string SourceSpecificMulticast { get; set; }

		/// <summary>
		/// Gets or sets the channel secondary source specific multicast address.
		/// </summary>
		public string SecondarySourceSpecificMulticast { get; set; }

		/// <summary>
		/// Gets or sets the network interface of the channel.
		/// </summary>
		public NetworkInterface? Network { get; set; }

		/// <summary>
		/// Gets or sets the network secondary interface of the channel.
		/// </summary>
		public NetworkInterface? SecondaryNetwork { get; set; }

		/// <summary>
		/// Gets or sets the service type of the channel.
		/// </summary>
		public ChannelServiceType? ServiceType { get; set; }

		/// <summary>
		/// Gets or sets the channel HLS version.
		/// </summary>
		public string HlsVersion { get; set; }

		/// <summary>
		/// Get or sets the channel bandwidth.
		/// </summary>
		public string Bandwidth { get; set; }

		/// <summary>
		/// Gets or sets the channel codecs.
		/// </summary>
		public string Codecs { get; set; }

		/// <summary>
		/// Gets or sets the channel audio.
		/// </summary>
		public string Audio { get; set; }

		/// <summary>
		/// Gets or sets the channel resolution.
		/// </summary>
		public string Resolution { get; set; }

		/// <summary>
		/// Gets or sets the channel playlist URL.
		/// </summary>
		public string PlaylistUrl { get; set; }

		/// <summary>
		/// Gets or sets the channel profile URL.
		/// </summary>
		public string ProfileUrl { get; set; }

		/// <summary>
		/// Gets or sets the channel delay.
		/// </summary>
		public int? Delay { get; set; }

		/// <summary>
		/// Gets or sets the scrambled state of the channel.
		/// </summary>
		public bool? IsScrambled { get; set; }

		/// <summary>
		/// Gets or sets 'cut margin' and 'is scanned' value.
		/// </summary>
		public OverscanType? HideOverscan { get; set; }
	}
}
