// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

#include "ModuleManager.h"

/**
 * The public interface to this module.  In most cases, this interface is only public to sibling modules 
 * within this plugin.
 */
class IMonoPlugin : public IModuleInterface
{

public:
	DECLARE_MULTICAST_DELEGATE_TwoParams(FOnNewClass, const FString&,UClass*);

	/**
	 * Singleton-like access to this module's interface.  This is just for convenience!
	 * Beware of calling this during the shutdown phase, though.  Your module might have been unloaded already.
	 *
	 * @return Returns singleton instance, loading the module on demand if needed
	 */
	static inline IMonoPlugin& Get()
	{
		return FModuleManager::LoadModuleChecked< IMonoPlugin >("MonoPlugin");
	}

	/**
	 * Checks to see if this module is loaded and ready.  It is only valid to call Get() if IsAvailable() returns true.
	 *
	 * @return True if the module is loaded and ready to use
	 */
	static inline bool IsAvailable()
	{
		return FModuleManager::Get().IsModuleLoaded( "MonoPlugin" );
	}

	virtual void HotReload() = 0;
	virtual void FixSize() = 0;

	virtual FOnNewClass& Event_OnNewClass() = 0;

	virtual void SendCommand(const FString& cmd) = 0;
};

