#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionViewProperty
	{
		static readonly int Property__Offset;
		public EMaterialExposedViewProperty Property
		{
			get{ CheckIsValid();return (EMaterialExposedViewProperty)Marshal.PtrToStructure(_this.Get()+Property__Offset, typeof(EMaterialExposedViewProperty));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Property__Offset, false);}
			
		}
		
		static UMaterialExpressionViewProperty()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionViewProperty");
			Property__Offset=GetPropertyOffset(NativeClassPtr,"Property");
			
		}
		
	}
	
}
#endif
#endif
