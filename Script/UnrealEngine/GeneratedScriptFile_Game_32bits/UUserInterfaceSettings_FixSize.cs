#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UUserInterfaceSettings
	{
		static readonly int DefaultCursor__Offset;
		public FStringClassReference DefaultCursor
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+DefaultCursor__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultCursor__Offset, false);}
			
		}
		
		static readonly int TextEditBeamCursor__Offset;
		public FStringClassReference TextEditBeamCursor
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+TextEditBeamCursor__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TextEditBeamCursor__Offset, false);}
			
		}
		
		static readonly int CrosshairsCursor__Offset;
		public FStringClassReference CrosshairsCursor
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+CrosshairsCursor__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CrosshairsCursor__Offset, false);}
			
		}
		
		static readonly int HandCursor__Offset;
		public FStringClassReference HandCursor
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+HandCursor__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HandCursor__Offset, false);}
			
		}
		
		static readonly int GrabHandCursor__Offset;
		public FStringClassReference GrabHandCursor
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+GrabHandCursor__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GrabHandCursor__Offset, false);}
			
		}
		
		static readonly int GrabHandClosedCursor__Offset;
		public FStringClassReference GrabHandClosedCursor
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+GrabHandClosedCursor__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GrabHandClosedCursor__Offset, false);}
			
		}
		
		static readonly int SlashedCircleCursor__Offset;
		public FStringClassReference SlashedCircleCursor
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+SlashedCircleCursor__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SlashedCircleCursor__Offset, false);}
			
		}
		
		static readonly int ApplicationScale__Offset;
		public float ApplicationScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ApplicationScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationScale__Offset, false);}
			
		}
		
		static readonly int CustomScalingRuleClass__Offset;
		public FStringClassReference CustomScalingRuleClass
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+CustomScalingRuleClass__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CustomScalingRuleClass__Offset, false);}
			
		}
		
		static readonly int UIScaleCurve__Offset;
		public FRuntimeFloatCurve UIScaleCurve
		{
			get{ CheckIsValid();return (FRuntimeFloatCurve)Marshal.PtrToStructure(_this.Get()+UIScaleCurve__Offset, typeof(FRuntimeFloatCurve));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UIScaleCurve__Offset, false);}
			
		}
		
		static readonly int bLoadWidgetsOnDedicatedServer__Offset;
		public bool bLoadWidgetsOnDedicatedServer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLoadWidgetsOnDedicatedServer__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLoadWidgetsOnDedicatedServer__Offset, 1,0,1,255);}
			
		}
		
		static readonly int CursorClasses__Offset;
		public TObjectArray<UObject>  CursorClasses
		{
					get{ CheckIsValid();return new TObjectArray<UObject>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CursorClasses__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CursorClasses__Offset, false);}
			
		}
		
		static readonly int CustomScalingRuleClassInstance__Offset;
		public UClass CustomScalingRuleClassInstance
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CustomScalingRuleClassInstance__Offset); return v; }
			
		}
		
		static readonly int CustomScalingRule__Offset;
		public UDPICustomScalingRule CustomScalingRule
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CustomScalingRule__Offset); if (v == IntPtr.Zero)return null; UDPICustomScalingRule retValue = new UDPICustomScalingRule(); retValue._this = v; return retValue; }
			
		}
		
		static UUserInterfaceSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("UserInterfaceSettings");
			DefaultCursor__Offset=GetPropertyOffset(NativeClassPtr,"DefaultCursor");
			TextEditBeamCursor__Offset=GetPropertyOffset(NativeClassPtr,"TextEditBeamCursor");
			CrosshairsCursor__Offset=GetPropertyOffset(NativeClassPtr,"CrosshairsCursor");
			HandCursor__Offset=GetPropertyOffset(NativeClassPtr,"HandCursor");
			GrabHandCursor__Offset=GetPropertyOffset(NativeClassPtr,"GrabHandCursor");
			GrabHandClosedCursor__Offset=GetPropertyOffset(NativeClassPtr,"GrabHandClosedCursor");
			SlashedCircleCursor__Offset=GetPropertyOffset(NativeClassPtr,"SlashedCircleCursor");
			ApplicationScale__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationScale");
			CustomScalingRuleClass__Offset=GetPropertyOffset(NativeClassPtr,"CustomScalingRuleClass");
			UIScaleCurve__Offset=GetPropertyOffset(NativeClassPtr,"UIScaleCurve");
			bLoadWidgetsOnDedicatedServer__Offset=GetPropertyOffset(NativeClassPtr,"bLoadWidgetsOnDedicatedServer");
			CursorClasses__Offset=GetPropertyOffset(NativeClassPtr,"CursorClasses");
			CustomScalingRuleClassInstance__Offset=GetPropertyOffset(NativeClassPtr,"CustomScalingRuleClassInstance");
			CustomScalingRule__Offset=GetPropertyOffset(NativeClassPtr,"CustomScalingRule");
			
		}
		
	}
	
}
#endif
#endif
