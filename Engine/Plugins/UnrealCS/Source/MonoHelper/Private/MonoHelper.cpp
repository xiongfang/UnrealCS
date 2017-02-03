// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#include "MonoHelperPrivatePCH.h"
#include "IMonoHelper.h"

DEFINE_LOG_CATEGORY(LogMonoHelper);

class FMonoHelper : public IMonoHelper
{
	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};

IMPLEMENT_MODULE(FMonoHelper, MonoHelper)



void FMonoHelper::StartupModule()
{

}

void FMonoHelper::ShutdownModule()
{

}


UProperty* FindScriptPropertyHelper(UStruct* Class, FName PropertyName)
{
	for (TFieldIterator<UProperty> PropertyIt(Class, EFieldIteratorFlags::ExcludeSuper); PropertyIt; ++PropertyIt)
	{
		UProperty* Property = *PropertyIt;
		if (Property->GetFName() == PropertyName)
		{
			return Property;
		}
	}
	return NULL;
}
