#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AController
	{
		static readonly int Pawn__Offset;
		public APawn Pawn
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Pawn__Offset); if (v == IntPtr.Zero)return null; APawn retValue = new APawn(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Character__Offset;
		public ACharacter Character
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Character__Offset); if (v == IntPtr.Zero)return null; ACharacter retValue = new ACharacter(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PlayerState__Offset;
		public APlayerState PlayerState
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerState__Offset); if (v == IntPtr.Zero)return null; APlayerState retValue = new APlayerState(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int TransformComponent__Offset;
		public USceneComponent TransformComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TransformComponent__Offset); if (v == IntPtr.Zero)return null; USceneComponent retValue = new USceneComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ControlRotation__Offset;
		public FRotator ControlRotation
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+ControlRotation__Offset, typeof(FRotator));}
			
		}
		
		static readonly int bAttachToPawn__Offset;
		public bool bAttachToPawn
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAttachToPawn__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAttachToPawn__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bIsPlayerController__Offset;
		public bool bIsPlayerController
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsPlayerController__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int StateName__Offset;
		public FName StateName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+StateName__Offset, typeof(FName));}
			
		}
		
		static readonly int OnInstigatedAnyDamage__Offset;
		public FMulticastScriptDelegate OnInstigatedAnyDamage
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnInstigatedAnyDamage__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnInstigatedAnyDamage__Offset, false);}
			
		}
		
		static AController()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Controller");
			Pawn__Offset=GetPropertyOffset(NativeClassPtr,"Pawn");
			Character__Offset=GetPropertyOffset(NativeClassPtr,"Character");
			PlayerState__Offset=GetPropertyOffset(NativeClassPtr,"PlayerState");
			TransformComponent__Offset=GetPropertyOffset(NativeClassPtr,"TransformComponent");
			ControlRotation__Offset=GetPropertyOffset(NativeClassPtr,"ControlRotation");
			bAttachToPawn__Offset=GetPropertyOffset(NativeClassPtr,"bAttachToPawn");
			bIsPlayerController__Offset=GetPropertyOffset(NativeClassPtr,"bIsPlayerController");
			StateName__Offset=GetPropertyOffset(NativeClassPtr,"StateName");
			OnInstigatedAnyDamage__Offset=GetPropertyOffset(NativeClassPtr,"OnInstigatedAnyDamage");
			
		}
		
	}
	
}
#endif
#endif
