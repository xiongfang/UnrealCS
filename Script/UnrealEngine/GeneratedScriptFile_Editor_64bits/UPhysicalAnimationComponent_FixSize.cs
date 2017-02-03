#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPhysicalAnimationComponent
	{
		static readonly int StrengthMultiplyer__Offset;
		/// <summary>Muliplies the strength of any active motors. (can blend from 0-1 for example)</summary>
		public float StrengthMultiplyer
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StrengthMultiplyer__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StrengthMultiplyer__Offset, false);}
			
		}
		
		static readonly int SkeletalMeshComponent__Offset;
		public USkeletalMeshComponent SkeletalMeshComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SkeletalMeshComponent__Offset); if (v == IntPtr.Zero)return null; USkeletalMeshComponent retValue = new USkeletalMeshComponent(); retValue._this = v; return retValue; }
			
		}
		
		static UPhysicalAnimationComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PhysicalAnimationComponent");
			StrengthMultiplyer__Offset=GetPropertyOffset(NativeClassPtr,"StrengthMultiplyer");
			SkeletalMeshComponent__Offset=GetPropertyOffset(NativeClassPtr,"SkeletalMeshComponent");
			
		}
		
	}
	
}
#endif
#endif
