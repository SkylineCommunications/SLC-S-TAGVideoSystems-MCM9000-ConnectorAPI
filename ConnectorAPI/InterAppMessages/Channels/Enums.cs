namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCM9000.InterAppMessages.Channels
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	/// <summary>
	/// Enum with the different channel types.
	/// </summary>
	public enum ChannelType
	{
		/// <summary>
		/// Channel Type: <see cref="T_SPTS"/>
		/// </summary>
		T_SPTS = 0,

		/// <summary>
		/// Channel Type: <see cref="T_MPTS"/>
		/// </summary>
		T_MPTS = 1,

		/// <summary>
		/// Channel Type: <see cref="T_HLS"/>
		/// </summary>
		T_HLS = 2,

		/// <summary>
		/// Channel Type: <see cref="T_RTMP"/>
		/// </summary>
		T_RTMP = 3,

		/// <summary>
		/// Channel Type: <see cref="T_2022_6"/>
		/// </summary>
		T_2022_6 = 4,
	}

	/// <summary>
	/// Enum with the different channel encryption types.
	/// </summary>
	public enum ChannelEncryption
	{
		/// <summary>
		/// No encryption.
		/// </summary>
		None = 0,

		/// <summary>
		/// Axinom, CENC
		/// </summary>
		Axinom_CENC = 196619,

		/// <summary>
		/// BISS-2, AES-128-CBC
		/// </summary>
		BISS2_AES128CBC = 65545,

		/// <summary>
		/// BuyDRM, CENC
		/// </summary>
		BuyDRM_CENC = 196622,

		/// <summary>
		/// CPIX, CENC
		/// </summary>
		CPIX_CENC = 196616,

		/// <summary>
		/// Generic, AES-128-CBC
		/// </summary>
		Generic_AES128CBC = 65540,

		/// <summary>
		/// Huawei PlayReady, AES-128-CTR
		/// </summary>
		Huawei_PlayReady_AES128CTR = 131074,

		/// <summary>
		/// Irdeto, AES-128-CBC
		/// </summary>
		Irdeto_AES128CBC = 65543,

		/// <summary>
		/// Irdeto, CENC
		/// </summary>
		Irdeto_CENC = 196615,

		/// <summary>
		/// Kaltura UDRM, CENC
		/// </summary>
		Kaltura_UDRM_CENC = 196621,

		/// <summary>
		/// Simulcrypt, AES-128-CBC
		/// </summary>
		Simulcrypt_AES128CBC = 65537,

		/// <summary>
		/// Simulcrypt, AES-128-ECB
		/// </summary>
		Simulcrypt_AES128ECB = 524289,

		/// <summary>
		/// Simulcrypt, DVB-CSA
		/// </summary>
		Simulcrypt_DVB_CSA = 262145,

		/// <summary>
		/// SKY CKS, CENC
		/// </summary>
		SKY_CKS_CENC = 196614,

		/// <summary>
		/// Static, CENC
		/// </summary>
		Static_CENC = 196620,

		/// <summary>
		/// SynMedia, CENC
		/// </summary>
		SynMedia_CENC = 196618,

		/// <summary>
		/// Verimatrix MultiRights, CENC
		/// </summary>
		Verimatrix_MultiRights_CENC = 131077,

		/// <summary>
		/// Verimatrix, AES-128-CBC
		/// </summary>
		Verimatrix_AES128CBC = 65539,
	}

	/// <summary>
	/// Enum with the different network interfaces.
	/// </summary>
	public enum NetworkInterface
	{
		/// <summary>
		/// The first network interface
		/// </summary>
		Nic1 = 1,

		/// <summary>
		/// The second network interface
		/// </summary>
		Nic2 = 2,

		/// <summary>
		/// The third network interface
		/// </summary>
		Nic3 = 3,

		/// <summary>
		/// The fourth network interface
		/// </summary>
		Nic4 = 4,

		/// <summary>
		/// The fifth network interface
		/// </summary>
		Nic5 = 5,

		/// <summary>
		/// The sixth network interface
		/// </summary>
		Nic6 = 6,
	}

	/// <summary>
	/// Enum with the different service types.
	/// </summary>
	public enum ChannelServiceType
	{
		/// <summary>
		/// SD Video service type
		/// </summary>
		SD_Video = 1,

		/// <summary>
		/// HD Video service type
		/// </summary>
		HD_Video = 2,

		/// <summary>
		/// Audio service type
		/// </summary>
		Audio = 3,

		/// <summary>
		/// Data service type
		/// </summary>
		Data = 4,

		/// <summary>
		/// Low Resolution Video service type
		/// </summary>
		Low_Res_Video = 5,

		/// <summary>
		/// Contribution Feed service type
		/// </summary>
		Contribution_Feed = 6,

		/// <summary>
		/// Wide SD service type
		/// </summary>
		Wide_SD = 7,

		/// <summary>
		/// SD/HEVC service type
		/// </summary>
		SD_HEVC = 8,

		/// <summary>
		/// HD/HEVC service type
		/// </summary>
		HD_HEVC = 9,

		/// <summary>
		/// UHD/HEVC service type
		/// </summary>
		UHD_HEVC = 10,

		/// <summary>
		/// HD/50/60/HEVC service type
		/// </summary>
		HD_50_60_HEVC = 11,
	}
}
