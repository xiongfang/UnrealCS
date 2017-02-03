// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

namespace UnrealEngine
{
	class _FScriptArray
	{
		static void* GetData(FScriptArray* _this)
		{
			return _this->GetData();
		}
		static void InsertZeroed(FScriptArray* _this, int32 Index, int32 Count, int32 NumBytesPerElement)
		{
			_this->InsertZeroed(Index, Count, NumBytesPerElement);
		}
		static void Insert(FScriptArray* _this, int32 Index, int32 Count, int32 NumBytesPerElement)
		{
			_this->Insert(Index, Count, NumBytesPerElement);
		}
		static int32 Add(FScriptArray* _this, int32 Count, int32 NumBytesPerElement)
		{
			return _this->Add(Count, NumBytesPerElement);
		}
		static int32 AddZeroed(FScriptArray* _this, int32 Count, int32 NumBytesPerElement)
		{
			return _this->AddZeroed(Count, NumBytesPerElement);
		}
		static void Shrink(FScriptArray* _this, int32 NumBytesPerElement)
		{
			_this->Shrink(NumBytesPerElement);
		}
		static void Empty(FScriptArray* _this, int32 Slack, int32 NumBytesPerElement)
		{
			_this->Empty(Slack, NumBytesPerElement);
		}
		static void Remove(FScriptArray* _this, int32 Index, int32 Count, int32 NumBytesPerElement)
		{
			_this->Remove(Index, Count, NumBytesPerElement);
		}
	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.FScriptArray::GetData", (const void*)GetData);
			mono_add_internal_call("UnrealEngine.FScriptArray::InsertZeroed", (const void*)InsertZeroed);
			mono_add_internal_call("UnrealEngine.FScriptArray::Insert", (const void*)Insert);
			mono_add_internal_call("UnrealEngine.FScriptArray::Add", (const void*)Add);
			mono_add_internal_call("UnrealEngine.FScriptArray::AddZeroed", (const void*)AddZeroed);
			mono_add_internal_call("UnrealEngine.FScriptArray::Shrink", (const void*)Shrink);
			mono_add_internal_call("UnrealEngine.FScriptArray::Empty", (const void*)Empty);
			mono_add_internal_call("UnrealEngine.FScriptArray::Remove", (const void*)Remove);
		}
	};
}