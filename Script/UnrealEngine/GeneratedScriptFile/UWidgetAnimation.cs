using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UWidgetAnimation:UMovieSceneSequence 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetEndTime(IntPtr _this);
/// <summary>
/// Get the end time of this animation.
/// @return End time in seconds.
/// @see GetStartTime
/// </summary>
public  float GetEndTime()
{
	CheckIsValid();
	float ___ret = GetEndTime(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetStartTime(IntPtr _this);
/// <summary>
/// Get the start time of this animation.
/// @return Start time in seconds.
/// @see GetEndTime
/// </summary>
public  float GetStartTime()
{
	CheckIsValid();
	float ___ret = GetStartTime(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
