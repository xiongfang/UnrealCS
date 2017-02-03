#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModule
	{
		static readonly int bSpawnModule__Offset;
		/// <summary>If true, the module performs operations on particles during Spawning</summary>
		public bool bSpawnModule
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSpawnModule__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bUpdateModule__Offset;
		/// <summary>If true, the module performs operations on particles during Updating</summary>
		public bool bUpdateModule
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUpdateModule__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bFinalUpdateModule__Offset;
		/// <summary>If true, the module performs operations on particles during final update</summary>
		public bool bFinalUpdateModule
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFinalUpdateModule__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bUpdateForGPUEmitter__Offset;
		/// <summary>If true, the module performs operations on particles during update and/or final update for GPU emitters</summary>
		public bool bUpdateForGPUEmitter
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUpdateForGPUEmitter__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bCurvesAsColor__Offset;
		/// <summary>If true, the module displays FVector curves as colors</summary>
		public bool bCurvesAsColor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCurvesAsColor__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int b3DDrawMode__Offset;
		/// <summary>If true, the module should render its 3D visualization helper</summary>
		public bool b3DDrawMode
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), b3DDrawMode__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), b3DDrawMode__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bSupported3DDrawMode__Offset;
		/// <summary>If true, the module supports rendering a 3D visualization helper</summary>
		public bool bSupported3DDrawMode
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupported3DDrawMode__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bEnabled__Offset;
		/// <summary>If true, the module is enabled</summary>
		public bool bEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnabled__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int bEditable__Offset;
		/// <summary>If true, the module has had editing enabled on it</summary>
		public bool bEditable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEditable__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int LODDuplicate__Offset;
		/// <summary>
		/// If true, this flag indicates that auto-generation for LOD will result in
		/// an exact duplicate of the module, regardless of the percentage.
		/// If false, it will result in a module with different settings.
		/// </summary>
		public bool LODDuplicate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), LODDuplicate__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bSupportsRandomSeed__Offset;
		/// <summary>If true, the module supports RandomSeed setting</summary>
		public bool bSupportsRandomSeed
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsRandomSeed__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bRequiresLoopingNotification__Offset;
		/// <summary>If true, the module should be told when looping</summary>
		public bool bRequiresLoopingNotification
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRequiresLoopingNotification__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int LODValidity__Offset;
		/// <summary>
		/// The LOD levels this module is present in.
		/// Bit-flags are used to indicate validity for a given LOD level.
		/// For example, if
		///         ((1 << Level) & LODValidity) != 0
		/// then the module is used in that LOD.
		/// </summary>
		public byte LODValidity
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+LODValidity__Offset, typeof(byte));}
			
		}
		
		static readonly int ModuleEditorColor__Offset;
		/// <summary>
		/// The color to draw the modules curves in the curve editor.
		///     If bCurvesAsColor is true, it overrides this value.
		/// </summary>
		public FColor ModuleEditorColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+ModuleEditorColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ModuleEditorColor__Offset, false);}
			
		}
		
		static UParticleModule()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModule");
			bSpawnModule__Offset=GetPropertyOffset(NativeClassPtr,"bSpawnModule");
			bUpdateModule__Offset=GetPropertyOffset(NativeClassPtr,"bUpdateModule");
			bFinalUpdateModule__Offset=GetPropertyOffset(NativeClassPtr,"bFinalUpdateModule");
			bUpdateForGPUEmitter__Offset=GetPropertyOffset(NativeClassPtr,"bUpdateForGPUEmitter");
			bCurvesAsColor__Offset=GetPropertyOffset(NativeClassPtr,"bCurvesAsColor");
			b3DDrawMode__Offset=GetPropertyOffset(NativeClassPtr,"b3DDrawMode");
			bSupported3DDrawMode__Offset=GetPropertyOffset(NativeClassPtr,"bSupported3DDrawMode");
			bEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bEnabled");
			bEditable__Offset=GetPropertyOffset(NativeClassPtr,"bEditable");
			LODDuplicate__Offset=GetPropertyOffset(NativeClassPtr,"LODDuplicate");
			bSupportsRandomSeed__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsRandomSeed");
			bRequiresLoopingNotification__Offset=GetPropertyOffset(NativeClassPtr,"bRequiresLoopingNotification");
			LODValidity__Offset=GetPropertyOffset(NativeClassPtr,"LODValidity");
			ModuleEditorColor__Offset=GetPropertyOffset(NativeClassPtr,"ModuleEditorColor");
			
		}
		
	}
	
}
#endif
#endif
