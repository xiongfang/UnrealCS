#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPhysicalMaterial
	{
		static readonly int Friction__Offset;
		public float Friction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Friction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Friction__Offset, false);}
			
		}
		
		static readonly int FrictionCombineMode__Offset;
		public EFrictionCombineMode FrictionCombineMode
		{
			get{ CheckIsValid();return (EFrictionCombineMode)Marshal.PtrToStructure(_this.Get()+FrictionCombineMode__Offset, typeof(EFrictionCombineMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FrictionCombineMode__Offset, false);}
			
		}
		
		static readonly int bOverrideFrictionCombineMode__Offset;
		public bool bOverrideFrictionCombineMode
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideFrictionCombineMode__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideFrictionCombineMode__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Restitution__Offset;
		public float Restitution
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Restitution__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Restitution__Offset, false);}
			
		}
		
		static readonly int RestitutionCombineMode__Offset;
		public EFrictionCombineMode RestitutionCombineMode
		{
			get{ CheckIsValid();return (EFrictionCombineMode)Marshal.PtrToStructure(_this.Get()+RestitutionCombineMode__Offset, typeof(EFrictionCombineMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RestitutionCombineMode__Offset, false);}
			
		}
		
		static readonly int bOverrideRestitutionCombineMode__Offset;
		public bool bOverrideRestitutionCombineMode
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideRestitutionCombineMode__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideRestitutionCombineMode__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Density__Offset;
		public float Density
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Density__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Density__Offset, false);}
			
		}
		
		static readonly int RaiseMassToPower__Offset;
		public float RaiseMassToPower
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RaiseMassToPower__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RaiseMassToPower__Offset, false);}
			
		}
		
		static readonly int DestructibleDamageThresholdScale__Offset;
		public float DestructibleDamageThresholdScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DestructibleDamageThresholdScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DestructibleDamageThresholdScale__Offset, false);}
			
		}
		
		static readonly int PhysicalMaterialProperty__Offset;
		public UDEPRECATED_PhysicalMaterialPropertyBase PhysicalMaterialProperty
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PhysicalMaterialProperty__Offset); if (v == IntPtr.Zero)return null; UDEPRECATED_PhysicalMaterialPropertyBase retValue = new UDEPRECATED_PhysicalMaterialPropertyBase(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SurfaceType__Offset;
		public EPhysicalSurface SurfaceType
		{
			get{ CheckIsValid();return (EPhysicalSurface)Marshal.PtrToStructure(_this.Get()+SurfaceType__Offset, typeof(EPhysicalSurface));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SurfaceType__Offset, false);}
			
		}
		
		static readonly int TireFrictionScale__Offset;
		public float TireFrictionScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TireFrictionScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TireFrictionScale__Offset, false);}
			
		}
		
		static readonly int TireFrictionScales__Offset;
		public TStructArray<FTireFrictionScalePair> TireFrictionScales
		{
			get{ CheckIsValid();return new TStructArray<FTireFrictionScalePair>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TireFrictionScales__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TireFrictionScales__Offset, false);}
			
		}
		
		static UPhysicalMaterial()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PhysicalMaterial");
			Friction__Offset=GetPropertyOffset(NativeClassPtr,"Friction");
			FrictionCombineMode__Offset=GetPropertyOffset(NativeClassPtr,"FrictionCombineMode");
			bOverrideFrictionCombineMode__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideFrictionCombineMode");
			Restitution__Offset=GetPropertyOffset(NativeClassPtr,"Restitution");
			RestitutionCombineMode__Offset=GetPropertyOffset(NativeClassPtr,"RestitutionCombineMode");
			bOverrideRestitutionCombineMode__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideRestitutionCombineMode");
			Density__Offset=GetPropertyOffset(NativeClassPtr,"Density");
			RaiseMassToPower__Offset=GetPropertyOffset(NativeClassPtr,"RaiseMassToPower");
			DestructibleDamageThresholdScale__Offset=GetPropertyOffset(NativeClassPtr,"DestructibleDamageThresholdScale");
			PhysicalMaterialProperty__Offset=GetPropertyOffset(NativeClassPtr,"PhysicalMaterialProperty");
			SurfaceType__Offset=GetPropertyOffset(NativeClassPtr,"SurfaceType");
			TireFrictionScale__Offset=GetPropertyOffset(NativeClassPtr,"TireFrictionScale");
			TireFrictionScales__Offset=GetPropertyOffset(NativeClassPtr,"TireFrictionScales");
			
		}
		
	}
	
}
#endif
#endif
