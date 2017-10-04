using System;
namespace UnrealEngine
{
	/// <summary>Container for indicating a set of collision channels that this object will collide with.</summary>
	public partial struct FCollisionResponseContainer
	{
		/// <summary>
		/// Reserved Engine Trace Channels
		/// Note -        If you change this (add/remove/modify)
		///                       you should make sure it matches with ECollisionChannel (including DisplayName)
		///                       They has to be mirrored if serialized
		/// </summary>
		public ECollisionResponse WorldStatic;
		/// <summary>0</summary>
		public ECollisionResponse WorldDynamic;
		/// <summary>1.</summary>
		public ECollisionResponse Pawn;
		/// <summary>2</summary>
		public ECollisionResponse Visibility;
		/// <summary>3</summary>
		public ECollisionResponse Camera;
		/// <summary>4</summary>
		public ECollisionResponse PhysicsBody;
		/// <summary>5</summary>
		public ECollisionResponse Vehicle;
		/// <summary>6</summary>
		public ECollisionResponse Destructible;
		/// <summary>Unspecified Engine Trace Channels</summary>
		public ECollisionResponse EngineTraceChannel1;
		/// <summary>8</summary>
		public ECollisionResponse EngineTraceChannel2;
		/// <summary>9</summary>
		public ECollisionResponse EngineTraceChannel3;
		/// <summary>10</summary>
		public ECollisionResponse EngineTraceChannel4;
		/// <summary>11</summary>
		public ECollisionResponse EngineTraceChannel5;
		/// <summary>12</summary>
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
		public ECollisionResponse GameTraceChannel1;
		/// <summary>14</summary>
		public ECollisionResponse GameTraceChannel2;
		/// <summary>15</summary>
		public ECollisionResponse GameTraceChannel3;
		/// <summary>16</summary>
		public ECollisionResponse GameTraceChannel4;
		/// <summary>17</summary>
		public ECollisionResponse GameTraceChannel5;
		/// <summary>18</summary>
		public ECollisionResponse GameTraceChannel6;
		/// <summary>19</summary>
		public ECollisionResponse GameTraceChannel7;
		/// <summary>20</summary>
		public ECollisionResponse GameTraceChannel8;
		/// <summary>21</summary>
		public ECollisionResponse GameTraceChannel9;
		/// <summary>22</summary>
		public ECollisionResponse GameTraceChannel10;
		/// <summary>23</summary>
		public ECollisionResponse GameTraceChannel11;
		/// <summary>24</summary>
		public ECollisionResponse GameTraceChannel12;
		/// <summary>25</summary>
		public ECollisionResponse GameTraceChannel13;
		/// <summary>26</summary>
		public ECollisionResponse GameTraceChannel14;
		/// <summary>27</summary>
		public ECollisionResponse GameTraceChannel15;
		/// <summary>28</summary>
		public ECollisionResponse GameTraceChannel16;
		/// <summary>28</summary>
		public ECollisionResponse GameTraceChannel17;
		/// <summary>30</summary>
		public ECollisionResponse GameTraceChannel18;
		
	}
	
}
