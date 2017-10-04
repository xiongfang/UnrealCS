#pragma once
#include "Runtime/Engine/Classes/GameFramework/Pawn.h"
#include "Int32.h"
namespace UnrealEngine
{
class AActor;
}
namespace ChineseChessCS{
	class MyPlayer:public UnrealEngine::APawn
	{
		public:
				System::Int32 why;
		public:
		void Say();
		public:
		void SetOwner(UnrealEngine::AActor*  NewOwner);
		public:
		virtual void Hello();
	};
}
