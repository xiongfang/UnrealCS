using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using UnrealEngine;

namespace Game
{
    public class TestClass : UMonoActorComponent
    {
        public int testData = 1;
        public float testFloat = 2.0f;
        public string testString = "哇哇";
        public UBlueprint testObj = null;
        public int[] intArray2;
        public string[] strArray;
        public bool[] boolArray;
        public bool checkState;
        //注意大小写
        public AActor[] actorArray2;
        float timer = 0.0f;

        public TSubclassOf<AStaticMeshActor> Weapon;

        public void TestMethod()
        {
            LogInfo("testMethod");
        }

        void OnOverlap(AActor _this, AActor other)
        {
            LogInfo(string.Format("{0} overlap {1}", _this.GetName(), other.GetName()));
        }

        void BeginPlay()
        {
            LogWarning("Hello World!");

            LogInfo(string.Format("int {0}", testData));
            LogInfo(string.Format("testFloat {0}", testFloat));
            LogInfo(string.Format("testString {0}", testString));

            LogInfo("Class " + this.GetName());
            if (this.GetOuter() == null)
                LogInfo("Class Out Is Null");
            else
                LogInfo("Class " + this.GetOuter().GetName());

            FTransform trans = GetOwner().GetTransform();
            trans.Scale3D.X = 3.0f;
            trans.Scale3D.Y = 3.0f;
            trans.Scale3D.Z = 3.0f;
            LogInfo("more methods:" + string.Format("Actor Name {0}, Pos {1},{2},{3}",
                this.GetOwner().GetName(),
                trans.Translation.X,
                trans.Translation.Y,
                trans.Translation.Z));

            LogInfo("Tick Group " + this.PrimaryComponentTick.TickGroup);

            LogInfo(string.Format("array num {0}", intArray2.Length));
            for (int i = 0; i < intArray2.Length; i++)
            {
                LogInfo(string.Format("intArray index {0} , value {1}", i, intArray2[i]));
            }
            for (int i = 0; i < strArray.Length; i++)
            {
                LogInfo(string.Format("strArray index {0} , value {1}", i, strArray[i]));
            }
            for (int i = 0; i < boolArray.Length; i++)
            {
                LogInfo(string.Format("boolArray index {0} , value {1}", i, boolArray[i]));
            }
            if (actorArray2 != null)
            {
                for (int i = 0; i < actorArray2.Length; i++)
                {
                    LogInfo(string.Format("actorArray2 index {0} , value {1}", i, actorArray2[i].GetName()));
                }
            }
            else
            {
                LogInfo(string.Format("actorArray2 is null"));
            }

            LogInfo(string.Format("check state {0}", checkState));

            AActor Owner = this.GetOwner();

            TStructArray<FName> tags = this.ComponentTags;
            tags.Add(FName.FromString("Tag0_Modify"));
            tags.Add(FName.FromString("Tag1"));
            this.ComponentTags = tags;
            int num = this.ComponentTags.Num();
            LogInfo("Tags Num:" + num);
            for (int i = 0; i < num; i++)
            {
                LogInfo(string.Format("com name {0}", this.ComponentTags[i].ToString()));
            }
            LogInfo(string.Format("GetComponentsByClass"));
            TSubclassOf<UActorComponent> Class = typeof(UActorComponent);
            LogInfo(string.Format("GetComponentsByClass1"));
            UActorComponent[] coms = this.GetOwner().GetComponentsByClass(Class);
            LogInfo(string.Format("GetComponentsByClass2"));
            LogInfo(string.Format("coms num {0}", coms.Length));
            for (int i = 0; i < coms.Length; i++)
            {
                LogInfo(string.Format("coms index {0} , value {1}", i, coms[i].GetName()));
            }

        }

        FKey GetKey(string name)
        {
            return new FKey() { KeyName = FName.FromString(name) };
        }

        void Tick(float time)
        {
            FVector rot = this.GetOwner().GetActorScale3D();
            rot.X += 5 * time;
            if (rot.X > 200)
                rot.X = 10;
            this.GetOwner().SetActorScale3D(rot);

            APlayerController pc = UGameplayStatics.GetPlayerController(GetWorld(), 0);
            if (pc != null)
            {
                if (pc.IsInputKeyDown(GetKey("I")))
                {
                    FLinearColor Color = new FLinearColor();
                    Color.A = 1.0f;
                    Color.R = 1.0f;

                    UKismetSystemLibrary.DrawDebugBox(GetWorld(), this.GetOwner().GetTransform().GetLocation(), new FVector(100), Color, this.GetOwner().GetTransform().Rotator(), 0.0f, 0.3f);
                }
            }
        }
    }


    public class UMyPlayerController:UMonoActorComponent
    {

        APlayerController pc;

        public TSubclassOf<AActor> WeaponActorPrefab;
        public TSubclassOf<AStaticMeshActor> Weapon;
        public TSubclassOf<AStaticMeshActor> Shield;
        public UAnimMontage Montage;

        void BeginPlay()
        {
            pc = Cast<APlayerController>(GetOwner());
        }

        void Tick(float deltaTime)
        {
            FRotator rot = pc.GetControlRotation();
            FVector forward = UKismetMathLibrary.GetForwardVector(new FRotator(0, rot.Yaw, 0));
            FVector right = UKismetMathLibrary.GetRightVector(new FRotator(0, rot.Yaw, 0));
            FKey key = new FKey();
            key.KeyName = FName.FromString("W");
            if (pc.IsInputKeyDown(key))
            {
                pc.K2_GetPawn().AddMovementInput(forward, 1.0f, false);
            }
            key.KeyName = FName.FromString("S");
            if (pc.IsInputKeyDown(key))
            {
                pc.K2_GetPawn().AddMovementInput(-forward, 1.0f, false);
            }
            key.KeyName = FName.FromString("A");
            if (pc.IsInputKeyDown(key))
            {
                pc.K2_GetPawn().AddMovementInput(-right, 1.0f, false);
            }
            key.KeyName = FName.FromString("D");
            if (pc.IsInputKeyDown(key))
            {
                pc.K2_GetPawn().AddMovementInput(right, 1.0f, false);
            }

            key.KeyName = FName.FromString("J");
            if (pc.IsInputKeyDown(key))
            {
                USkeletalMeshComponent mesh = Cast< USkeletalMeshComponent>( pc.K2_GetPawn().GetComponentByClass(typeof(USkeletalMeshComponent)));
                mesh.GetAnimInstance().Montage_Play(Montage, 1);
            }

            float movex, movey;
            pc.GetInputMouseDelta(out movex, out movey);
            pc.AddYawInput(movex);
            pc.AddPitchInput(movey);
        }
    }

}
