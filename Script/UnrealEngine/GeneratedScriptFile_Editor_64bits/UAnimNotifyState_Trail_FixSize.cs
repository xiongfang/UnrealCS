#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimNotifyState_Trail
	{
		static readonly int PSTemplate__Offset;
		/// <summary>The particle system to use for this trail.</summary>
		public UParticleSystem PSTemplate
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PSTemplate__Offset); if (v == IntPtr.Zero)return null; UParticleSystem retValue = new UParticleSystem(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PSTemplate__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PSTemplate__Offset, value._this.Get()); }
			
		}
		
		static readonly int FirstSocketName__Offset;
		/// <summary>Name of the first socket defining this trail.</summary>
		public FName FirstSocketName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+FirstSocketName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FirstSocketName__Offset, false);}
			
		}
		
		static readonly int SecondSocketName__Offset;
		/// <summary>Name of the second socket defining this trail.</summary>
		public FName SecondSocketName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SecondSocketName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SecondSocketName__Offset, false);}
			
		}
		
		static readonly int WidthScaleMode__Offset;
		/// <summary>
		/// Controls the way width scale is applied. In each method a width scale of 1.0 will mean the width is unchanged from the position of the sockets. A width scale of 0.0 will cause a trail of zero width.
		/// From Centre = Trail width is scaled outwards from the centre point between the two sockets.
		/// From First = Trail width is scaled outwards from the position of the first socket.
		/// From Second = Trail width is scaled outwards from the position of the Second socket.
		/// </summary>
		public ETrailWidthMode WidthScaleMode
		{
			get{ CheckIsValid();return (ETrailWidthMode)Marshal.PtrToStructure(_this.Get()+WidthScaleMode__Offset, typeof(ETrailWidthMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidthScaleMode__Offset, false);}
			
		}
		
		static readonly int WidthScaleCurve__Offset;
		/// <summary>Name of the curve to drive the width scale.</summary>
		public FName WidthScaleCurve
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+WidthScaleCurve__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidthScaleCurve__Offset, false);}
			
		}
		
		static readonly int bRecycleSpawnedSystems__Offset;
		public bool bRecycleSpawnedSystems
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRecycleSpawnedSystems__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRecycleSpawnedSystems__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bRenderGeometry__Offset;
		/// <summary>If true, render the trail geometry (this should typically be on)</summary>
		public bool bRenderGeometry
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderGeometry__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderGeometry__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bRenderSpawnPoints__Offset;
		/// <summary>If true, render stars at each spawned particle point along the trail</summary>
		public bool bRenderSpawnPoints
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderSpawnPoints__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderSpawnPoints__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bRenderTangents__Offset;
		/// <summary>If true, render a line showing the tangent at each spawned particle point along the trail</summary>
		public bool bRenderTangents
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderTangents__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderTangents__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bRenderTessellation__Offset;
		/// <summary>If true, render the tessellated path between spawned particles</summary>
		public bool bRenderTessellation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderTessellation__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderTessellation__Offset, 1,0,16,16);}
			
		}
		
		static UAnimNotifyState_Trail()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimNotifyState_Trail");
			PSTemplate__Offset=GetPropertyOffset(NativeClassPtr,"PSTemplate");
			FirstSocketName__Offset=GetPropertyOffset(NativeClassPtr,"FirstSocketName");
			SecondSocketName__Offset=GetPropertyOffset(NativeClassPtr,"SecondSocketName");
			WidthScaleMode__Offset=GetPropertyOffset(NativeClassPtr,"WidthScaleMode");
			WidthScaleCurve__Offset=GetPropertyOffset(NativeClassPtr,"WidthScaleCurve");
			bRecycleSpawnedSystems__Offset=GetPropertyOffset(NativeClassPtr,"bRecycleSpawnedSystems");
			bRenderGeometry__Offset=GetPropertyOffset(NativeClassPtr,"bRenderGeometry");
			bRenderSpawnPoints__Offset=GetPropertyOffset(NativeClassPtr,"bRenderSpawnPoints");
			bRenderTangents__Offset=GetPropertyOffset(NativeClassPtr,"bRenderTangents");
			bRenderTessellation__Offset=GetPropertyOffset(NativeClassPtr,"bRenderTessellation");
			
		}
		
	}
	
}
#endif
#endif
