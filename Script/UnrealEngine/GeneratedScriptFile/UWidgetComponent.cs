using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UWidgetComponent:UMeshComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBackgroundColor(IntPtr _this,ref FLinearColor NewBackgroundColor);
/// <summary>Sets the background color and opacityscale for this widget</summary>
public  void SetBackgroundColor(FLinearColor NewBackgroundColor)
{
	CheckIsValid();
	SetBackgroundColor(_this.Get(),ref NewBackgroundColor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RequestRedraw(IntPtr _this);
/// <summary>Requests that the widget be redrawn.</summary>
public  void RequestRedraw()
{
	CheckIsValid();
	RequestRedraw(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDrawSize(IntPtr _this,ref FVector2D Size);
/// <summary>Sets the draw size of the quad in the world</summary>
public  void SetDrawSize(FVector2D Size)
{
	CheckIsValid();
	SetDrawSize(_this.Get(),ref Size);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D GetDrawSize(IntPtr _this);
/// <summary>@return The draw size of the quad in the world</summary>
public  FVector2D GetDrawSize()
{
	CheckIsValid();
	FVector2D ___ret = GetDrawSize(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetOwnerPlayer(IntPtr _this);
/// <summary>Gets the local player that owns this widget component.</summary>
public  ULocalPlayer GetOwnerPlayer()
{
	CheckIsValid();
	IntPtr ___ret = GetOwnerPlayer(_this.Get());
	if(___ret==IntPtr.Zero) return null; ULocalPlayer ___ret2= new ULocalPlayer(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOwnerPlayer(IntPtr _this,IntPtr LocalPlayer);
/// <summary>
/// Sets the local player that owns this widget component.  Setting the owning player controls
/// which player's viewport the widget appears on in a split screen scenario.  Additionally it
/// forwards the owning player to the actual UserWidget that is spawned.
/// </summary>
public  void SetOwnerPlayer(ULocalPlayer LocalPlayer)
{
	CheckIsValid();
	SetOwnerPlayer(_this.Get(),LocalPlayer);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetWidget(IntPtr _this,IntPtr Widget);
/// <summary>
/// Sets the widget to use directly. This function will keep track of the widget till the next time it's called
///     with either a newer widget or a nullptr
/// </summary>
public  void SetWidget(UUserWidget Widget)
{
	CheckIsValid();
	SetWidget(_this.Get(),Widget);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetMaterialInstance(IntPtr _this);
/// <summary>@return The dynamic material instance used to render the user widget</summary>
public  UMaterialInstanceDynamic GetMaterialInstance()
{
	CheckIsValid();
	IntPtr ___ret = GetMaterialInstance(_this.Get());
	if(___ret==IntPtr.Zero) return null; UMaterialInstanceDynamic ___ret2= new UMaterialInstanceDynamic(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetRenderTarget(IntPtr _this);
/// <summary>@return The render target to which the user widget is rendered</summary>
public  UTextureRenderTarget2D GetRenderTarget()
{
	CheckIsValid();
	IntPtr ___ret = GetRenderTarget(_this.Get());
	if(___ret==IntPtr.Zero) return null; UTextureRenderTarget2D ___ret2= new UTextureRenderTarget2D(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetUserWidgetObject(IntPtr _this);
/// <summary>@return The user widget object displayed by this component</summary>
public  UUserWidget GetUserWidgetObject()
{
	CheckIsValid();
	IntPtr ___ret = GetUserWidgetObject(_this.Get());
	if(___ret==IntPtr.Zero) return null; UUserWidget ___ret2= new UUserWidget(){ _this = ___ret }; return ___ret2;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
