using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AAudioVolume:AVolume 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetInteriorSettings(IntPtr _this,ref FInteriorSettings NewInteriorSettings);
public  void SetInteriorSettings(FInteriorSettings NewInteriorSettings)
{
	CheckIsValid();
	SetInteriorSettings(_this.Get(),ref NewInteriorSettings);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetReverbSettings(IntPtr _this,ref FReverbSettings NewReverbSettings);
public  void SetReverbSettings(FReverbSettings NewReverbSettings)
{
	CheckIsValid();
	SetReverbSettings(_this.Get(),ref NewReverbSettings);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetEnabled(IntPtr _this,int bNewEnabled);
public  void SetEnabled(bool bNewEnabled)
{
	CheckIsValid();
	SetEnabled(_this.Get(),bNewEnabled?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPriority(IntPtr _this,float NewPriority);
public  void SetPriority(float NewPriority)
{
	CheckIsValid();
	SetPriority(_this.Get(),NewPriority);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
