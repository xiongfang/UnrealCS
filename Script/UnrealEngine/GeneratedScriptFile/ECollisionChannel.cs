using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Enum indicating different type of objects for rigid-body collision purposes.
	/// NOTE!! Some of these values are used to index into FCollisionResponseContainers and must be kept in sync.
	/// @see FCollisionResponseContainer::SetResponse().
	/// </summary>
	public enum ECollisionChannel:byte
	{
		/// <summary>
		/// @NOTE!!!! This DisplayName [DISPLAYNAME] SHOULD MATCH suffix of ECC_DISPLAYNAME
		/// Otherwise it will mess up collision profile loading
		/// If you change this, please also change FCollisionResponseContainers
		/// If you add any more TraceQuery="1", you also should change UCollsionProfile::LoadProfileConfig
		/// Metadata doesn't work outside of editor, so you'll need to add manually
		/// </summary>
		ECC_WorldStatic=0,
		ECC_WorldDynamic=1,
		ECC_Pawn=2,
		ECC_Visibility=3,
		ECC_Camera=4,
		ECC_PhysicsBody=5,
		ECC_Vehicle=6,
		ECC_Destructible=7,
		/// <summary>Unspecified Engine Trace Channels</summary>
		ECC_EngineTraceChannel1=8,
		/// <summary>IMPORTANT: This engine trace channel is reserved by the COLLISION_GIZMO definition</summary>
		ECC_EngineTraceChannel2=9,
		ECC_EngineTraceChannel3=10,
		ECC_EngineTraceChannel4=11,
		ECC_EngineTraceChannel5=12,
		ECC_EngineTraceChannel6=13,
		/// <summary>
		/// in order to use this custom channels
		/// we recommend to define in your local file
		/// - i.e. #define COLLISION_WEAPON               ECC_GameTraceChannel1
		/// and make sure you customize these it in INI file by
		/// in DefaultEngine.ini
		/// [/Script/Engine.CollisionProfile]
		/// GameTraceChannel1="Weapon"
		/// also in the INI file, you can override collision profiles that are defined by simply redefining
		/// note that Weapon isn't defined in the BaseEngine.ini file, but "Trigger" is defined in Engine
		/// +Profiles=(Name="Trigger",CollisionEnabled=QueryOnly,ObjectTypeName=WorldDynamic, DefaultResponse=ECR_Overlap, CustomResponses=((Channel=Visibility, Response=ECR_Ignore), (Channel=Weapon, Response=ECR_Ignore)))
		/// </summary>
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
		/// <summary>can't add displaynames because then it will show up in the collision channel option</summary>
		ECC_OverlapAll_Deprecated=32,
		ECC_MAX=33,
		
	}
	
}
