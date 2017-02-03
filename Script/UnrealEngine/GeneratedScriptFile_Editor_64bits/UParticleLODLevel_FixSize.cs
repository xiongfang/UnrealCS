#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleLODLevel
	{
		static readonly int Level__Offset;
		/// <summary>The index value of the LOD level</summary>
		public int Level
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Level__Offset, typeof(int));}
			
		}
		
		static readonly int bEnabled__Offset;
		/// <summary>True if the LOD level is enabled, meaning it should be updated and rendered.</summary>
		public bool bEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnabled__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int RequiredModule__Offset;
		/// <summary>The required module for this LOD level</summary>
		public UParticleModuleRequired RequiredModule
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + RequiredModule__Offset); if (v == IntPtr.Zero)return null; UParticleModuleRequired retValue = new UParticleModuleRequired(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Modules__Offset;
		/// <summary>An array of particle modules that contain the adjusted data for the LOD level</summary>
		public TObjectArray<UParticleModule>  Modules
		{
					get{ CheckIsValid();return new TObjectArray<UParticleModule>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Modules__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Modules__Offset, false);}
			
		}
		
		static readonly int TypeDataModule__Offset;
		/// <summary>Module<SINGULAR> used for emitter type "extension".</summary>
		public UParticleModuleTypeDataBase TypeDataModule
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TypeDataModule__Offset); if (v == IntPtr.Zero)return null; UParticleModuleTypeDataBase retValue = new UParticleModuleTypeDataBase(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SpawnModule__Offset;
		/// <summary>The SpawnRate/Burst module - required by all emitters.</summary>
		public UParticleModuleSpawn SpawnModule
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpawnModule__Offset); if (v == IntPtr.Zero)return null; UParticleModuleSpawn retValue = new UParticleModuleSpawn(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int EventGenerator__Offset;
		/// <summary>The optional EventGenerator module.</summary>
		public UParticleModuleEventGenerator EventGenerator
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + EventGenerator__Offset); if (v == IntPtr.Zero)return null; UParticleModuleEventGenerator retValue = new UParticleModuleEventGenerator(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SpawningModules__Offset;
		/// <summary>SpawningModules - These are called to determine how many particles to spawn.</summary>
		public TObjectArray<UParticleModuleSpawnBase>  SpawningModules
		{
					get{ CheckIsValid();return new TObjectArray<UParticleModuleSpawnBase>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SpawningModules__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SpawningModules__Offset, false);}
			
		}
		
		static readonly int SpawnModules__Offset;
		/// <summary>SpawnModules - These are called when particles are spawned.</summary>
		public TObjectArray<UParticleModule>  SpawnModules
		{
					get{ CheckIsValid();return new TObjectArray<UParticleModule>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SpawnModules__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SpawnModules__Offset, false);}
			
		}
		
		static readonly int UpdateModules__Offset;
		/// <summary>UpdateModules - These are called when particles are updated.</summary>
		public TObjectArray<UParticleModule>  UpdateModules
		{
					get{ CheckIsValid();return new TObjectArray<UParticleModule>((FScriptArray)Marshal.PtrToStructure(_this.Get()+UpdateModules__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+UpdateModules__Offset, false);}
			
		}
		
		static readonly int OrbitModules__Offset;
		/// <summary>
		/// OrbitModules
		///     These are used to do offsets of the sprite from the particle location.
		/// </summary>
		public TObjectArray<UParticleModuleOrbit>  OrbitModules
		{
					get{ CheckIsValid();return new TObjectArray<UParticleModuleOrbit>((FScriptArray)Marshal.PtrToStructure(_this.Get()+OrbitModules__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+OrbitModules__Offset, false);}
			
		}
		
		static readonly int EventReceiverModules__Offset;
		/// <summary>Event receiver modules only!</summary>
		public TObjectArray<UParticleModuleEventReceiverBase>  EventReceiverModules
		{
					get{ CheckIsValid();return new TObjectArray<UParticleModuleEventReceiverBase>((FScriptArray)Marshal.PtrToStructure(_this.Get()+EventReceiverModules__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+EventReceiverModules__Offset, false);}
			
		}
		
		static readonly int ConvertedModules__Offset;
		public bool ConvertedModules
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), ConvertedModules__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int PeakActiveParticles__Offset;
		public int PeakActiveParticles
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PeakActiveParticles__Offset, typeof(int));}
			
		}
		
		static UParticleLODLevel()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleLODLevel");
			Level__Offset=GetPropertyOffset(NativeClassPtr,"Level");
			bEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bEnabled");
			RequiredModule__Offset=GetPropertyOffset(NativeClassPtr,"RequiredModule");
			Modules__Offset=GetPropertyOffset(NativeClassPtr,"Modules");
			TypeDataModule__Offset=GetPropertyOffset(NativeClassPtr,"TypeDataModule");
			SpawnModule__Offset=GetPropertyOffset(NativeClassPtr,"SpawnModule");
			EventGenerator__Offset=GetPropertyOffset(NativeClassPtr,"EventGenerator");
			SpawningModules__Offset=GetPropertyOffset(NativeClassPtr,"SpawningModules");
			SpawnModules__Offset=GetPropertyOffset(NativeClassPtr,"SpawnModules");
			UpdateModules__Offset=GetPropertyOffset(NativeClassPtr,"UpdateModules");
			OrbitModules__Offset=GetPropertyOffset(NativeClassPtr,"OrbitModules");
			EventReceiverModules__Offset=GetPropertyOffset(NativeClassPtr,"EventReceiverModules");
			ConvertedModules__Offset=GetPropertyOffset(NativeClassPtr,"ConvertedModules");
			PeakActiveParticles__Offset=GetPropertyOffset(NativeClassPtr,"PeakActiveParticles");
			
		}
		
	}
	
}
#endif
#endif
