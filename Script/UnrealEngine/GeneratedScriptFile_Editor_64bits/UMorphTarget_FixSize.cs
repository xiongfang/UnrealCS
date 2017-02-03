#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMorphTarget
	{
		static readonly int BaseSkelMesh__Offset;
		/// <summary>USkeletalMesh that this vertex animation works on.</summary>
		public USkeletalMesh BaseSkelMesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BaseSkelMesh__Offset); if (v == IntPtr.Zero)return null; USkeletalMesh retValue = new USkeletalMesh(); retValue._this = v; return retValue; }
			
		}
		
		static UMorphTarget()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MorphTarget");
			BaseSkelMesh__Offset=GetPropertyOffset(NativeClassPtr,"BaseSkelMesh");
			
		}
		
	}
	
}
#endif
#endif
