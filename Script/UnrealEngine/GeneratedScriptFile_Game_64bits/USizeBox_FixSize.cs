#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USizeBox
	{
		static readonly int bOverride_WidthOverride__Offset;
		public bool bOverride_WidthOverride
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverride_WidthOverride__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverride_WidthOverride__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOverride_HeightOverride__Offset;
		public bool bOverride_HeightOverride
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverride_HeightOverride__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverride_HeightOverride__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bOverride_MinDesiredWidth__Offset;
		public bool bOverride_MinDesiredWidth
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverride_MinDesiredWidth__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverride_MinDesiredWidth__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bOverride_MinDesiredHeight__Offset;
		public bool bOverride_MinDesiredHeight
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverride_MinDesiredHeight__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverride_MinDesiredHeight__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bOverride_MaxDesiredWidth__Offset;
		public bool bOverride_MaxDesiredWidth
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverride_MaxDesiredWidth__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverride_MaxDesiredWidth__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bOverride_MaxDesiredHeight__Offset;
		public bool bOverride_MaxDesiredHeight
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverride_MaxDesiredHeight__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverride_MaxDesiredHeight__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bOverride_MaxAspectRatio__Offset;
		public bool bOverride_MaxAspectRatio
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverride_MaxAspectRatio__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverride_MaxAspectRatio__Offset, 1,0,64,64);}
			
		}
		
		static readonly int WidthOverride__Offset;
		public float WidthOverride
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WidthOverride__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidthOverride__Offset, false);}
			
		}
		
		static readonly int HeightOverride__Offset;
		public float HeightOverride
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+HeightOverride__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HeightOverride__Offset, false);}
			
		}
		
		static readonly int MinDesiredWidth__Offset;
		public float MinDesiredWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinDesiredWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinDesiredWidth__Offset, false);}
			
		}
		
		static readonly int MinDesiredHeight__Offset;
		public float MinDesiredHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinDesiredHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinDesiredHeight__Offset, false);}
			
		}
		
		static readonly int MaxDesiredWidth__Offset;
		public float MaxDesiredWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxDesiredWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxDesiredWidth__Offset, false);}
			
		}
		
		static readonly int MaxDesiredHeight__Offset;
		public float MaxDesiredHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxDesiredHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxDesiredHeight__Offset, false);}
			
		}
		
		static readonly int MaxAspectRatio__Offset;
		public float MaxAspectRatio
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxAspectRatio__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxAspectRatio__Offset, false);}
			
		}
		
		static USizeBox()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SizeBox");
			bOverride_WidthOverride__Offset=GetPropertyOffset(NativeClassPtr,"bOverride_WidthOverride");
			bOverride_HeightOverride__Offset=GetPropertyOffset(NativeClassPtr,"bOverride_HeightOverride");
			bOverride_MinDesiredWidth__Offset=GetPropertyOffset(NativeClassPtr,"bOverride_MinDesiredWidth");
			bOverride_MinDesiredHeight__Offset=GetPropertyOffset(NativeClassPtr,"bOverride_MinDesiredHeight");
			bOverride_MaxDesiredWidth__Offset=GetPropertyOffset(NativeClassPtr,"bOverride_MaxDesiredWidth");
			bOverride_MaxDesiredHeight__Offset=GetPropertyOffset(NativeClassPtr,"bOverride_MaxDesiredHeight");
			bOverride_MaxAspectRatio__Offset=GetPropertyOffset(NativeClassPtr,"bOverride_MaxAspectRatio");
			WidthOverride__Offset=GetPropertyOffset(NativeClassPtr,"WidthOverride");
			HeightOverride__Offset=GetPropertyOffset(NativeClassPtr,"HeightOverride");
			MinDesiredWidth__Offset=GetPropertyOffset(NativeClassPtr,"MinDesiredWidth");
			MinDesiredHeight__Offset=GetPropertyOffset(NativeClassPtr,"MinDesiredHeight");
			MaxDesiredWidth__Offset=GetPropertyOffset(NativeClassPtr,"MaxDesiredWidth");
			MaxDesiredHeight__Offset=GetPropertyOffset(NativeClassPtr,"MaxDesiredHeight");
			MaxAspectRatio__Offset=GetPropertyOffset(NativeClassPtr,"MaxAspectRatio");
			
		}
		
	}
	
}
#endif
#endif
