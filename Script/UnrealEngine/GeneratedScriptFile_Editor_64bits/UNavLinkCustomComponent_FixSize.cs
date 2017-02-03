#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Encapsulates NavLinkCustomInterface interface, can be used with Actors not relevant for navigation
	/// Additional functionality:
	/// - can be toggled
	/// - can create obstacle area for easier/forced separation of link end points
	/// - can broadcast state changes to nearby agents
	/// </summary>
	public partial class UNavLinkCustomComponent
	{
		static readonly int NavLinkUserId__Offset;
		/// <summary>link Id assigned by navigation system</summary>
		public uint NavLinkUserId
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+NavLinkUserId__Offset, typeof(uint));}
			
		}
		
		static readonly int EnabledAreaClass__Offset;
		/// <summary>area class to use when link is enabled</summary>
		public TSubclassOf<UNavArea>  EnabledAreaClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + EnabledAreaClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + EnabledAreaClass__Offset, value); }
			
		}
		
		static readonly int DisabledAreaClass__Offset;
		/// <summary>area class to use when link is disabled</summary>
		public TSubclassOf<UNavArea>  DisabledAreaClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DisabledAreaClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + DisabledAreaClass__Offset, value); }
			
		}
		
		static readonly int LinkRelativeStart__Offset;
		/// <summary>start point, relative to owner</summary>
		public FVector LinkRelativeStart
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LinkRelativeStart__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LinkRelativeStart__Offset, false);}
			
		}
		
		static readonly int LinkRelativeEnd__Offset;
		/// <summary>end point, relative to owner</summary>
		public FVector LinkRelativeEnd
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LinkRelativeEnd__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LinkRelativeEnd__Offset, false);}
			
		}
		
		static readonly int LinkDirection__Offset;
		/// <summary>direction of link</summary>
		public ENavLinkDirection LinkDirection
		{
			get{ CheckIsValid();return (ENavLinkDirection)Marshal.PtrToStructure(_this.Get()+LinkDirection__Offset, typeof(ENavLinkDirection));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LinkDirection__Offset, false);}
			
		}
		
		static readonly int bLinkEnabled__Offset;
		/// <summary>is link currently in enabled state? (area class)</summary>
		public bool bLinkEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLinkEnabled__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLinkEnabled__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bNotifyWhenEnabled__Offset;
		/// <summary>should link notify nearby agents when it changes state to enabled</summary>
		public bool bNotifyWhenEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNotifyWhenEnabled__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNotifyWhenEnabled__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bNotifyWhenDisabled__Offset;
		/// <summary>should link notify nearby agents when it changes state to disabled</summary>
		public bool bNotifyWhenDisabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNotifyWhenDisabled__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNotifyWhenDisabled__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bCreateBoxObstacle__Offset;
		/// <summary>if set, box obstacle area will be added to generation</summary>
		public bool bCreateBoxObstacle
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCreateBoxObstacle__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCreateBoxObstacle__Offset, 1,0,8,8);}
			
		}
		
		static readonly int ObstacleOffset__Offset;
		/// <summary>offset of simple box obstacle</summary>
		public FVector ObstacleOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+ObstacleOffset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ObstacleOffset__Offset, false);}
			
		}
		
		static readonly int ObstacleExtent__Offset;
		/// <summary>extent of simple box obstacle</summary>
		public FVector ObstacleExtent
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+ObstacleExtent__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ObstacleExtent__Offset, false);}
			
		}
		
		static readonly int ObstacleAreaClass__Offset;
		/// <summary>area class for simple box obstacle</summary>
		public TSubclassOf<UNavArea>  ObstacleAreaClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ObstacleAreaClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + ObstacleAreaClass__Offset, value); }
			
		}
		
		static readonly int BroadcastRadius__Offset;
		/// <summary>radius of state change broadcast</summary>
		public float BroadcastRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BroadcastRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BroadcastRadius__Offset, false);}
			
		}
		
		static readonly int BroadcastInterval__Offset;
		/// <summary>interval for state change broadcast (0 = single broadcast)</summary>
		public float BroadcastInterval
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BroadcastInterval__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BroadcastInterval__Offset, false);}
			
		}
		
		static readonly int BroadcastChannel__Offset;
		/// <summary>trace channel for state change broadcast</summary>
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
