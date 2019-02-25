using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WMPLib
{
	[ComImport]
	[CompilerGenerated]
	[Guid("6C497D62-8919-413C-82DB-E935FB3EC584")]
	[TypeIdentifier]
	public interface IWMPPlayer4 : IWMPCore3, IWMPCore2, IWMPCore
	{
		string URL
		{
			[DispId(1)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		WMPPlayState playState
		{
			[DispId(10)]
			get;
		}

		IWMPControls controls
		{
			[DispId(4)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		void _VtblGap1_1();

		void _VtblGap2_1();
	}
}
