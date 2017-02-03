#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPhysicsAsset
	{
		static readonly int BoundsBodies__Offset;
		public TStructArray<int> BoundsBodies
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BoundsBodies__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BoundsBodies__Offset, false);}
			
		}
		
		static readonly int SkeletalBodySetups__Offset;
		public TObjectArray<USkeletalBodySetup>  SkeletalBodySetups
		{
					get{ CheckIsValid();return new TObjectArray<USkeletalBodySetup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SkeletalBodySetups__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SkeletalBodySetups__Offset, false);}
			
		}
		
		static readonly int ConstraintSetup__Offset;
		public TObjectArray<UPhysicsConstraintTemplate>  ConstraintSetup
		{
					get{ CheckIsValid();return new TObjectArray<UPhysicsConstraintTemplate>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ConstraintSetup__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ConstraintSetup__Offset, false);}
			
		}
		
		static readonly int bUseAsyncScene__Offset;
		public bool bUseAsyncScene
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseAsyncScene__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseAsyncScene__Offset, 1,0,1,1);}
			
		}
		
		static readonly int BodySetup__Offset;
		public TObjectArray<UBodySetup>  BodySetup
		{
					get{ CheckIsValid();return new TObjectArray<UBodySetup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BodySetup__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BodySetup__Offset, false);}
			
		}
		
		static UPhysicsAsset()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PhysicsAsset");
			BoundsBodies__Offset=GetPropertyOffset(NativeClassPtr,"BoundsBodies");
			SkeletalBodySetups__Offset=GetPropertyOffset(NativeClassPtr,"SkeletalBodySetups");
			ConstraintSetup__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintSetup");
			bUseAsyncScene__Offset=GetPropertyOffset(NativeClassPtr,"bUseAsyncScene");
			BodySetup__Offset=GetPropertyOffset(NativeClassPtr,"BodySetup");
			
		}
		
	}
	
}
#endif
#endif
