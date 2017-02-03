using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCameraAnimInst:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetScale(IntPtr _this,float NewDuration);
/// <summary>Changes the scale of the animation while playing.</summary>
public  void SetScale(float NewDuration)
{
	CheckIsValid();
	SetScale(_this.Get(),NewDuration);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDuration(IntPtr _this,float NewDuration);
/// <summary>Changes the running duration of this active anim, while maintaining playback position.</summary>
public  void SetDuration(float NewDuration)
{
	CheckIsValid();
	SetDuration(_this.Get(),NewDuration);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Stop(IntPtr _this,int bImmediate);
/// <summary>Stops this instance playing whatever animation it is playing.</summary>
public  void Stop(bool bImmediate=false)
{
	CheckIsValid();
	Stop(_this.Get(),bImmediate?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
