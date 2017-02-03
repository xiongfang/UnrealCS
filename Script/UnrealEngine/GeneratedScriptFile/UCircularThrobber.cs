using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCircularThrobber:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRadius(IntPtr _this,float InRadius);
/// <summary>Sets the radius of the circle.</summary>
public  void SetRadius(float InRadius)
{
	CheckIsValid();
	SetRadius(_this.Get(),InRadius);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPeriod(IntPtr _this,float InPeriod);
/// <summary>Sets the amount of time for a full circle (in seconds).</summary>
public  void SetPeriod(float InPeriod)
{
	CheckIsValid();
	SetPeriod(_this.Get(),InPeriod);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetNumberOfPieces(IntPtr _this,int InNumberOfPieces);
/// <summary>Sets how many pieces there are.</summary>
public  void SetNumberOfPieces(int InNumberOfPieces)
{
	CheckIsValid();
	SetNumberOfPieces(_this.Get(),InNumberOfPieces);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
