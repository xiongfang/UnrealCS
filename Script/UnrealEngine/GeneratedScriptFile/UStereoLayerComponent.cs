using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UStereoLayerComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MarkTextureForUpdate(IntPtr _this);
/// <summary>Manually mark the stereo layer texture for updating</summary>
public  void MarkTextureForUpdate()
{
	CheckIsValid();
	MarkTextureForUpdate(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetPriority(IntPtr _this);
/// <summary>@return the render priority</summary>
public  int GetPriority()
{
	CheckIsValid();
	int ___ret = GetPriority(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPriority(IntPtr _this,int InPriority);
/// <summary>
/// Change the layer's render priority, higher priorities render on top of lower priorities
/// @param       InPriority: Priority value
/// </summary>
public  void SetPriority(int InPriority)
{
	CheckIsValid();
	SetPriority(_this.Get(),InPriority);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FBox2D GetUVRect(IntPtr _this);
/// <summary>@return the UV coordinates mapped to the quad face</summary>
public  FBox2D GetUVRect()
{
	CheckIsValid();
	FBox2D ___ret = GetUVRect(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetUVRect(IntPtr _this,ref FBox2D InUVRect);
/// <summary>
/// Change the UV coordinates mapped to the quad face
/// @param       InUVRect: Min and Max UV coordinates
/// </summary>
public  void SetUVRect(FBox2D InUVRect)
{
	CheckIsValid();
	SetUVRect(_this.Get(),ref InUVRect);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D GetQuadSize(IntPtr _this);
/// <summary>@return the height and width of the rendered quad</summary>
public  FVector2D GetQuadSize()
{
	CheckIsValid();
	FVector2D ___ret = GetQuadSize(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetQuadSize(IntPtr _this,ref FVector2D InQuadSize);
/// <summary>
/// Change the quad size. This is the unscaled height and width, before component scale is applied.
/// @param       InQuadSize: new quad size.
/// </summary>
public  void SetQuadSize(FVector2D InQuadSize)
{
	CheckIsValid();
	SetQuadSize(_this.Get(),ref InQuadSize);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetTexture(IntPtr _this);
/// <summary>@return the texture mapped to the stereo layer quad</summary>
public  UTexture GetTexture()
{
	CheckIsValid();
	IntPtr ___ret = GetTexture(_this.Get());
	if(___ret==IntPtr.Zero) return null; UTexture ___ret2= new UTexture(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTexture(IntPtr _this,IntPtr InTexture);
/// <summary>
/// Change the texture displayed on the stereo layer quad
/// @param       InTexture: new Texture2D
/// </summary>
public  void SetTexture(UTexture InTexture)
{
	CheckIsValid();
	SetTexture(_this.Get(),InTexture);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
