using System;
using UnrealEngine;
namespace ChineseChessCS
{
    

    [UCLASS()]
    public class AMyPlayer:APawn
    {
        [UPROPERTY(text = "EditAnywhere, BlueprintReadWrite")]
        public FInt32 why;

        [UFUNCTION( text = "BlueprintCallable")]
        public void Say()
        {
            int v = why.ToInt32();
            v = 5;
            why.FromInt32(v);
        }

        public override void SetOwner(AActor NewOwner)
        {
            base.SetOwner(NewOwner);
        }

        public virtual void Hello()
        {

        }
    }
}
