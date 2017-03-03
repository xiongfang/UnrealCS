#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// StaticMeshActor is an instance of a UStaticMesh in the world.
	/// Static meshes are geometry that do not animate or otherwise deform, and are more efficient to render than other types of geometry.
	/// Static meshes dragged into the level from the Content Browser are automatically converted to StaticMeshActors.
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Actors/StaticMeshActor/
	/// @see UStaticMesh
	/// </summary>
	public partial class AStaticMeshActor
	{
		static readonly int StaticMeshComponent__Offset;
		public UStaticMeshComponent StaticMeshComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + StaticMeshComponent__Offset); if (v == IntPtr.Zero)return null; UStaticMeshComponent retValue = new UStaticMeshComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + StaticMeshComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + StaticMeshComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int bStaticMeshReplicateMovement__Offset;
		/// <summary>This static mesh should replicate movement. Automatically sets the RemoteRole and bReplicateMovement flags. Meant to be edited on placed actors (those other two properties are not)</summary>
		public bool bStaticMeshReplicateMovement
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStaticMeshReplicateMovement__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bStaticMeshReplicateMovement__Offset, 1,0,1,255);}
			
		}
		
		static AStaticMeshActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("StaticMeshActor");
			StaticMeshComponent__Offset=GetPropertyOffset(NativeClassPtr,"StaticMeshComponent");
			bStaticMeshReplicateMovement__Offset=GetPropertyOffset(NativeClassPtr,"bStaticMeshReplicateMovement");
			
		}
		
	}
	
}
#endif
#endif
