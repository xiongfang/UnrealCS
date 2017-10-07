using System;
using UnrealEngine;
namespace ChineseChessCS
{
    public class AMyPlayer:APawn
    {
        public FInt32 why;
        public void Say()
        {
            int v = why.ToInt32();
            v = 6;
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
