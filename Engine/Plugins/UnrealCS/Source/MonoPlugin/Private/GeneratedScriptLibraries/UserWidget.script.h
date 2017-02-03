#pragma once

namespace UnrealEngine
{
	class _UUserWidget
	{
		static int32 IsPlayingAnimation(UUserWidget* _this)
		{
			bool ___ret = _this->IsPlayingAnimation();
			return ___ret?1:0;
			
		}
		static void ReverseAnimation(UUserWidget* _this,UWidgetAnimation* InAnimation)
		{
			_this->ReverseAnimation(InAnimation);
			
		}
		static void SetPlaybackSpeed(UUserWidget* _this,UWidgetAnimation* InAnimation,float PlaybackSpeed)
		{
			_this->SetPlaybackSpeed(InAnimation,PlaybackSpeed);
			
		}
		static void SetNumLoopsToPlay(UUserWidget* _this,UWidgetAnimation* InAnimation,int32 NumLoopsToPlay)
		{
			_this->SetNumLoopsToPlay(InAnimation,NumLoopsToPlay);
			
		}
		static int32 IsAnyAnimationPlaying(UUserWidget* _this)
		{
			bool ___ret = _this->IsAnyAnimationPlaying();
			return ___ret?1:0;
			
		}
		static int32 IsAnimationPlaying(UUserWidget* _this,UWidgetAnimation* InAnimation)
		{
			bool ___ret = _this->IsAnimationPlaying(InAnimation);
			return ___ret?1:0;
			
		}
		static float GetAnimationCurrentTime(UUserWidget* _this,UWidgetAnimation* InAnimation)
		{
			float ___ret = _this->GetAnimationCurrentTime(InAnimation);
			return ___ret;
			
		}
		static float PauseAnimation(UUserWidget* _this,UWidgetAnimation* InAnimation)
		{
			float ___ret = _this->PauseAnimation(InAnimation);
			return ___ret;
			
		}
		static void StopAnimation(UUserWidget* _this,UWidgetAnimation* InAnimation)
		{
			_this->StopAnimation(InAnimation);
			
		}
		static void PlayAnimationTo(UUserWidget* _this,UWidgetAnimation* InAnimation,float StartAtTime,float EndAtTime,int32 NumLoopsToPlay,int32 PlayMode,float PlaybackSpeed)
		{
			_this->PlayAnimationTo(InAnimation,StartAtTime,EndAtTime,NumLoopsToPlay,(TEnumAsByte<EUMGSequencePlayMode::Type>)PlayMode,PlaybackSpeed);
			
		}
		static void PlayAnimation(UUserWidget* _this,UWidgetAnimation* InAnimation,float StartAtTime,int32 NumLoopsToPlay,int32 PlayMode,float PlaybackSpeed)
		{
			_this->PlayAnimation(InAnimation,StartAtTime,NumLoopsToPlay,(TEnumAsByte<EUMGSequencePlayMode::Type>)PlayMode,PlaybackSpeed);
			
		}
		static void SetPadding(UUserWidget* _this,FMargin* InPadding)
		{
			_this->SetPadding(*InPadding);
			
		}
		static void SetForegroundColor(UUserWidget* _this,FSlateColor* InForegroundColor)
		{
			_this->SetForegroundColor(*InForegroundColor);
			
		}
		static void SetColorAndOpacity(UUserWidget* _this,FLinearColor* InColorAndOpacity)
		{
			_this->SetColorAndOpacity(*InColorAndOpacity);
			
		}
		static APawn* GetOwningPlayerPawn(UUserWidget* _this)
		{
			APawn* ___ret = _this->GetOwningPlayerPawn();
			return ___ret;
			
		}
		static APlayerController* GetOwningPlayer(UUserWidget* _this)
		{
			APlayerController* ___ret = _this->GetOwningPlayer();
			return ___ret;
			
		}
		static void SetOwningLocalPlayer(UUserWidget* _this,ULocalPlayer* LocalPlayer)
		{
			_this->SetOwningLocalPlayer(LocalPlayer);
			
		}
		static ULocalPlayer* GetOwningLocalPlayer(UUserWidget* _this)
		{
			ULocalPlayer* ___ret = _this->GetOwningLocalPlayer();
			return ___ret;
			
		}
		static int32 IsInViewport(UUserWidget* _this)
		{
			bool ___ret = _this->IsInViewport();
			return ___ret?1:0;
			
		}
		static void SetAlignmentInViewport(UUserWidget* _this,FVector2D* Alignment)
		{
			_this->SetAlignmentInViewport(*Alignment);
			
		}
		static void SetAnchorsInViewport(UUserWidget* _this,FAnchors* Anchors)
		{
			_this->SetAnchorsInViewport(*Anchors);
			
		}
		static void SetDesiredSizeInViewport(UUserWidget* _this,FVector2D* Size)
		{
			_this->SetDesiredSizeInViewport(*Size);
			
		}
		static void SetPositionInViewport(UUserWidget* _this,FVector2D* Position,int32 bRemoveDPIScale)
		{
			_this->SetPositionInViewport(*Position,bRemoveDPIScale>0?true:false);
			
		}
		static int32 AddToPlayerScreen(UUserWidget* _this,int32 ZOrder)
		{
			bool ___ret = _this->AddToPlayerScreen(ZOrder);
			return ___ret?1:0;
			
		}
		static void AddToViewport(UUserWidget* _this,int32 ZOrder)
		{
			_this->AddToViewport(ZOrder);
			
		}
		static UClass* StaticClass(){return UUserWidget::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UUserWidget::IsPlayingAnimation",(const void*)IsPlayingAnimation);
			mono_add_internal_call("UnrealEngine.UUserWidget::ReverseAnimation",(const void*)ReverseAnimation);
			mono_add_internal_call("UnrealEngine.UUserWidget::SetPlaybackSpeed",(const void*)SetPlaybackSpeed);
			mono_add_internal_call("UnrealEngine.UUserWidget::SetNumLoopsToPlay",(const void*)SetNumLoopsToPlay);
			mono_add_internal_call("UnrealEngine.UUserWidget::IsAnyAnimationPlaying",(const void*)IsAnyAnimationPlaying);
			mono_add_internal_call("UnrealEngine.UUserWidget::IsAnimationPlaying",(const void*)IsAnimationPlaying);
			mono_add_internal_call("UnrealEngine.UUserWidget::GetAnimationCurrentTime",(const void*)GetAnimationCurrentTime);
			mono_add_internal_call("UnrealEngine.UUserWidget::PauseAnimation",(const void*)PauseAnimation);
			mono_add_internal_call("UnrealEngine.UUserWidget::StopAnimation",(const void*)StopAnimation);
			mono_add_internal_call("UnrealEngine.UUserWidget::PlayAnimationTo",(const void*)PlayAnimationTo);
			mono_add_internal_call("UnrealEngine.UUserWidget::PlayAnimation",(const void*)PlayAnimation);
			mono_add_internal_call("UnrealEngine.UUserWidget::SetPadding",(const void*)SetPadding);
			mono_add_internal_call("UnrealEngine.UUserWidget::SetForegroundColor",(const void*)SetForegroundColor);
			mono_add_internal_call("UnrealEngine.UUserWidget::SetColorAndOpacity",(const void*)SetColorAndOpacity);
			mono_add_internal_call("UnrealEngine.UUserWidget::GetOwningPlayerPawn",(const void*)GetOwningPlayerPawn);
			mono_add_internal_call("UnrealEngine.UUserWidget::GetOwningPlayer",(const void*)GetOwningPlayer);
			mono_add_internal_call("UnrealEngine.UUserWidget::SetOwningLocalPlayer",(const void*)SetOwningLocalPlayer);
			mono_add_internal_call("UnrealEngine.UUserWidget::GetOwningLocalPlayer",(const void*)GetOwningLocalPlayer);
			mono_add_internal_call("UnrealEngine.UUserWidget::IsInViewport",(const void*)IsInViewport);
			mono_add_internal_call("UnrealEngine.UUserWidget::SetAlignmentInViewport",(const void*)SetAlignmentInViewport);
			mono_add_internal_call("UnrealEngine.UUserWidget::SetAnchorsInViewport",(const void*)SetAnchorsInViewport);
			mono_add_internal_call("UnrealEngine.UUserWidget::SetDesiredSizeInViewport",(const void*)SetDesiredSizeInViewport);
			mono_add_internal_call("UnrealEngine.UUserWidget::SetPositionInViewport",(const void*)SetPositionInViewport);
			mono_add_internal_call("UnrealEngine.UUserWidget::AddToPlayerScreen",(const void*)AddToPlayerScreen);
			mono_add_internal_call("UnrealEngine.UUserWidget::AddToViewport",(const void*)AddToViewport);
			mono_add_internal_call("UnrealEngine.UUserWidget::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
