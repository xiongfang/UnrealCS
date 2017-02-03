extern "C"{
	void mono_aot_register_module(void* pt);
	extern void* mono_aot_module_Game_info;
	extern void* mono_aot_module_MainDomain_info;
	extern void* mono_aot_module_Mono_Security_info;
	extern void* mono_aot_module_System_ComponentModel_Composition_info;
	extern void* mono_aot_module_System_ComponentModel_DataAnnotations_info;
	extern void* mono_aot_module_System_Configuration_info;
	extern void* mono_aot_module_System_Net_info;
	extern void* mono_aot_module_System_Security_info;
	extern void* mono_aot_module_System_Xml_info;
	extern void* mono_aot_module_System_info;
	extern void* mono_aot_module_UnrealEngine_info;
	extern void* mono_aot_module_mscorlib_info;
}
void RegisterMonoModules(){
	mono_aot_register_module(mono_aot_module_Game_info);
	mono_aot_register_module(mono_aot_module_MainDomain_info);
	mono_aot_register_module(mono_aot_module_Mono_Security_info);
	mono_aot_register_module(mono_aot_module_System_ComponentModel_Composition_info);
	mono_aot_register_module(mono_aot_module_System_ComponentModel_DataAnnotations_info);
	mono_aot_register_module(mono_aot_module_System_Configuration_info);
	mono_aot_register_module(mono_aot_module_System_Net_info);
	mono_aot_register_module(mono_aot_module_System_Security_info);
	mono_aot_register_module(mono_aot_module_System_Xml_info);
	mono_aot_register_module(mono_aot_module_System_info);
	mono_aot_register_module(mono_aot_module_UnrealEngine_info);
	mono_aot_register_module(mono_aot_module_mscorlib_info);
}
