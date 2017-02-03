using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UScrollBar:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetState(IntPtr _this,float InOffsetFraction,float InThumbSizeFraction);
/// <summary>
/// Set the offset and size of the track's thumb.
/// Note that the maximum offset is 1.0-ThumbSizeFraction.
/// If the user can view 1/3 of the items in a single page, the maximum offset will be ~0.667f
/// @param InOffsetFraction     Offset of the thumbnail from the top as a fraction of the total available scroll space.
/// @param InThumbSizeFraction  Size of thumbnail as a fraction of the total available scroll space.
/// </summary>
public  void SetState(float InOffsetFraction,float InThumbSizeFraction)
{
	CheckIsValid();
	SetState(_this.Get(),InOffsetFraction,InThumbSizeFraction);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
