// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
namespace UnrealEngine
{
	class _IFileManager
	{
		static MonoString* ConvertToAbsolutePathForExternalAppForRead(MonoString* AbsolutePath)
		{
			return FStringToMonoString(IFileManager::Get().ConvertToAbsolutePathForExternalAppForRead(*MonoStringToFString(AbsolutePath)));
		}
		static MonoString* ConvertToAbsolutePathForExternalAppForWrite(MonoString* AbsolutePath)
		{
			return FStringToMonoString(IFileManager::Get().ConvertToAbsolutePathForExternalAppForWrite(*MonoStringToFString(AbsolutePath)));
		}
		static int32 ReadAllBytes(MonoString* InPath,MonoArray** bytes)
		{
			FString AsmPath = MonoStringToFString(InPath);
			//从档案加载
			IFileManager& FileManager = IFileManager::Get();
			auto Reader = FileManager.CreateFileReader(*AsmPath);
			if (!Reader)
			{
				return 0;
			}

			uint32 Size = Reader->TotalSize();

			MonoArray* byteArray = (MonoArray*)FMonoDomain::Get()->CreateArray("System.Byte", Size);
			void* ArrayAddr = mono_array_addr(byteArray, uint8, 0);
			Reader->Serialize(ArrayAddr, Size);

			//关闭文件
			Reader->Close();
			*bytes = byteArray;

			return 1;
		}
		static int32 WriteAllBytes(MonoString* InPath, MonoArray* bytes)
		{
			if (bytes == nullptr)
				return 0;

			FString AsmPath = MonoStringToFString(InPath);
			//从档案加载
			IFileManager& FileManager = IFileManager::Get();
			auto Writer = FileManager.CreateFileWriter(*AsmPath);
			if (!Writer)
			{
				return 0;
			}
			MonoArray* byteArray = bytes;
			uint32 Size = mono_array_length(byteArray);

			void* ArrayAddr = mono_array_addr(byteArray, uint8, 0);
			Writer->Serialize(ArrayAddr, Size);

			//关闭文件
			Writer->Close();

			return 1;
		}
	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.IFileManager::ConvertToAbsolutePathForExternalAppForRead", (const void*)ConvertToAbsolutePathForExternalAppForRead);
			mono_add_internal_call("UnrealEngine.IFileManager::ConvertToAbsolutePathForExternalAppForRead", (const void*)ConvertToAbsolutePathForExternalAppForRead);
			mono_add_internal_call("UnrealEngine.IFileManager::ReadAllBytes", (const void*)ReadAllBytes);
			mono_add_internal_call("UnrealEngine.IFileManager::WriteAllBytes", (const void*)WriteAllBytes);
		}
	};
}