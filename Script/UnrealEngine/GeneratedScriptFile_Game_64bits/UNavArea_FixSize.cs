#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNavArea
	{
		static readonly int DefaultCost__Offset;
		public float DefaultCost
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultCost__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultCost__Offset, false);}
			
		}
		
		static readonly int FixedAreaEnteringCost__Offset;
		public float FixedAreaEnteringCost
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FixedAreaEnteringCost__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FixedAreaEnteringCost__Offset, false);}
			
		}
		
		static readonly int DrawColor__Offset;
		public FColor DrawColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+DrawColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DrawColor__Offset, false);}
			
		}
		
		static readonly int SupportedAgents__Offset;
		public FNavAgentSelector SupportedAgents
		{
			get{ CheckIsValid();return (FNavAgentSelector)Marshal.PtrToStructure(_this.Get()+SupportedAgents__Offset, typeof(FNavAgentSelector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SupportedAgents__Offset, false);}
			
		}
		
		static readonly int bSupportsAgent0__Offset;
		public bool bSupportsAgent0
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsAgent0__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bSupportsAgent1__Offset;
		public bool bSupportsAgent1
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsAgent1__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bSupportsAgent2__Offset;
		public bool bSupportsAgent2
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsAgent2__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bSupportsAgent3__Offset;
		public bool bSupportsAgent3
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsAgent3__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bSupportsAgent4__Offset;
		public bool bSupportsAgent4
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsAgent4__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bSupportsAgent5__Offset;
		public bool bSupportsAgent5
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsAgent5__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bSupportsAgent6__Offset;
		public bool bSupportsAgent6
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsAgent6__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bSupportsAgent7__Offset;
		public bool bSupportsAgent7
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsAgent7__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int bSupportsAgent8__Offset;
		public bool bSupportsAgent8
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsAgent8__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bSupportsAgent9__Offset;
		public bool bSupportsAgent9
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsAgent9__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bSupportsAgent10__Offset;
		public bool bSupportsAgent10
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsAgent10__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bSupportsAgent11__Offset;
		public bool bSupportsAgent11
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsAgent11__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bSupportsAgent12__Offset;
		public bool bSupportsAgent12
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsAgent12__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bSupportsAgent13__Offset;
		public bool bSupportsAgent13
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsAgent13__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bSupportsAgent14__Offset;
		public bool bSupportsAgent14
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsAgent14__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bSupportsAgent15__Offset;
		public bool bSupportsAgent15
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsAgent15__Offset, 1, 0, 128, 128);}
			
		}
		
		static UNavArea()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavArea");
			DefaultCost__Offset=GetPropertyOffset(NativeClassPtr,"DefaultCost");
			FixedAreaEnteringCost__Offset=GetPropertyOffset(NativeClassPtr,"FixedAreaEnteringCost");
			DrawColor__Offset=GetPropertyOffset(NativeClassPtr,"DrawColor");
			SupportedAgents__Offset=GetPropertyOffset(NativeClassPtr,"SupportedAgents");
			bSupportsAgent0__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsAgent0");
			bSupportsAgent1__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsAgent1");
			bSupportsAgent2__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsAgent2");
			bSupportsAgent3__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsAgent3");
			bSupportsAgent4__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsAgent4");
			bSupportsAgent5__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsAgent5");
			bSupportsAgent6__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsAgent6");
			bSupportsAgent7__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsAgent7");
			bSupportsAgent8__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsAgent8");
			bSupportsAgent9__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsAgent9");
			bSupportsAgent10__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsAgent10");
			bSupportsAgent11__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsAgent11");
			bSupportsAgent12__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsAgent12");
			bSupportsAgent13__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsAgent13");
			bSupportsAgent14__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsAgent14");
			bSupportsAgent15__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsAgent15");
			
		}
		
	}
	
}
#endif
#endif
