#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Physical materials are used to define the response of a physical object when interacting dynamically with the world.</summary>
	public partial class UPhysicalMaterial
	{
		static readonly int Friction__Offset;
		/// <summary>Friction value of surface, controls how easily things can slide on this surface</summary>
		public float Friction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Friction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Friction__Offset, false);}
			
		}
		
		static readonly int FrictionCombineMode__Offset;
		/// <summary>Friction combine mode, controls how friction is computed for multiple materials.</summary>
		public EFrictionCombineMode FrictionCombineMode
		{
			get{ CheckIsValid();return (EFrictionCombineMode)Marshal.PtrToStructure(_this.Get()+FrictionCombineMode__Offset, typeof(EFrictionCombineMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FrictionCombineMode__Offset, false);}
			
		}
		
		static readonly int bOverrideFrictionCombineMode__Offset;
		/// <summary>If set we will use the FrictionCombineMode of this material, instead of the FrictionCombineMode found in the project settings.</summary>
		public bool bOverrideFrictionCombineMode
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideFrictionCombineMode__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideFrictionCombineMode__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Restitution__Offset;
		/// <summary>Restitution or 'bounciness' of this surface, between 0 (no bounce) and 1 (outgoing velocity is same as incoming).</summary>
		public float Restitution
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Restitution__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Restitution__Offset, false);}
			
		}
		
		static readonly int RestitutionCombineMode__Offset;
		/// <summary>Restitution combine mode, controls how restitution is computed for multiple materials.</summary>
		public EFrictionCombineMode RestitutionCombineMode
		{
			get{ CheckIsValid();return (EFrictionCombineMode)Marshal.PtrToStructure(_this.Get()+RestitutionCombineMode__Offset, typeof(EFrictionCombineMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RestitutionCombineMode__Offset, false);}
			
		}
		
		static readonly int bOverrideRestitutionCombineMode__Offset;
		/// <summary>If set we will use the RestitutionCombineMode of this material, instead of the RestitutionCombineMode found in the project settings.</summary>
		public bool bOverrideRestitutionCombineMode
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideRestitutionCombineMode__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideRestitutionCombineMode__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Density__Offset;
		/// <summary>Used with the shape of the object to calculate its mass properties. The higher the number, the heavier the object. g per cubic cm.</summary>
		public float Density
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Density__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Density__Offset, false);}
			
		}
		
		static readonly int RaiseMassToPower__Offset;
		/// <summary>
		/// Used to adjust the way that mass increases as objects get larger. This is applied to the mass as calculated based on a 'solid' object.
		/// In actuality, larger objects do not tend to be solid, and become more like 'shells' (e.g. a car is not a solid piece of metal).
		/// Values are clamped to 1 or less.
		/// </summary>
		public float RaiseMassToPower
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RaiseMassToPower__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RaiseMassToPower__Offset, false);}
			
		}
		
		static readonly int DestructibleDamageThresholdScale__Offset;
		/// <summary>How much to scale the damage threshold by on any destructible we are applied to</summary>
		public float DestructibleDamageThresholdScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DestructibleDamageThresholdScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DestructibleDamageThresholdScale__Offset, false);}
			
		}
		
		static readonly int PhysicalMaterialProperty__Offset;
		/// <summary>deprecated</summary>
		public UDEPRECATED_PhysicalMaterialPropertyBase PhysicalMaterialProperty
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PhysicalMaterialProperty__Offset); if (v == IntPtr.Zero)return null; UDEPRECATED_PhysicalMaterialPropertyBase retValue = new UDEPRECATED_PhysicalMaterialPropertyBase(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SurfaceType__Offset;
		/// <summary>To edit surface type for your project, use ProjectSettings/Physics/PhysicalSurface section</summary>
		public EPhysicalSurface SurfaceType
		{
			get{ CheckIsValid();return (EPhysicalSurface)Marshal.PtrToStructure(_this.Get()+SurfaceType__Offset, typeof(EPhysicalSurface));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SurfaceType__Offset, false);}
			
		}
		
		static readonly int TireFrictionScale__Offset;
		/// <summary>DEPRECATED - Overall tire friction scalar for every type of tire. This value is multiplied against our parents' values.</summary>
		public float TireFrictionScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TireFrictionScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TireFrictionScale__Offset, false);}
			
		}
		
		static readonly int TireFrictionScales__Offset;
		/// <summary>DEPRECATED - Tire friction scales for specific types of tires. These values are multiplied against our parents' values.</summary>
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
