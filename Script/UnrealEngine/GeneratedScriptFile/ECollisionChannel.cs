using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enum indicating different type of objects for rigid-body collision purposes.</summary>
	public enum ECollisionChannel:byte
	{
		ECC_WorldStatic=0,
		ECC_WorldDynamic=1,
		ECC_Pawn=2,
		ECC_Visibility=3,
		ECC_Camera=4,
		ECC_PhysicsBody=5,
		ECC_Vehicle=6,
		ECC_Destructible=7,
		/// <summary>Reserved for gizmo collision</summary>
		ECC_EngineTraceChannel1=8,
		ECC_EngineTraceChannel2=9,
		ECC_EngineTraceChannel3=10,
		ECC_EngineTraceChannel4=11,
		ECC_EngineTraceChannel5=12,
		ECC_EngineTraceChannel6=13,
		ECC_GameTraceChannel1=14,
		ECC_GameTraceChannel2=15,
		ECC_GameTraceChannel3=16,
		ECC_GameTraceChannel4=17,
		ECC_GameTraceChannel5=18,
		ECC_GameTraceChannel6=19,
		ECC_GameTraceChannel7=20,
		ECC_GameTraceChannel8=21,
		ECC_GameTraceChannel9=22,
		ECC_GameTraceChannel10=23,
		ECC_GameTraceChannel11=24,
		ECC_GameTraceChannel12=25,
		ECC_GameTraceChannel13=26,
		ECC_GameTraceChannel14=27,
		ECC_GameTraceChannel15=28,
		ECC_GameTraceChannel16=29,
		ECC_GameTraceChannel17=30,
		ECC_GameTraceChannel18=31,
		/// <summary>Add only nonserialized/transient flags below // NOTE!!!! THESE ARE BEING DEPRECATED BUT STILL THERE FOR BLUEPRINT. PLEASE DO NOT USE THEM IN CODE</summary>
		ECC_OverlapAll_Deprecated=32,
		ECC_MAX=33,
		
	}
	
}
