#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNavLinkCustomComponent
	{
		static readonly int NavLinkUserId__Offset;
		public uint NavLinkUserId
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+NavLinkUserId__Offset, typeof(uint));}
			
		}
		
		static readonly int EnabledAreaClass__Offset;
		public TSubclassOf<UNavArea>  EnabledAreaClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + EnabledAreaClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + EnabledAreaClass__Offset, value); }
			
		}
		
		static readonly int DisabledAreaClass__Offset;
		public TSubclassOf<UNavArea>  DisabledAreaClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DisabledAreaClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + DisabledAreaClass__Offset, value); }
			
		}
		
		static readonly int LinkRelativeStart__Offset;
		public FVector LinkRelativeStart
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LinkRelativeStart__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LinkRelativeStart__Offset, false);}
			
		}
		
		static readonly int LinkRelativeEnd__Offset;
		public FVector LinkRelativeEnd
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LinkRelativeEnd__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LinkRelativeEnd__Offset, false);}
			
		}
		
		static readonly int LinkDirection__Offset;
		public ENavLinkDirection LinkDirection
		{
			get{ CheckIsValid();return (ENavLinkDirection)Marshal.PtrToStructure(_this.Get()+LinkDirection__Offset, typeof(ENavLinkDirection));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LinkDirection__Offset, false);}
			
		}
		
		static readonly int bLinkEnabled__Offset;
		public bool bLinkEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLinkEnabled__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLinkEnabled__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bNotifyWhenEnabled__Offset;
		public bool bNotifyWhenEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNotifyWhenEnabled__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNotifyWhenEnabled__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bNotifyWhenDisabled__Offset;
		public bool bNotifyWhenDisabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNotifyWhenDisabled__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNotifyWhenDisabled__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bCreateBoxObstacle__Offset;
		public bool bCreateBoxObstacle
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCreateBoxObstacle__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCreateBoxObstacle__Offset, 1,0,8,8);}
			
		}
		
		static readonly int ObstacleOffset__Offset;
		public FVector ObstacleOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+ObstacleOffset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ObstacleOffset__Offset, false);}
			
		}
		
		static readonly int ObstacleExtent__Offset;
		public FVector ObstacleExtent
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+ObstacleExtent__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ObstacleExtent__Offset, false);}
			
		}
		
		static readonly int ObstacleAreaClass__Offset;
		public TSubclassOf<UNavArea>  ObstacleAreaClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ObstacleAreaClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + ObstacleAreaClass__Offset, value); }
			
		}
		
		static readonly int BroadcastRadius__Offset;
		public float BroadcastRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BroadcastRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BroadcastRadius__Offset, false);}
			
		}
		
		static readonly int BroadcastInterval__Offset;
		public float BroadcastInterval
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BroadcastInterval__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BroadcastInterval__Offset, false);}
			
		}
		
		static readonly int BroadcastChannel__Offset;
		public ECollisionChannel BroadcastChannel
		{
			get{ CheckIsValid();return (ECollisionChannel)Marshal.PtrToStructure(_this.Get()+BroadcastChannel__Offset, typeof(ECollisionChannel));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BroadcastChannel__Offset, false);}
			
		}
		
		static UNavLinkCustomComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavLinkCustomComponent");
			NavLinkUserId__Offset=GetPropertyOffset(NativeClassPtr,"NavLinkUserId");
			EnabledAreaClass__Offset=GetPropertyOffset(NativeClassPtr,"EnabledAreaClass");
			DisabledAreaClass__Offset=GetPropertyOffset(NativeClassPtr,"DisabledAreaClass");
			LinkRelativeStart__Offset=GetPropertyOffset(NativeClassPtr,"LinkRelativeStart");
			LinkRelativeEnd__Offset=GetPropertyOffset(NativeClassPtr,"LinkRelativeEnd");
			LinkDirection__Offset=GetPropertyOffset(NativeClassPtr,"LinkDirection");
			bLinkEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bLinkEnabled");
			bNotifyWhenEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bNotifyWhenEnabled");
			bNotifyWhenDisabled__Offset=GetPropertyOffset(NativeClassPtr,"bNotifyWhenDisabled");
			bCreateBoxObstacle__Offset=GetPropertyOffset(NativeClassPtr,"bCreateBoxObstacle");
			ObstacleOffset__Offset=GetPropertyOffset(NativeClassPtr,"ObstacleOffset");
			ObstacleExtent__Offset=GetPropertyOffset(NativeClassPtr,"ObstacleExtent");
			ObstacleAreaClass__Offset=GetPropertyOffset(NativeClassPtr,"ObstacleAreaClass");
			BroadcastRadius__Offset=GetPropertyOffset(NativeClassPtr,"BroadcastRadius");
			BroadcastInterval__Offset=GetPropertyOffset(NativeClassPtr,"BroadcastInterval");
			BroadcastChannel__Offset=GetPropertyOffset(NativeClassPtr,"BroadcastChannel");
			
		}
		
	}
	
}
#endif
#endif
