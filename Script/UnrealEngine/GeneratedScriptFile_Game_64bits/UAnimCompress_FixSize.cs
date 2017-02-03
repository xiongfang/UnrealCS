#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimCompress
	{
		static readonly int Description__Offset;
		public FString Description
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+Description__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Description__Offset, false);}
			
		}
		
		static readonly int bNeedsSkeleton__Offset;
		public bool bNeedsSkeleton
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNeedsSkeleton__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int TranslationCompressionFormat__Offset;
		public AnimationCompressionFormat TranslationCompressionFormat
		{
			get{ CheckIsValid();return (AnimationCompressionFormat)Marshal.PtrToStructure(_this.Get()+TranslationCompressionFormat__Offset, typeof(AnimationCompressionFormat));}
			
		}
		
		static readonly int RotationCompressionFormat__Offset;
		public AnimationCompressionFormat RotationCompressionFormat
		{
			get{ CheckIsValid();return (AnimationCompressionFormat)Marshal.PtrToStructure(_this.Get()+RotationCompressionFormat__Offset, typeof(AnimationCompressionFormat));}
			
		}
		
		static readonly int ScaleCompressionFormat__Offset;
		public AnimationCompressionFormat ScaleCompressionFormat
		{
			get{ CheckIsValid();return (AnimationCompressionFormat)Marshal.PtrToStructure(_this.Get()+ScaleCompressionFormat__Offset, typeof(AnimationCompressionFormat));}
			
		}
		
		static UAnimCompress()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimCompress");
			Description__Offset=GetPropertyOffset(NativeClassPtr,"Description");
			bNeedsSkeleton__Offset=GetPropertyOffset(NativeClassPtr,"bNeedsSkeleton");
			TranslationCompressionFormat__Offset=GetPropertyOffset(NativeClassPtr,"TranslationCompressionFormat");
			RotationCompressionFormat__Offset=GetPropertyOffset(NativeClassPtr,"RotationCompressionFormat");
			ScaleCompressionFormat__Offset=GetPropertyOffset(NativeClassPtr,"ScaleCompressionFormat");
			
		}
		
	}
	
}
#endif
#endif
