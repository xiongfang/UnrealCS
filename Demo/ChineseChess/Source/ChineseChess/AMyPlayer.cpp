#include "ChineseChess.h"
#include "AMyPlayer.h"
#include "Runtime/Engine/Classes/GameFramework/Pawn.h"
#include "FInt32.h"
#include "Runtime/Engine/Classes/GameFramework/Actor.h"
#include "Int32.h"
void AMyPlayer::Say()
{
	Int32 v=why2.ToInt32();
	v.op_Assign(6);
	why2.FromInt32(v);
}
void AMyPlayer::SetOwner(AActor*  NewOwner)
{
	APawn::SetOwner(NewOwner);
}
void AMyPlayer::Hello()
{
}
