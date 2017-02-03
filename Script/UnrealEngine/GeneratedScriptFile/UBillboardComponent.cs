using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UBillboardComponent:UPrimitiveComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSpriteAndUV(IntPtr _this,IntPtr NewSprite,int NewU,int NewUL,int NewV,int NewVL);
/// <summary>Change the sprite texture and the UV's used by this component</summary>
public  void SetSpriteAndUV(UTexture2D NewSprite,int NewU,int NewUL,int NewV,int NewVL)
{
	CheckIsValid();
	SetSpriteAndUV(_this.Get(),NewSprite,NewU,NewUL,NewV,NewVL);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetUV(IntPtr _this,int NewU,int NewUL,int NewV,int NewVL);
/// <summary>Change the sprite's UVs</summary>
public  void SetUV(int NewU,int NewUL,int NewV,int NewVL)
{
	CheckIsValid();
	SetUV(_this.Get(),NewU,NewUL,NewV,NewVL);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSprite(IntPtr _this,IntPtr NewSprite);
/// <summary>Change the sprite texture used by this component</summary>
public  void SetSprite(UTexture2D NewSprite)
{
	CheckIsValid();
	SetSprite(_this.Get(),NewSprite);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
