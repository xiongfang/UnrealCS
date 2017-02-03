#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ASceneCapture
	{
		static readonly int MeshComp__Offset;
		public UStaticMeshComponent MeshComp
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MeshComp__Offset); if (v == IntPtr.Zero)return null; UStaticMeshComponent retValue = new UStaticMeshComponent(); retValue._this = v; return retValue; }
			
		}
		
		static ASceneCapture()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SceneCapture");
			MeshComp__Offset=GetPropertyOffset(NativeClassPtr,"MeshComp");
			
		}
		
	}
	
}
#endif
#endif
