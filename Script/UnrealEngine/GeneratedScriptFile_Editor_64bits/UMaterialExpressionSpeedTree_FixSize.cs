#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionSpeedTree
	{
		static readonly int GeometryType__Offset;
		/// <summary>The type of SpeedTree geometry on which this material will be used</summary>
		public ESpeedTreeGeometryType GeometryType
		{
			get{ CheckIsValid();return (ESpeedTreeGeometryType)Marshal.PtrToStructure(_this.Get()+GeometryType__Offset, typeof(ESpeedTreeGeometryType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GeometryType__Offset, false);}
			
		}
		
		static readonly int WindType__Offset;
		/// <summary>The type of wind effect used on this tree. This can only go as high as it was in the SpeedTree Modeler, but you can set it to a lower option for lower quality wind and faster rendering.</summary>
		public ESpeedTreeWindType WindType
		{
			get{ CheckIsValid();return (ESpeedTreeWindType)Marshal.PtrToStructure(_this.Get()+WindType__Offset, typeof(ESpeedTreeWindType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WindType__Offset, false);}
			
		}
		
		static readonly int LODType__Offset;
		/// <summary>The type of LOD to use</summary>
		public ESpeedTreeLODType LODType
		{
			get{ CheckIsValid();return (ESpeedTreeLODType)Marshal.PtrToStructure(_this.Get()+LODType__Offset, typeof(ESpeedTreeLODType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LODType__Offset, false);}
			
		}
		
		static readonly int BillboardThreshold__Offset;
		/// <summary>The threshold for triangles to be removed from the bilboard mesh when not facing the camera (0 = none pass, 1 = all pass).</summary>
		public float BillboardThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BillboardThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BillboardThreshold__Offset, false);}
			
		}
		
		static readonly int bAccurateWindVelocities__Offset;
		/// <summary>Support accurate velocities from wind. This will incur extra cost per vertex.</summary>
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
