using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// @warning: if this is changed:
	///     update BaseEngine.ini [SystemSettings]
	///     you might have to update the update Game's DefaultEngine.ini [SystemSettings]
	///     order and actual name can never change (order is important!)
	/// TEXTUREGROUP_Cinematic: should be used for Cinematics which will be baked out
	///                         and want to have the highest settings
	/// </summary>
	public enum TextureGroup:byte
	{
		orld=0,
		orldNormalMap=1,
		orldSpecular=2,
		haracter=3,
		haracterNormalMap=4,
		haracterSpecular=5,
		eapon=6,
		eaponNormalMap=7,
		eaponSpecular=8,
		ehicle=9,
		ehicleNormalMap=10,
		ehicleSpecular=11,
		inematic=12,
		ffects=13,
		ffectsNotFiltered=14,
		kybox=15,
		I=16,
		ightmap=17,
		enderTarget=18,
		obileFlattened=19,
		/// <summary>Obsolete - kept for backwards compatibility.</summary>
		rocBuilding_Face=20,
		/// <summary>Obsolete - kept for backwards compatibility.</summary>
		rocBuilding_LightMap=21,
		hadowmap=22,
		/// <summary>No compression, no mips.</summary>
		olorLookupTable=23,
		errain_Heightmap=24,
		errain_Weightmap=25,
		/// <summary>Using this TextureGroup triggers special mip map generation code only useful for the BokehDOF post process.</summary>
		okeh=26,
		/// <summary>No compression, created on import of a .IES file.</summary>
		ESLightProfile=27,
		/// <summary>Non-filtered, useful for 2D rendering.</summary>
		ixels2D=28,
		/// <summary>Hierarchical LOD generated textures</summary>
		ierarchicalLOD=29,
		AX=30,
		
	}
	
}
