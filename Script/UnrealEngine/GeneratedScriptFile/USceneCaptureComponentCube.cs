using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USceneCaptureComponentCube:USceneCaptureComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void CaptureScene(IntPtr _this);
/// <summary>
/// Render the scene to the texture target immediately.
/// This should not be used if bCaptureEveryFrame is enabled, or the scene capture will render redundantly.
/// </summary>
public  void CaptureScene()
{
	CheckIsValid();
	CaptureScene(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
