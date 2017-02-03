using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UThrobber:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAnimateOpacity(IntPtr _this,int bInAnimateOpacity);
/// <summary>Sets whether the pieces animate their opacity.</summary>
public  void SetAnimateOpacity(bool bInAnimateOpacity)
{
	CheckIsValid();
	SetAnimateOpacity(_this.Get(),bInAnimateOpacity?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAnimateVertically(IntPtr _this,int bInAnimateVertically);
/// <summary>Sets whether the pieces animate vertically.</summary>
public  void SetAnimateVertically(bool bInAnimateVertically)
{
	CheckIsValid();
	SetAnimateVertically(_this.Get(),bInAnimateVertically?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAnimateHorizontally(IntPtr _this,int bInAnimateHorizontally);
/// <summary>Sets whether the pieces animate horizontally.</summary>
public  void SetAnimateHorizontally(bool bInAnimateHorizontally)
{
	CheckIsValid();
	SetAnimateHorizontally(_this.Get(),bInAnimateHorizontally?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetNumberOfPieces(IntPtr _this,int InNumberOfPieces);
/// <summary>Sets how many pieces there are</summary>
public  void SetNumberOfPieces(int InNumberOfPieces)
{
	CheckIsValid();
	SetNumberOfPieces(_this.Get(),InNumberOfPieces);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
