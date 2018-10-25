using System;
using UE;
namespace ChineseChessCS
{
    class TestComponent:UActorComponent
    {
        public override void BeginPlay()
        {
            base.BeginPlay();
            Log("BeginPlay");

        }
    }
}
