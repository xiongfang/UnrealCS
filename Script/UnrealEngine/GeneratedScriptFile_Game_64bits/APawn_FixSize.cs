#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class APawn
	{
		static readonly int bUseControllerRotationPitch__Offset;
		public bool bUseControllerRotationPitch
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseControllerRotationPitch__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseControllerRotationPitch__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bUseControllerRotationYaw__Offset;
		public bool bUseControllerRotationYaw
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseControllerRotationYaw__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseControllerRotationYaw__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bUseControllerRotationRoll__Offset;
		public bool bUseControllerRotationRoll
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseControllerRotationRoll__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseControllerRotationRoll__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bCanAffectNavigationGeneration__Offset;
		public bool bCanAffectNavigationGeneration
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanAffectNavigationGeneration__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCanAffectNavigationGeneration__Offset, 1,0,8,8);}
			
		}
		
		static readonly int BaseEyeHeight__Offset;
		public float BaseEyeHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BaseEyeHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BaseEyeHeight__Offset, false);}
			
		}
		
		static readonly int AutoPossessPlayer__Offset;
		public EAutoReceiveInput AutoPossessPlayer
		{
			get{ CheckIsValid();return (EAutoReceiveInput)Marshal.PtrToStructure(_this.Get()+AutoPossessPlayer__Offset, typeof(EAutoReceiveInput));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AutoPossessPlayer__Offset, false);}
			
		}
		
		static readonly int AIControllerClass__Offset;
		public TSubclassOf<AController>  AIControllerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AIControllerClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + AIControllerClass__Offset, value); }
			
		}
		
		static readonly int PlayerState__Offset;
		public APlayerState PlayerState
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerState__Offset); if (v == IntPtr.Zero)return null; APlayerState retValue = new APlayerState(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int RemoteViewPitch__Offset;
		public byte RemoteViewPitch
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+RemoteViewPitch__Offset, typeof(byte));}
			
		}
		
		static readonly int LastHitBy__Offset;
		public AController LastHitBy
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LastHitBy__Offset); if (v == IntPtr.Zero)return null; AController retValue = new AController(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Controller__Offset;
		public AController Controller
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Controller__Offset); if (v == IntPtr.Zero)return null; AController retValue = new AController(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ControlInputVector__Offset;
		public FVector ControlInputVector
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+ControlInputVector__Offset, typeof(FVector));}
			
		}
		
		static readonly int LastControlInputVector__Offset;
		public FVector LastControlInputVector
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LastControlInputVector__Offset, typeof(FVector));}
			
		}
		
		static APawn()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Pawn");
			bUseControllerRotationPitch__Offset=GetPropertyOffset(NativeClassPtr,"bUseControllerRotationPitch");
			bUseControllerRotationYaw__Offset=GetPropertyOffset(NativeClassPtr,"bUseControllerRotationYaw");
			bUseControllerRotationRoll__Offset=GetPropertyOffset(NativeClassPtr,"bUseControllerRotationRoll");
			bCanAffectNavigationGeneration__Offset=GetPropertyOffset(NativeClassPtr,"bCanAffectNavigationGeneration");
			BaseEyeHeight__Offset=GetPropertyOffset(NativeClassPtr,"BaseEyeHeight");
			AutoPossessPlayer__Offset=GetPropertyOffset(NativeClassPtr,"AutoPossessPlayer");
			AIControllerClass__Offset=GetPropertyOffset(NativeClassPtr,"AIControllerClass");
			PlayerState__Offset=GetPropertyOffset(NativeClassPtr,"PlayerState");
			RemoteViewPitch__Offset=GetPropertyOffset(NativeClassPtr,"RemoteViewPitch");
			LastHitBy__Offset=GetPropertyOffset(NativeClassPtr,"LastHitBy");
			Controller__Offset=GetPropertyOffset(NativeClassPtr,"Controller");
			ControlInputVector__Offset=GetPropertyOffset(NativeClassPtr,"ControlInputVector");
			LastControlInputVector__Offset=GetPropertyOffset(NativeClassPtr,"LastControlInputVector");
			
		}
		
	}
	
}
#endif
#endif
