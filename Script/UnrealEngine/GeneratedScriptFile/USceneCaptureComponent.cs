using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USceneCaptureComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ShowOnlyActorComponents(IntPtr _this,IntPtr InActor);
/// <summary>Adds all primitive components in the actor to our list of show-only components.</summary>
public  void ShowOnlyActorComponents(AActor InActor)
{
	CheckIsValid();
	ShowOnlyActorComponents(_this.Get(),InActor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ShowOnlyComponent(IntPtr _this,IntPtr InComponent);
/// <summary>Adds the component to our list of show-only components.</summary>
public  void ShowOnlyComponent(UPrimitiveComponent InComponent)
{
	CheckIsValid();
	ShowOnlyComponent(_this.Get(),InComponent);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void HideActorComponents(IntPtr _this,IntPtr InActor);
/// <summary>Adds all primitive components in the actor to our list of hidden components.</summary>
public  void HideActorComponents(AActor InActor)
{
	CheckIsValid();
	HideActorComponents(_this.Get(),InActor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void HideComponent(IntPtr _this,IntPtr InComponent);
/// <summary>Adds the component to our list of hidden components.</summary>
public  void HideComponent(UPrimitiveComponent InComponent)
{
	CheckIsValid();
	HideComponent(_this.Get(),InComponent);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
