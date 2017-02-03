#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>ShapeComponent is a PrimitiveComponent that is represented by a simple geometrical shape (sphere, capsule, box, etc).</summary>
	public partial class UShapeComponent
	{
		static readonly int ShapeColor__Offset;
		/// <summary>Color used to draw the shape.</summary>
		public FColor ShapeColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+ShapeColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShapeColor__Offset, false);}
			
		}
		
		static readonly int ShapeBodySetup__Offset;
		/// <summary>Description of collision</summary>
		public UBodySetup ShapeBodySetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ShapeBodySetup__Offset); if (v == IntPtr.Zero)return null; UBodySetup retValue = new UBodySetup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bDrawOnlyIfSelected__Offset;
		/// <summary>Only show this component if the actor is selected</summary>
		public bool bDrawOnlyIfSelected
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawOnlyIfSelected__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bShouldCollideWhenPlacing__Offset;
		/// <summary>If true it allows Collision when placing even if collision is not enabled</summary>
		public bool bShouldCollideWhenPlacing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldCollideWhenPlacing__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bDynamicObstacle__Offset;
		/// <summary>If set, shape will be exported for navigation as dynamic modifier instead of using regular collision data</summary>
		public bool bDynamicObstacle
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDynamicObstacle__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDynamicObstacle__Offset, 1,0,4,4);}
			
		}
		
		static readonly int AreaClass__Offset;
		/// <summary>Navigation area type (empty = default obstacle)</summary>
		public TSubclassOf<UNavArea>  AreaClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AreaClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + AreaClass__Offset, value); }
			
		}
		
		static UShapeComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ShapeComponent");
			ShapeColor__Offset=GetPropertyOffset(NativeClassPtr,"ShapeColor");
			ShapeBodySetup__Offset=GetPropertyOffset(NativeClassPtr,"ShapeBodySetup");
			bDrawOnlyIfSelected__Offset=GetPropertyOffset(NativeClassPtr,"bDrawOnlyIfSelected");
			bShouldCollideWhenPlacing__Offset=GetPropertyOffset(NativeClassPtr,"bShouldCollideWhenPlacing");
			bDynamicObstacle__Offset=GetPropertyOffset(NativeClassPtr,"bDynamicObstacle");
			AreaClass__Offset=GetPropertyOffset(NativeClassPtr,"AreaClass");
			
		}
		
	}
	
}
#endif
#endif
