#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationBoneSocket
	{
		static readonly int SourceType__Offset;
		public ELocationBoneSocketSource SourceType
		{
			get{ CheckIsValid();return (ELocationBoneSocketSource)Marshal.PtrToStructure(_this.Get()+SourceType__Offset, typeof(ELocationBoneSocketSource));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceType__Offset, false);}
			
		}
		
		static readonly int UniversalOffset__Offset;
		public FVector UniversalOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+UniversalOffset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UniversalOffset__Offset, false);}
			
		}
		
		static readonly int SourceLocations__Offset;
		public TStructArray<FLocationBoneSocketInfo> SourceLocations
		{
			get{ CheckIsValid();return new TStructArray<FLocationBoneSocketInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SourceLocations__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SourceLocations__Offset, false);}
			
		}
		
		static readonly int SelectionMethod__Offset;
		public ELocationBoneSocketSelectionMethod SelectionMethod
		{
			get{ CheckIsValid();return (ELocationBoneSocketSelectionMethod)Marshal.PtrToStructure(_this.Get()+SelectionMethod__Offset, typeof(ELocationBoneSocketSelectionMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SelectionMethod__Offset, false);}
			
		}
		
		static readonly int bUpdatePositionEachFrame__Offset;
		public bool bUpdatePositionEachFrame
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUpdatePositionEachFrame__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUpdatePositionEachFrame__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOrientMeshEmitters__Offset;
		public bool bOrientMeshEmitters
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOrientMeshEmitters__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOrientMeshEmitters__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bInheritBoneVelocity__Offset;
		public bool bInheritBoneVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInheritBoneVelocity__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInheritBoneVelocity__Offset, 1,0,4,4);}
			
		}
		
		static readonly int InheritVelocityScale__Offset;
		public float InheritVelocityScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InheritVelocityScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InheritVelocityScale__Offset, false);}
			
		}
		
		static readonly int SkelMeshActorParamName__Offset;
		public FName SkelMeshActorParamName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SkelMeshActorParamName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SkelMeshActorParamName__Offset, false);}
			
		}
		
		static readonly int NumPreSelectedIndices__Offset;
		public int NumPreSelectedIndices
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumPreSelectedIndices__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NumPreSelectedIndices__Offset, false);}
			
		}
		
		static UParticleModuleLocationBoneSocket()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleLocationBoneSocket");
			SourceType__Offset=GetPropertyOffset(NativeClassPtr,"SourceType");
			UniversalOffset__Offset=GetPropertyOffset(NativeClassPtr,"UniversalOffset");
			SourceLocations__Offset=GetPropertyOffset(NativeClassPtr,"SourceLocations");
			SelectionMethod__Offset=GetPropertyOffset(NativeClassPtr,"SelectionMethod");
			bUpdatePositionEachFrame__Offset=GetPropertyOffset(NativeClassPtr,"bUpdatePositionEachFrame");
			bOrientMeshEmitters__Offset=GetPropertyOffset(NativeClassPtr,"bOrientMeshEmitters");
			bInheritBoneVelocity__Offset=GetPropertyOffset(NativeClassPtr,"bInheritBoneVelocity");
			InheritVelocityScale__Offset=GetPropertyOffset(NativeClassPtr,"InheritVelocityScale");
			SkelMeshActorParamName__Offset=GetPropertyOffset(NativeClassPtr,"SkelMeshActorParamName");
			NumPreSelectedIndices__Offset=GetPropertyOffset(NativeClassPtr,"NumPreSelectedIndices");
			
		}
		
	}
	
}
#endif
#endif
