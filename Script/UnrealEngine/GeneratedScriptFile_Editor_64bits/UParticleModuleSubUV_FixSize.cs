#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleSubUV
	{
		static readonly int Animation__Offset;
		/// <summary>
		/// SubUV animation asset to use.
		/// When specified, optimal bounding geometry for each SubUV frame will be used when rendering the sprites for this emitter instead of full quads.
		/// This reduction in overdraw can reduce the GPU cost of rendering the emitter by 2x or 3x, depending on how much unused space was in the texture.
		/// The bounding geometry is generated off of the texture alpha setup in the SubUV Animation asset, so that has to match what the material is using for opacity, or clipping will occur.
		/// When specified, SubImages_Horizontal and SubImages_Vertical will come from the asset instead of the Required Module.
		/// </summary>
		public USubUVAnimation Animation
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Animation__Offset); if (v == IntPtr.Zero)return null; USubUVAnimation retValue = new USubUVAnimation(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SubImageIndex__Offset;
		/// <summary>
		/// The index of the sub-image that should be used for the particle.
		/// The value is retrieved using the RelativeTime of the particles.
		/// </summary>
		public FRawDistributionFloat SubImageIndex
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+SubImageIndex__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SubImageIndex__Offset, false);}
			
		}
		
		static readonly int bUseRealTime__Offset;
		/// <summary>
		/// If true, use *real* time when updating the image index.
		/// The movie will update regardless of the slomo settings of the game.
		/// </summary>
		public bool bUseRealTime
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseRealTime__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseRealTime__Offset, 1,0,1,1);}
			
		}
		
		static UParticleModuleSubUV()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleSubUV");
			Animation__Offset=GetPropertyOffset(NativeClassPtr,"Animation");
			SubImageIndex__Offset=GetPropertyOffset(NativeClassPtr,"SubImageIndex");
			bUseRealTime__Offset=GetPropertyOffset(NativeClassPtr,"bUseRealTime");
			
		}
		
	}
	
}
#endif
#endif
