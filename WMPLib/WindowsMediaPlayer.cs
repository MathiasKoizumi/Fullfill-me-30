using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WMPLib
{
	[ComImport]
	[CoClass(typeof(object))]
	[TypeIdentifier]
	[Guid("6C497D62-8919-413C-82DB-E935FB3EC584")]
	[CompilerGenerated]
	public interface WindowsMediaPlayer : IWMPPlayer4, IWMPCore3, IWMPCore2, IWMPCore, _WMPOCXEvents_Event
	{
	}
}
