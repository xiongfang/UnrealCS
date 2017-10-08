#include "ChineseChess.h"
#include "AMyPlayer.h"
#include "Runtime/Engine/Classes/GameFramework/Pawn.h"
#include "FInt32.h"
#include "Runtime/Engine/Classes/GameFramework/Actor.h"
#include "Int32.h"
void AMyPlayer::Say()
{
	Int32 v=why.ToInt32();
	v.op_Assign(5);
	why.FromInt32(v);
}
void AMyPlayer::SetOwner(AActor*  NewOwner)
{
	APawn::SetOwner(NewOwner);
}
void AMyPlayer::Hello()
{
}
