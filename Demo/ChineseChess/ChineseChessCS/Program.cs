using System;
using UnrealEngine;
namespace ChineseChessCS
{
    public class MyPlayer:APawn
    {
        public int why;
        public void Say()
        {
            why = 1;
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
