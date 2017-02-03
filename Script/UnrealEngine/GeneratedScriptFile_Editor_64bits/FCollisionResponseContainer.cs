#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Container for indicating a set of collision channels that this object will collide with.</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FCollisionResponseContainer
	{
		/// <summary>
		/// Reserved Engine Trace Channels
		/// Note -        If you change this (add/remove/modify)
		///                       you should make sure it matches with ECollisionChannel (including DisplayName)
		///                       They has to be mirrored if serialized
		/// </summary>
		[FieldOffset(0)]
		public ECollisionResponse WorldStatic;
		/// <summary>0</summary>
		[FieldOffset(1)]
		public ECollisionResponse WorldDynamic;
		/// <summary>1.</summary>
		[FieldOffset(2)]
		public ECollisionResponse Pawn;
		/// <summary>2</summary>
		[FieldOffset(3)]
		public ECollisionResponse Visibility;
		/// <summary>3</summary>
		[FieldOffset(4)]
		public ECollisionResponse Camera;
		/// <summary>4</summary>
		[FieldOffset(5)]
		public ECollisionResponse PhysicsBody;
		/// <summary>5</summary>
		[FieldOffset(6)]
		public ECollisionResponse Vehicle;
		/// <summary>6</summary>
		[FieldOffset(7)]
		public ECollisionResponse Destructible;
		/// <summary>Unspecified Engine Trace Channels</summary>
		[FieldOffset(8)]
		public ECollisionResponse EngineTraceChannel1;
		/// <summary>8</summary>
		[FieldOffset(9)]
		public ECollisionResponse EngineTraceChannel2;
		/// <summary>9</summary>
		[FieldOffset(10)]
		public ECollisionResponse EngineTraceChannel3;
		/// <summary>10</summary>
		[FieldOffset(11)]
		public ECollisionResponse EngineTraceChannel4;
		/// <summary>11</summary>
		[FieldOffset(12)]
		public ECollisionResponse EngineTraceChannel5;
		/// <summary>12</summary>
		[FieldOffset(13)]
		public ECollisionResponse EngineTraceChannel6;
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
		[FieldOffset(14)]
		public ECollisionResponse GameTraceChannel1;
		/// <summary>14</summary>
		[FieldOffset(15)]
		public ECollisionResponse GameTraceChannel2;
		/// <summary>15</summary>
		[FieldOffset(16)]
		public ECollisionResponse GameTraceChannel3;
		/// <summary>16</summary>
		[FieldOffset(17)]
		public ECollisionResponse GameTraceChannel4;
		/// <summary>17</summary>
		[FieldOffset(18)]
		public ECollisionResponse GameTraceChannel5;
		/// <summary>18</summary>
		[FieldOffset(19)]
		public ECollisionResponse GameTraceChannel6;
		/// <summary>19</summary>
		[FieldOffset(20)]
		public ECollisionResponse GameTraceChannel7;
		/// <summary>20</summary>
		[FieldOffset(21)]
		public ECollisionResponse GameTraceChannel8;
		/// <summary>21</summary>
		[FieldOffset(22)]
		public ECollisionResponse GameTraceChannel9;
		/// <summary>22</summary>
		[FieldOffset(23)]
		public ECollisionResponse GameTraceChannel10;
		/// <summary>23</summary>
		[FieldOffset(24)]
		public ECollisionResponse GameTraceChannel11;
		/// <summary>24</summary>
		[FieldOffset(25)]
		public ECollisionResponse GameTraceChannel12;
		/// <summary>25</summary>
		[FieldOffset(26)]
		public ECollisionResponse GameTraceChannel13;
		/// <summary>26</summary>
		[FieldOffset(27)]
		public ECollisionResponse GameTraceChannel14;
		/// <summary>27</summary>
		[FieldOffset(28)]
		public ECollisionResponse GameTraceChannel15;
		/// <summary>28</summary>
		[FieldOffset(29)]
		public ECollisionResponse GameTraceChannel16;
		/// <summary>28</summary>
		[FieldOffset(30)]
		public ECollisionResponse GameTraceChannel17;
		/// <summary>30</summary>
		[FieldOffset(31)]
		public ECollisionResponse GameTraceChannel18;
		
	}
	
}
#endif
#endif
