#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionSpeedTree
	{
		static readonly int GeometryType__Offset;
		public ESpeedTreeGeometryType GeometryType
		{
			get{ CheckIsValid();return (ESpeedTreeGeometryType)Marshal.PtrToStructure(_this.Get()+GeometryType__Offset, typeof(ESpeedTreeGeometryType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GeometryType__Offset, false);}
			
		}
		
		static readonly int WindType__Offset;
		public ESpeedTreeWindType WindType
		{
			get{ CheckIsValid();return (ESpeedTreeWindType)Marshal.PtrToStructure(_this.Get()+WindType__Offset, typeof(ESpeedTreeWindType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WindType__Offset, false);}
			
		}
		
		static readonly int LODType__Offset;
		public ESpeedTreeLODType LODType
		{
			get{ CheckIsValid();return (ESpeedTreeLODType)Marshal.PtrToStructure(_this.Get()+LODType__Offset, typeof(ESpeedTreeLODType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LODType__Offset, false);}
			
		}
		
		static readonly int BillboardThreshold__Offset;
		public float BillboardThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BillboardThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BillboardThreshold__Offset, false);}
			
		}
		
		static readonly int bAccurateWindVelocities__Offset;
		public bool bAccurateWindVelocities
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAccurateWindVelocities__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAccurateWindVelocities__Offset, 1,0,1,255);}
			
		}
		
		static UMaterialExpressionSpeedTree()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionSpeedTree");
			GeometryType__Offset=GetPropertyOffset(NativeClassPtr,"GeometryType");
			WindType__Offset=GetPropertyOffset(NativeClassPtr,"WindType");
			LODType__Offset=GetPropertyOffset(NativeClassPtr,"LODType");
			BillboardThreshold__Offset=GetPropertyOffset(NativeClassPtr,"BillboardThreshold");
			bAccurateWindVelocities__Offset=GetPropertyOffset(NativeClassPtr,"bAccurateWindVelocities");
			
		}
		
	}
	
}
#endif
#endif
