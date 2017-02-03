#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieScene3DAttachSection
	{
		static readonly int AttachSocketName__Offset;
		public FName AttachSocketName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+AttachSocketName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AttachSocketName__Offset, false);}
			
		}
		
		static readonly int AttachComponentName__Offset;
		public FName AttachComponentName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+AttachComponentName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AttachComponentName__Offset, false);}
			
		}
		
		static readonly int bConstrainTx__Offset;
		public bool bConstrainTx
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bConstrainTx__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bConstrainTx__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bConstrainTy__Offset;
		public bool bConstrainTy
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bConstrainTy__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bConstrainTy__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bConstrainTz__Offset;
		public bool bConstrainTz
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bConstrainTz__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bConstrainTz__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bConstrainRx__Offset;
		public bool bConstrainRx
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bConstrainRx__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bConstrainRx__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bConstrainRy__Offset;
		public bool bConstrainRy
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bConstrainRy__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bConstrainRy__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bConstrainRz__Offset;
		public bool bConstrainRz
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bConstrainRz__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bConstrainRz__Offset, 1,0,32,32);}
			
		}
		
		static UMovieScene3DAttachSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieScene3DAttachSection");
			AttachSocketName__Offset=GetPropertyOffset(NativeClassPtr,"AttachSocketName");
			AttachComponentName__Offset=GetPropertyOffset(NativeClassPtr,"AttachComponentName");
			bConstrainTx__Offset=GetPropertyOffset(NativeClassPtr,"bConstrainTx");
			bConstrainTy__Offset=GetPropertyOffset(NativeClassPtr,"bConstrainTy");
			bConstrainTz__Offset=GetPropertyOffset(NativeClassPtr,"bConstrainTz");
			bConstrainRx__Offset=GetPropertyOffset(NativeClassPtr,"bConstrainRx");
			bConstrainRy__Offset=GetPropertyOffset(NativeClassPtr,"bConstrainRy");
			bConstrainRz__Offset=GetPropertyOffset(NativeClassPtr,"bConstrainRz");
			
		}
		
	}
	
}
#endif
#endif
