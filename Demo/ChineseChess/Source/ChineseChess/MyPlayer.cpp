#include "ChineseChess.h"
#include "MyPlayer.h"
#include "Runtime/Engine/Classes/GameFramework/Pawn.h"
#include "Int32.h"
#include "Runtime/Engine/Classes/GameFramework/Actor.h"
#include "Boolean.h"
using namespace System;
using namespace UnrealEngine;
void ChineseChessCS::MyPlayer::Say()
{
	why.op_Equals(1);
}
void ChineseChessCS::MyPlayer::SetOwner(UnrealEngine::AActor*  NewOwner)
{
	UnrealEngine::APawn::SetOwner(NewOwner);
}
void ChineseChessCS::MyPlayer::Hello()
{
}
