// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#include "PropertyHandler.h"
#include "MonoHelperPrivatePCH.h"




class PropertyHandlerBase :public IPropertyHandler
{

public:
	//返回C++类型名称，带前缀
	virtual FString GetCppTypeName(UProperty* P) override;
	virtual FString GetCppParamTypeName(UProperty* P) override;
	//返回作为C++参数时的类型名称
	virtual FString GetCppMarshalTypeName(UProperty* P) override;
	virtual FString GetCppMarshalReturnTypeName(UProperty* P) override;
	//转换
	virtual FString BuildCppFuncPreCall(UProperty* P) override;
	virtual FString BuildCppCallParam(UProperty* P) override;
	//转换
	virtual FString BuildCppFuncPostSet(UProperty* P) override;
	virtual FString BuildCppFuncReturn(UProperty* P) override;

	virtual FMonoTextBuilder BuildCppProperty(const FString& FieldName, UProperty* P)override
	{
		return FMonoTextBuilder();
	}

	//返回带前缀的C#名称
	virtual FString GetCSharpTypeName(UProperty* P) override;
	virtual FString GetCSharpMemberTypeName(UProperty* P) override;
	virtual FString GetCSharpParamTypeName(UProperty* P) override;
	//返回作为C#静态参数时的类型名称
	virtual FString GetCSharpMarshalTypeName(UProperty* P) override;
	virtual FString GetCSharpMarshalReturnTypeName(UProperty* P) override;

	virtual FString BuildCSharpFuncPreCall(UProperty* P) override;
	virtual FString BuildCSharpCallParam(UProperty* P) override;
	virtual FString BuildCSharpFuncPostSet(UProperty* P) override;
	virtual FString BuildCSharpFuncReturn(UProperty* P) override;

	virtual FMonoTextBuilder BuildCSharpClassProperty(UProperty* P) override;
	virtual FMonoTextBuilder BuildCSharpStructProperty(const FString& StructName, UProperty* P) override;

	virtual FString GetCSharpDefaultParameterValue(UFunction* Function, UProperty* ParamProperty) override;
	virtual FString GetNullReturnCSharpValue(UFunction* Function, UProperty* ParamProperty) override;

	bool IsOutParam(UProperty* P);
};

class ValueTypePropertyHandler :public PropertyHandlerBase
{
public:
	//返回C++类型名称，带前缀
	//virtual FString GetCppParamTypeName(UProperty* P) override;
	//返回作为C++参数时的类型名称
	//virtual FString GetCppMarshalTypeName(UProperty* P) override;
	//转换
	//virtual FString BuildCppFuncPreCall(UProperty* P) override;
	////转换
	//virtual FString BuildCppFuncPostSet(UProperty* P) override;
	//virtual FString BuildCppFuncReturn(UProperty* P) override;

	virtual FString GetCSharpDefaultParameterValue(UFunction* Function, UProperty* ParamProperty) override
	{
		FString Value = PropertyHandlerBase::GetCSharpDefaultParameterValue(Function, ParamProperty);
		if (Value.Len() > 0)
			return  FString::Printf(TEXT("default(%s)"), *GetCSharpTypeName(ParamProperty));
		else
			return Value;
	}
};

class StructTypePropertyHandler :public ValueTypePropertyHandler
{
public:
	//virtual FString GetCppParamTypeName(UProperty* P) override
	//{
	//	return GetCppTypeName(P) + "*";
	//}
	//返回作为C++参数时的类型名称
	virtual FString GetCppMarshalTypeName(UProperty* P) override
	{
		return GetCppTypeName(P) + "*";
	}
	virtual FString GetCppMarshalReturnTypeName(UProperty* P) override
	{
		return GetCppTypeName(P);
	}
	virtual FString BuildCppCallParam(UProperty* P) override
	{
		return "*" + P->GetName();
	}
	virtual FString GetCSharpParamTypeName(UProperty* P) override
	{
		bool out = IsOutParam(P);
		if (out)
			return "out " + GetCSharpTypeName(P);
		else
			return GetCSharpTypeName(P);
	}
	//返回作为C#静态参数时的类型名称
	virtual FString GetCSharpMarshalTypeName(UProperty* P) override
	{
		bool out = IsOutParam(P);
		if (out)
			return "out " + GetCSharpTypeName(P);
		else
			return "ref " + GetCSharpTypeName(P);
	}
	//返回作为C#静态参数时的类型名称
	virtual FString GetCSharpMarshalReturnTypeName(UProperty* P) override
	{
		return GetCSharpTypeName(P);
	}

	virtual FString BuildCSharpCallParam(UProperty* P) override
	{
		bool out = IsOutParam(P);
		if (out)
			return "out " + P->GetName();
		else
			return "ref " + P->GetName();
	}

	virtual FString GetCSharpDefaultParameterValue(UFunction* Function, UProperty* ParamProperty) override
	{
		FString Value = ValueTypePropertyHandler::GetCSharpDefaultParameterValue(Function, ParamProperty);
		if (Value.Len() > 0)
			return  FString::Printf(TEXT("default(%s)"), *GetCSharpTypeName(ParamProperty));
		else
			return Value;
	}
};

class NameTypePropertyHandler :public ValueTypePropertyHandler
{
public:
	//返回C++类型名称，带前缀
	virtual FString GetCppTypeName(UProperty* P) override;
	virtual FString GetCppParamTypeName(UProperty* P) override;
	//返回作为C++参数时的类型名称
	virtual FString GetCppMarshalTypeName(UProperty* P) override;
	//转换
	virtual FString BuildCppFuncPreCall(UProperty* P) override;
	virtual FString BuildCppCallParam(UProperty* P) override;
	//转换
	virtual FString BuildCppFuncPostSet(UProperty* P) override;
	virtual FString BuildCppFuncReturn(UProperty* P) override;

	//返回带前缀的C#名称
	virtual FString GetCSharpTypeName(UProperty* P) override;
	virtual FString GetCSharpMemberTypeName(UProperty* P) override;
	virtual FString GetCSharpParamTypeName(UProperty* P) override;
	//返回作为C#静态参数时的类型名称
	virtual FString GetCSharpMarshalTypeName(UProperty* P) override;

	virtual FMonoTextBuilder BuildCSharpClassProperty(UProperty* P) override;
	virtual FMonoTextBuilder BuildCSharpStructProperty(const FString& StructName, UProperty* P) override;
	virtual FString GetCSharpDefaultParameterValue(UFunction* Function, UProperty* ParamProperty) override;
};
class StrTypePropertyHandler :public ValueTypePropertyHandler
{
public:
	//返回C++类型名称，带前缀
	virtual FString GetCppTypeName(UProperty* P) override;
	virtual FString GetCppParamTypeName(UProperty* P) override;
	//返回作为C++参数时的类型名称
	virtual FString GetCppMarshalTypeName(UProperty* P) override;
	//转换
	virtual FString BuildCppFuncPreCall(UProperty* P) override;
	virtual FString BuildCppCallParam(UProperty* P) override;
	//转换
	virtual FString BuildCppFuncPostSet(UProperty* P) override;
	virtual FString BuildCppFuncReturn(UProperty* P) override;

	//返回带前缀的C#名称
	virtual FString GetCSharpTypeName(UProperty* P) override;
	virtual FString GetCSharpMemberTypeName(UProperty* P) override;
	virtual FString GetCSharpParamTypeName(UProperty* P) override;
	//返回作为C#静态参数时的类型名称
	virtual FString GetCSharpMarshalTypeName(UProperty* P) override;

	virtual FMonoTextBuilder BuildCSharpClassProperty(UProperty* P) override;
	virtual FMonoTextBuilder BuildCSharpStructProperty(const FString& StructName, UProperty* P) override;
	virtual FString GetCSharpDefaultParameterValue(UFunction* Function, UProperty* ParamProperty) override;
};

class TextTypePropertyHandler :public PropertyHandlerBase
{
public:
	//返回C++类型名称，带前缀
	virtual FString GetCppTypeName(UProperty* P) override;
	virtual FString GetCppParamTypeName(UProperty* P) override;
	//返回作为C++参数时的类型名称
	virtual FString GetCppMarshalTypeName(UProperty* P) override;
	//转换
	virtual FString BuildCppFuncPreCall(UProperty* P) override;
	virtual FString BuildCppCallParam(UProperty* P) override;
	//转换
	virtual FString BuildCppFuncPostSet(UProperty* P) override;
	virtual FString BuildCppFuncReturn(UProperty* P) override;

	//返回带前缀的C#名称
	virtual FString GetCSharpTypeName(UProperty* P) override;
	virtual FString GetCSharpMemberTypeName(UProperty* P) override;
	virtual FString GetCSharpParamTypeName(UProperty* P) override;
	//返回作为C#静态参数时的类型名称
	virtual FString GetCSharpMarshalTypeName(UProperty* P) override;

	virtual FMonoTextBuilder BuildCSharpClassProperty(UProperty* P) override;
	virtual FMonoTextBuilder BuildCSharpStructProperty(const FString& StructName, UProperty* P) override;
	virtual FString GetCSharpDefaultParameterValue(UFunction* Function, UProperty* ParamProperty) override;
};

class FloatTypePropertyHandler :public PropertyHandlerBase
{
public:
	virtual FString GetCSharpDefaultParameterValue(UFunction* Function, UProperty* ParamProperty) override
	{
		FString Value = PropertyHandlerBase::GetCSharpDefaultParameterValue(Function, ParamProperty);
		if (Value.Len() > 0)
			return  Value + TEXT("f");
		else
			return Value;
	}
};

class TypeAsInt32PropertyHandler :public PropertyHandlerBase
{
public:
	//返回作为C++参数时的类型名称
	virtual FString GetCppMarshalTypeName(UProperty* P) override;
	//转换
	virtual FString BuildCppFuncPreCall(UProperty* P) override;
	virtual FString BuildCppCallParam(UProperty* P) override;
	//转换
	virtual FString BuildCppFuncPostSet(UProperty* P) override;
	virtual FString BuildCppFuncReturn(UProperty* P) override;


	virtual FString GetCSharpParamTypeName(UProperty* P) override;
	//返回作为C#静态参数时的类型名称
	virtual FString GetCSharpMarshalTypeName(UProperty* P) override;

	virtual FString BuildCSharpFuncPreCall(UProperty* P) override;
	virtual FString BuildCSharpCallParam(UProperty* P) override;
	virtual FString BuildCSharpFuncPostSet(UProperty* P) override;
	virtual FString BuildCSharpFuncReturn(UProperty* P) override;
};

class ByteTypePropertyHandler :public TypeAsInt32PropertyHandler
{
public:
	virtual FString GetCSharpTypeName(UProperty* P) override;
};

class Int32TypePropertyHandler :public PropertyHandlerBase
{
public:
	virtual FString GetCSharpTypeName(UProperty* P) override;

};
class Int16TypePropertyHandler :public PropertyHandlerBase
{
public:
	virtual FString GetCSharpTypeName(UProperty* P) override
	{
		return "short";
	}
};
class Int64TypePropertyHandler :public PropertyHandlerBase
{
public:
	virtual FString GetCSharpTypeName(UProperty* P) override
	{
		return "long";
	}
};

class UInt32TypePropertyHandler :public PropertyHandlerBase
{
public:
	virtual FString GetCSharpTypeName(UProperty* P) override;
};

class UInt64TypePropertyHandler :public PropertyHandlerBase
{
public:
	virtual FString GetCSharpTypeName(UProperty* P) override
	{
		return "ulong";
	}
};
class UInt16TypePropertyHandler :public PropertyHandlerBase
{
public:
	virtual FString GetCSharpTypeName(UProperty* P) override
	{
		return "ushort";
	}
};

class BoolTypePropertyHandler :public PropertyHandlerBase
{
public:
	//返回作为C++参数时的类型名称
	virtual FString GetCppMarshalTypeName(UProperty* P) override;
	//转换
	virtual FString BuildCppFuncPreCall(UProperty* P) override;
	virtual FString BuildCppCallParam(UProperty* P) override;
	//转换
	virtual FString BuildCppFuncPostSet(UProperty* P) override;
	virtual FString BuildCppFuncReturn(UProperty* P) override;
	virtual FMonoTextBuilder BuildCppProperty(const FString& FieldName, UProperty* P)override;

	virtual FString GetCSharpTypeName(UProperty* P) override;
	virtual FString GetCSharpParamTypeName(UProperty* P) override;
	//返回作为C#静态参数时的类型名称
	virtual FString GetCSharpMarshalTypeName(UProperty* P) override;

	virtual FString BuildCSharpFuncPreCall(UProperty* P) override;
	virtual FString BuildCSharpCallParam(UProperty* P) override;
	virtual FString BuildCSharpFuncPostSet(UProperty* P) override;
	virtual FString BuildCSharpFuncReturn(UProperty* P) override;

	virtual FMonoTextBuilder BuildCSharpClassProperty(UProperty* P) override;
	virtual FMonoTextBuilder BuildCSharpStructProperty(const FString& StructName, UProperty* P) override;
};



class ObjectTypePropertyHandler :public PropertyHandlerBase
{
public:
	virtual FString GetCppTypeName(UProperty* P) override;
	virtual FString GetCppParamTypeName(UProperty* P) override;
	//返回作为C++参数时的类型名称
	virtual FString GetCppMarshalTypeName(UProperty* P) override;

	virtual FString GetCSharpMemberTypeName(UProperty* P) override;
	virtual FString GetCSharpParamTypeName(UProperty* P) override;
	//返回作为C#静态参数时的类型名称
	virtual FString GetCSharpMarshalTypeName(UProperty* P) override;

	virtual FString BuildCSharpFuncPreCall(UProperty* P) override;
	virtual FString BuildCSharpCallParam(UProperty* P) override;
	virtual FString BuildCSharpFuncPostSet(UProperty* P) override;
	virtual FString BuildCSharpFuncReturn(UProperty* P) override;

	virtual FMonoTextBuilder BuildCSharpClassProperty(UProperty* P) override;
	virtual FMonoTextBuilder BuildCSharpStructProperty(const FString& StructName, UProperty* P) override;


	//virtual FString GetCSharpDefaultParameterValue(UFunction* Function, UProperty* ParamProperty) override
	//{
	//	FString Value = PropertyHandlerBase::GetCSharpDefaultParameterValue(Function, ParamProperty);
	//	if (Value.Len() > 0)
	//		return  FString::Printf(TEXT("default(%s)"), *GetCSharpTypeName(ParamProperty));
	//	else
	//		return Value;
	//}
};

class ClassTypePropertyHandler :public ObjectTypePropertyHandler
{
public:
	virtual FString BuildCSharpCallParam(UProperty* P) override;
	virtual FMonoTextBuilder BuildCSharpClassProperty(UProperty* P) override;
	virtual FMonoTextBuilder BuildCSharpStructProperty(const FString& StructName, UProperty* P) override;
};

class EnumTypePropertyHandler :public PropertyHandlerBase
{
public:
	//返回作为C++参数时的类型名称
	//virtual FString GetCppParamTypeName(UProperty* P) override;
	virtual FString GetCppMarshalTypeName(UProperty* P) override;
	//转换
	virtual FString BuildCppFuncPreCall(UProperty* P) override;
	virtual FString BuildCppCallParam(UProperty* P) override;
	//转换
	virtual FString BuildCppFuncPostSet(UProperty* P) override;
	virtual FString BuildCppFuncReturn(UProperty* P) override;

	virtual FString GetCSharpTypeName(UProperty* P) override;
	virtual FString GetCSharpParamTypeName(UProperty* P) override;
	//返回作为C#静态参数时的类型名称
	virtual FString GetCSharpMarshalTypeName(UProperty* P) override;

	virtual FString BuildCSharpFuncPreCall(UProperty* P) override;
	virtual FString BuildCSharpCallParam(UProperty* P) override;
	virtual FString BuildCSharpFuncPostSet(UProperty* P) override;
	virtual FString BuildCSharpFuncReturn(UProperty* P) override;

	virtual FString GetCSharpDefaultParameterValue(UFunction* Function, UProperty* ParamProperty) override;
};

class PropertyHandlerFactroy;

class ArrayTypePropertyHandler :public PropertyHandlerBase
{
public:
	PropertyHandlerFactroy* Factory;

	virtual FString GetCppTypeName(UProperty* P) override;
	virtual FString GetCppParamTypeName(UProperty* P) override;
	virtual FString GetCppMarshalTypeName(UProperty* P) override;
	//转换
	virtual FString BuildCppFuncPreCall(UProperty* P) override;
	virtual FString BuildCppCallParam(UProperty* P) override;
	//转换
	virtual FString BuildCppFuncPostSet(UProperty* P) override;
	virtual FString BuildCppFuncReturn(UProperty* P) override;

	//返回作为C++参数时的类型名称
	virtual FString GetCSharpTypeName(UProperty* P) override;
	virtual FString GetCSharpMemberTypeName(UProperty* P) override;
	virtual FString GetCSharpParamTypeName(UProperty* P) override;
	//返回作为C#静态参数时的类型名称
	virtual FString GetCSharpMarshalTypeName(UProperty* P) override;

	virtual FString BuildCSharpFuncPreCall(UProperty* P) override;
	virtual FString BuildCSharpCallParam(UProperty* P) override;
	virtual FString BuildCSharpFuncPostSet(UProperty* P) override;
	virtual FString BuildCSharpFuncReturn(UProperty* P) override;

	virtual FMonoTextBuilder BuildCSharpClassProperty(UProperty* P) override;
	virtual FMonoTextBuilder BuildCSharpStructProperty(const FString& StructName, UProperty* P) override;

	FString GetPropertyFullNameCS(UProperty* Property);
};



class MulticastDelegatePropertyHandler :public PropertyHandlerBase
{
public:
	//不支持函数
	virtual FString GetCppTypeName(UProperty* P) override
	{
		return "";
	}

	virtual FMonoTextBuilder BuildCSharpClassProperty(UProperty* P) override;
	virtual FMonoTextBuilder BuildCSharpStructProperty(const FString& StructName, UProperty* P) override;
};


FString PropertyHandlerBase::GetCSharpDefaultParameterValue(UFunction* Function, UProperty* ParamProperty)
{
	//TODO: respect defaults specified as metadata, not C++ default params?
	//		The syntax for those seems to be a bit looser, but they're pretty rare...
	//		When specified that way, the key will just be the param name.

	// Return the default value exactly as specified for C++.
	// Subclasses may intercept it if it needs to be massaged for C# purposes.
#if WITH_EDITOR || HACK_HEADER_GENERATOR
	const FString MetadataCppDefaultValueKey = FString::Printf(TEXT("CPP_Default_%s"), *ParamProperty->GetName());
	return Function->GetMetaData(*MetadataCppDefaultValueKey);
#else
	return FString();
#endif
}

FString PropertyHandlerBase::GetNullReturnCSharpValue(UFunction* Function, UProperty* ParamProperty)
{
	return  FString::Printf(TEXT("default(%s)"), *GetCSharpTypeName(ParamProperty));
}
FString PropertyHandlerBase::GetCppTypeName(UProperty* Property)
{
	static FString EnumDecl(TEXT("enum "));
	static FString StructDecl(TEXT("struct "));
	static FString ClassDecl(TEXT("class "));
	static FString TEnumAsByteDecl(TEXT("TEnumAsByte<enum "));
	static FString TSubclassOfDecl(TEXT("TSubclassOf<class "));

	FString PropertyType = Property->GetCPPType(NULL, 0);
	// Strip any forward declaration keywords
	if (PropertyType.StartsWith(EnumDecl) || PropertyType.StartsWith(StructDecl) || PropertyType.StartsWith(ClassDecl))
	{
		int FirstSpaceIndex = PropertyType.Find(TEXT(" "));
		PropertyType = PropertyType.Mid(FirstSpaceIndex + 1);
	}
	else if (PropertyType.StartsWith(TEnumAsByteDecl))
	{
		int FirstSpaceIndex = PropertyType.Find(TEXT(" "));
		PropertyType = TEXT("TEnumAsByte<") + PropertyType.Mid(FirstSpaceIndex + 1);
	}
	else if (PropertyType.StartsWith(TSubclassOfDecl))
	{
		int FirstSpaceIndex = PropertyType.Find(TEXT(" "));
		PropertyType = TEXT("TSubclassOf<") + PropertyType.Mid(FirstSpaceIndex + 1);
	}
	return PropertyType;
}
FString PropertyHandlerBase::GetCppParamTypeName(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return GetCppTypeName(P) + "*";
	else
		return GetCppTypeName(P);
}

FString PropertyHandlerBase::GetCppMarshalTypeName(UProperty* P)
{
	return GetCppParamTypeName(P);
}

FString PropertyHandlerBase::GetCppMarshalReturnTypeName(UProperty* P)
{
	return GetCppMarshalTypeName(P);
}

//是否需要转换参数
FString PropertyHandlerBase::BuildCppFuncPreCall(UProperty* P)
{
	return "";
}

FString PropertyHandlerBase::BuildCppCallParam(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return "*" + P->GetName();
	else
		return P->GetName();
}
//转换
FString PropertyHandlerBase::BuildCppFuncPostSet(UProperty* P)
{
	return "";
}
//转换
FString PropertyHandlerBase::BuildCppFuncReturn(UProperty* P)
{
	return "return ___ret;";
}


FString PropertyHandlerBase::GetCSharpTypeName(UProperty* P)
{
	return GetCppTypeName(P);
}

FString PropertyHandlerBase::GetCSharpMemberTypeName(UProperty* P)
{
	return GetCSharpTypeName(P);
}
FString PropertyHandlerBase::GetCSharpParamTypeName(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return "out " + GetCSharpTypeName(P);
	else
		return GetCSharpTypeName(P);
}
//返回作为C#静态参数时的类型名称
FString PropertyHandlerBase::GetCSharpMarshalTypeName(UProperty* P)
{
	return GetCSharpParamTypeName(P);
}
//返回作为C#静态参数时的类型名称
FString PropertyHandlerBase::GetCSharpMarshalReturnTypeName(UProperty* P)
{
	return GetCSharpMarshalTypeName(P);
}

FString PropertyHandlerBase::BuildCSharpFuncPreCall(UProperty* P)
{
	return "";
}
FString PropertyHandlerBase::BuildCSharpCallParam(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return "out " + P->GetName();
	else
		return P->GetName();
}
FString PropertyHandlerBase::BuildCSharpFuncPostSet(UProperty* P)
{
	return "";
}
FString PropertyHandlerBase::BuildCSharpFuncReturn(UProperty* P)
{
	return "return ___ret;";
}
FMonoTextBuilder PropertyHandlerBase::BuildCSharpClassProperty(UProperty* P)
{
	FMonoTextBuilder Text;
	FString PropertyOffsetName = FString::Printf(TEXT("%s__Offset"), *P->GetName());
	Text.AppendLine(FString::Printf(TEXT("public %s %s"), *GetCSharpMemberTypeName(P), *P->GetName()));
	Text.OpenBrace();

	Text.AppendLine(FString::Printf(TEXT("get{ CheckIsValid();return (%s)Marshal.PtrToStructure(_this.Get()+%s, typeof(%s));}"),
		*GetCSharpMemberTypeName(P), *PropertyOffsetName, *GetCSharpMemberTypeName(P)));
	bool bSetter = P->PropertyFlags & CPF_Edit;
	if (bSetter)
	{
		Text.AppendLine(FString::Printf(TEXT("set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+%s, false);}"),
			*PropertyOffsetName));
	}

	Text.CloseBrace();

	return Text;
}
FMonoTextBuilder PropertyHandlerBase::BuildCSharpStructProperty(const FString& StructName, UProperty* P)
{
	FMonoTextBuilder Text;

	Text.AppendLine(FString::Printf(TEXT("[FieldOffset(%d)]"), P->GetOffset_ForInternal()));
	Text.AppendLine(FString::Printf(TEXT("public %s %s;"), *GetCSharpMemberTypeName(P), *P->GetName()));

	return Text;
}

bool PropertyHandlerBase::IsOutParam(UProperty* P)
{
	return (P->GetPropertyFlags() & CPF_ReturnParm) == 0 && (P->PropertyFlags & CPF_OutParm) != 0 && (P->PropertyFlags & CPF_ConstParm) == 0;
}

//////////////////////// IntProperty  ///////////////////////////////////////
FString Int32TypePropertyHandler::GetCSharpTypeName(UProperty* P)
{
	return "int";
}

//////////////////////// UIntProperty  ///////////////////////////////////////
FString UInt32TypePropertyHandler::GetCSharpTypeName(UProperty* P)
{
	return "uint";
}

//////////////////////// BoolProperty //////////////////////////////////////

FString BoolTypePropertyHandler::GetCppMarshalTypeName(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return "int32*";
	else
		return "int32";
}
//是否需要转换参数
FString BoolTypePropertyHandler::BuildCppFuncPreCall(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("bool %s_temp;"), *P->GetName());
	else
		return "";
}
FString BoolTypePropertyHandler::BuildCppCallParam(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("%s_temp"), *P->GetName());
	else
		return  P->GetName() + ">0?true:false";
}
//转换
FString BoolTypePropertyHandler::BuildCppFuncPostSet(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("*%s=%s_temp!=0;"), *P->GetName(), *P->GetName());
	else
		return "";
}
//转换
FString BoolTypePropertyHandler::BuildCppFuncReturn(UProperty* P)
{
	return "return ___ret?1:0;";
}
FMonoTextBuilder BoolTypePropertyHandler::BuildCppProperty(const FString& ClassName,UProperty* P)
{
	FMonoTextBuilder FunctionBody;

	//get
	{
		FunctionBody.AppendLine(FString::Printf(TEXT("static int Get_%s(void *Obj)"), *P->GetName()));
		FunctionBody.OpenBrace();
		FunctionBody.AppendLine(FString::Printf(TEXT("static UBoolProperty* Property = Cast<UBoolProperty>(FindScriptPropertyHelper(%s::StaticClass(), TEXT(\"%s\")));"), *ClassName, *P->GetName()));
		FunctionBody.AppendLine(TEXT("return Property->GetPropertyValue(Property->ContainerPtrToValuePtr<uint8>(Obj))?1:0;"));
		FunctionBody.CloseBrace();
	}

	//set
	{
		FunctionBody.AppendLine(FString::Printf(TEXT("static void Set_%s(void *Obj,int Value)"), *P->GetName()));
		FunctionBody.OpenBrace();
		FunctionBody.AppendLine(FString::Printf(TEXT("static UBoolProperty* Property = Cast<UBoolProperty>(FindScriptPropertyHelper(%s::StaticClass(), TEXT(\"%s\")));"), *ClassName, *P->GetName()));
		FunctionBody.AppendLine(TEXT("Property->SetPropertyValue(Property->ContainerPtrToValuePtr<uint8>(Obj), Value!=0?true:false);"));
		FunctionBody.CloseBrace();
	}

	return FunctionBody;
}
FString BoolTypePropertyHandler::GetCSharpTypeName(UProperty* P)
{
	return "bool";
}

FString BoolTypePropertyHandler::GetCSharpParamTypeName(UProperty* P)
{
	return PropertyHandlerBase::GetCSharpParamTypeName(P);
}
//返回作为C#静态参数时的类型名称
FString BoolTypePropertyHandler::GetCSharpMarshalTypeName(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return "out int";
	else
		return "int";
}

FString BoolTypePropertyHandler::BuildCSharpFuncPreCall(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("int %s_temp;"), *P->GetName());
	else
		return "";
}
FString BoolTypePropertyHandler::BuildCSharpCallParam(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return "out " + P->GetName() + "_temp";
	else
		return P->GetName() + "?1:0";
}
FString BoolTypePropertyHandler::BuildCSharpFuncPostSet(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("%s=%s_temp!=0;"), *P->GetName(), *P->GetName());
	else
		return "";
}
FString BoolTypePropertyHandler::BuildCSharpFuncReturn(UProperty* P)
{
	return "return ___ret!=0;";
}


class COREUOBJECT_API UBoolPropertyData : public UProperty
{
	DECLARE_CASTED_CLASS_INTRINSIC_NO_CTOR(UBoolPropertyData, UProperty, 0, TEXT("/Script/CoreUObject"), CASTCLASS_None, NO_API)

public:
	/** Size of the bitfield/bool property. Equal to ElementSize but used to check if the property has been properly initialized (0-8, where 0 means uninitialized). */
	uint8 FieldSize;
	/** Offset from the memeber variable to the byte of the property (0-7). */
	uint8 ByteOffset;
	/** Mask of the byte byte with the property value. */
	uint8 ByteMask;
	/** Mask of the field with the property value. Either equal to ByteMask or 255 in case of 'bool' type. */
	uint8 FieldMask;

	UBoolPropertyData(const FObjectInitializer& ObjectInitializer = FObjectInitializer::Get()) {}

};

FMonoTextBuilder BoolTypePropertyHandler::BuildCSharpClassProperty(UProperty* P)
{
	FMonoTextBuilder Text;
	FString PropertyOffsetName = FString::Printf(TEXT("%s__Offset"), *P->GetName());

	Text.AppendLine(FString::Printf(TEXT("public %s %s"), *GetCSharpTypeName(P), *P->GetName()));
	Text.OpenBrace();

	UBoolProperty* UE_BoolProp = Cast<UBoolProperty>(P);
	UBoolPropertyData* BoolProp = (UBoolPropertyData*)((void*)UE_BoolProp);

	FString Getter = FString::Printf(TEXT("get{ CheckIsValid();return BoolWrap.Get(_this.Get(), %s, %d, %d, %d, %d);}"),
		*PropertyOffsetName, BoolProp->FieldSize, BoolProp->ByteOffset, BoolProp->ByteMask, BoolProp->FieldMask);

	Text.AppendLine(Getter);

	bool bSetter = P->PropertyFlags & CPF_Edit;
	if (bSetter)
	{

		FString Setter = FString::Printf(TEXT("set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), %s, %d,%d,%d,%d);}"),
			*PropertyOffsetName, BoolProp->FieldSize, BoolProp->ByteOffset, BoolProp->ByteMask, BoolProp->FieldMask);
		Text.AppendLine(Setter);
	}

	Text.CloseBrace();

/*
	Text.AppendLine("[MethodImplAttribute(MethodImplOptions.InternalCall)]");
	Text.AppendLine(FString::Printf(TEXT("extern static int Get_%s(IntPtr This);"), *P->GetName()));
	Text.AppendLine("[MethodImplAttribute(MethodImplOptions.InternalCall)]");
	Text.AppendLine(FString::Printf(TEXT("extern static void Set_%s(IntPtr This,int Value);"), *P->GetName()));

	Text.AppendLine(FString::Printf(TEXT("public %s %s"), *GetCSharpTypeName(P), *P->GetName()));
	Text.OpenBrace();
	Text.AppendLine(FString::Printf(TEXT("get{ CheckIsValid();return Get_%s(_this)!=0;}"),
		*P->GetName()));

	bool bSetter = P->PropertyFlags & CPF_Edit;
	if (bSetter)
	{
		FString Setter = FString::Printf(TEXT("set{ CheckIsValid(); Set_%s(_this,value?1:0);}"),
			*P->GetName());
		Text.AppendLine(Setter);
	}

	Text.CloseBrace();*/

	return Text;
}
FMonoTextBuilder BoolTypePropertyHandler::BuildCSharpStructProperty(const FString& StructName, UProperty* P)
{
	FMonoTextBuilder Text;
	FString PropertyName = P->GetName();
	int32 offset = P->GetOffset_ForInternal();
	UBoolProperty* UE_BoolProp = Cast<UBoolProperty>(P);
	UBoolPropertyData* BoolProp = (UBoolPropertyData*)((void*)UE_BoolProp);

	Text.AppendLine(FString::Printf(TEXT("public %s %s"), *GetCSharpTypeName(P), *PropertyName));
	Text.OpenBrace();
	Text.AppendLine(FString::Printf(TEXT("get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), %d, %d, %d, %d, %d); } }}"),
		offset, BoolProp->FieldSize, BoolProp->ByteOffset, BoolProp->ByteMask, BoolProp->FieldMask));
	Text.AppendLine(FString::Printf(TEXT("set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), %d, %d, %d, %d, %d); } }}"),
		offset, BoolProp->FieldSize, BoolProp->ByteOffset, BoolProp->ByteMask, BoolProp->FieldMask));
	Text.CloseBrace();

	//Text.AppendLine("[MethodImplAttribute(MethodImplOptions.InternalCall)]");
	//Text.AppendLine(FString::Printf(TEXT("extern static int Get_%s(ref %s This);"),*StructName, *P->GetName()));
	//Text.AppendLine("[MethodImplAttribute(MethodImplOptions.InternalCall)]");
	//Text.AppendLine(FString::Printf(TEXT("extern static void Set_%s(ref %s This,int Value);"), *StructName, *P->GetName()));

	//Text.AppendLine(FString::Printf(TEXT("public bool %s"), *P->GetName()));
	//Text.OpenBrace();
	//Text.AppendLine(FString::Printf(TEXT("get{ CheckIsValid();return Get_%s(ref this)!=0;}"),
	//	*P->GetName()));

	//bool bSetter = P->PropertyFlags & CPF_Edit;
	//if (bSetter)
	//{
	//	FString Setter = FString::Printf(TEXT("set{ CheckIsValid(); Set_%s(ref this,value?1:0);}"),
	//		*P->GetName());
	//	Text.AppendLine(Setter);
	//}

	//Text.CloseBrace();

	return Text;
}

//////////////////////////////AsInt32Type ///////////////////////////////////////////////////

FString TypeAsInt32PropertyHandler::GetCppMarshalTypeName(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return "int32*";
	else
		return "int32";
}
//是否需要转换参数
FString TypeAsInt32PropertyHandler::BuildCppFuncPreCall(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("%s %s_temp;"), *GetCppTypeName(P), *P->GetName());
	else
		return "";
}
FString TypeAsInt32PropertyHandler::BuildCppCallParam(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("%s_temp"), *P->GetName());
	else
		return  P->GetName();
}
//转换
FString TypeAsInt32PropertyHandler::BuildCppFuncPostSet(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("*%s=(%s)%s_temp;"), *P->GetName(), *GetCppTypeName(P), *P->GetName());
	else
		return "";
}
//转换
FString TypeAsInt32PropertyHandler::BuildCppFuncReturn(UProperty* P)
{
	return FString::Printf(TEXT("return (%s)___ret;"), *GetCppTypeName(P));
}

FString TypeAsInt32PropertyHandler::GetCSharpParamTypeName(UProperty* P)
{
	return PropertyHandlerBase::GetCSharpParamTypeName(P);
}
//返回作为C#静态参数时的类型名称
FString TypeAsInt32PropertyHandler::GetCSharpMarshalTypeName(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return "out int";
	else
		return "int";
}

FString TypeAsInt32PropertyHandler::BuildCSharpFuncPreCall(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("int %s_temp;"), *P->GetName());
	else
		return "";
}
FString TypeAsInt32PropertyHandler::BuildCSharpCallParam(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return "out " + P->GetName() + "_temp";
	else
		return P->GetName();
}
FString TypeAsInt32PropertyHandler::BuildCSharpFuncPostSet(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("%s=(%s)%s_temp;"), *P->GetName(), *GetCSharpTypeName(P), *P->GetName());
	else
		return "";
}
FString TypeAsInt32PropertyHandler::BuildCSharpFuncReturn(UProperty* P)
{
	return FString::Printf(TEXT("return (%s)___ret;"), *GetCSharpTypeName(P));
}


FString ByteTypePropertyHandler::GetCSharpTypeName(UProperty* P)
{
	return "byte";
}









//////////////////////////////ObjectProperty////////////////////////////////////////////////

FString ObjectTypePropertyHandler::GetCppTypeName(UProperty* P)
{
	return PropertyHandlerBase::GetCppTypeName(P).Replace(TEXT("*"), TEXT(""));
}


FString ObjectTypePropertyHandler::GetCppParamTypeName(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return PropertyHandlerBase::GetCppTypeName(P) + "*";
	else
		return PropertyHandlerBase::GetCppTypeName(P);
}

FString ObjectTypePropertyHandler::GetCppMarshalTypeName(UProperty* P)
{
	return GetCppParamTypeName(P);
}
FString  ObjectTypePropertyHandler::GetCSharpMemberTypeName(UProperty* P)
{
	return GetCSharpTypeName(P);
}

FString ObjectTypePropertyHandler::GetCSharpParamTypeName(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return "out " + GetCSharpTypeName(P);
	else
		return GetCSharpTypeName(P);
}
//返回作为C#静态参数时的类型名称
FString ObjectTypePropertyHandler::GetCSharpMarshalTypeName(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return "out IntPtr";
	else
		return "IntPtr";
}

FString ObjectTypePropertyHandler::BuildCSharpFuncPreCall(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("IntPtr %s_temp;"), *P->GetName());

	return "";
}
FString ObjectTypePropertyHandler::BuildCSharpCallParam(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("out %s_temp"), *P->GetName());
	else
		return FString::Printf(TEXT("%s"), *P->GetName());
}
FString ObjectTypePropertyHandler::BuildCSharpFuncPostSet(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("%s=new %s(){ _this=%s_temp};"), *P->GetName(), *GetCSharpTypeName(P), *P->GetName());
	else
		return "";
}
FString ObjectTypePropertyHandler::BuildCSharpFuncReturn(UProperty* P)
{
	return FString::Printf(TEXT("if(___ret==IntPtr.Zero) return null; %s ___ret2= new %s(){ _this = ___ret }; return ___ret2;"),
		*GetCSharpTypeName(P), *GetCSharpTypeName(P));
}

FMonoTextBuilder ObjectTypePropertyHandler::BuildCSharpClassProperty(UProperty* P)
{
	FMonoTextBuilder Text;
	FString PropertyOffsetName = FString::Printf(TEXT("%s__Offset"), *P->GetName());
	Text.AppendLine(FString::Printf(TEXT("public %s %s"), *GetCSharpTypeName(P), *P->GetName()));
	Text.OpenBrace();

	bool bSetter = P->PropertyFlags & CPF_Edit;

	FString Getter = FString::Printf(TEXT("get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + %s); if (v == IntPtr.Zero)return null; %s retValue = new %s(); retValue._this = v; return retValue; }"),
		*PropertyOffsetName, *GetCSharpTypeName(P), *GetCSharpTypeName(P));
	Text.AppendLine(Getter);

	if (bSetter)
	{
		FString Setter = FString::Printf(TEXT("set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + %s, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + %s, value._this.Get()); }"),
			*PropertyOffsetName, *PropertyOffsetName);
		Text.AppendLine(Setter);
	}

	Text.CloseBrace();

	return Text;
}
FMonoTextBuilder ObjectTypePropertyHandler::BuildCSharpStructProperty(const FString& StructName, UProperty* P)
{
	return FMonoTextBuilder();
}

FString ClassTypePropertyHandler::BuildCSharpCallParam(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("out %s"), *P->GetName());
	else if (GetCSharpTypeName(P).Contains("TSubclassOf"))
		return FString::Printf(TEXT("%s.NativeClass"), *P->GetName());
	else  //UClass
		return FString::Printf(TEXT("%s"), *P->GetName());
}
FMonoTextBuilder ClassTypePropertyHandler::BuildCSharpClassProperty(UProperty* P)
{
	FMonoTextBuilder Text;
	FString PropertyOffsetName = FString::Printf(TEXT("%s__Offset"), *P->GetName());
	Text.AppendLine(FString::Printf(TEXT("public %s %s"), *GetCSharpTypeName(P), *P->GetName()));
	Text.OpenBrace();

	bool bSetter = P->PropertyFlags & CPF_Edit;

	FString Getter = FString::Printf(TEXT("get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + %s); return v; }"),
		*PropertyOffsetName);
	Text.AppendLine(Getter);

	if (bSetter)
	{
		FString Setter = FString::Printf(TEXT("set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + %s, value); }"),
			*PropertyOffsetName, *PropertyOffsetName);
		Text.AppendLine(Setter);
	}

	Text.CloseBrace();

	return Text;
}
FMonoTextBuilder ClassTypePropertyHandler::BuildCSharpStructProperty(const FString& StructName, UProperty* P)
{
	return FMonoTextBuilder();
}


//////////////////////////EnumProperty////////////////////////////////////////////////
//
//FString EnumTypePropertyHandler::GetCppParamTypeName(UProperty* P)
//{
//	UByteProperty* ByteProp = Cast<UByteProperty>(P);
//	return ByteProp->GetIntPropertyEnum()->GetName();
//}

FString EnumTypePropertyHandler::GetCppMarshalTypeName(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return "int32*";
	else
		return "int32";
}
//是否需要转换参数
FString EnumTypePropertyHandler::BuildCppFuncPreCall(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("%s %s_temp;"), *GetCppTypeName(P), *P->GetName());
	else
		return "";
}
FString EnumTypePropertyHandler::BuildCppCallParam(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("%s_temp"), *P->GetName());
	else
		return  FString::Printf(TEXT("(%s)%s"), *GetCppTypeName(P), *P->GetName());
}
//转换
FString EnumTypePropertyHandler::BuildCppFuncPostSet(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("*%s=(int)%s_temp;"), *P->GetName(), *P->GetName());
	else
		return "";
}
//转换
FString EnumTypePropertyHandler::BuildCppFuncReturn(UProperty* P)
{
	return "return (int)___ret;";
}

FString EnumTypePropertyHandler::GetCSharpTypeName(UProperty* P)
{
	UByteProperty* ByteProp = Cast<UByteProperty>(P);
	return ByteProp->GetIntPropertyEnum()->GetName();
}

FString EnumTypePropertyHandler::GetCSharpParamTypeName(UProperty* P)
{
	return GetCSharpTypeName(P);
}
//返回作为C#静态参数时的类型名称
FString EnumTypePropertyHandler::GetCSharpMarshalTypeName(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return "out int";
	else
		return "int";
}

FString EnumTypePropertyHandler::BuildCSharpFuncPreCall(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("int %s_temp;"), *P->GetName());
	else
		return "";
}
FString EnumTypePropertyHandler::BuildCSharpCallParam(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return "out " + P->GetName() + "_temp";
	else
		return "(int)" + P->GetName();
}
FString EnumTypePropertyHandler::BuildCSharpFuncPostSet(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("%s=(%s)%s_temp;"), *P->GetName(), *GetCSharpParamTypeName(P), *P->GetName());
	else
		return "";
}
FString EnumTypePropertyHandler::BuildCSharpFuncReturn(UProperty* P)
{
	return FString::Printf(TEXT("return (%s)___ret;"), *GetCSharpParamTypeName(P));
}

FString EnumTypePropertyHandler::GetCSharpDefaultParameterValue(UFunction* Function, UProperty* ParamProperty)
{
	FString Value = PropertyHandlerBase::GetCSharpDefaultParameterValue(Function, ParamProperty);
	if (Value.Len()>0)
		return GetCSharpTypeName(ParamProperty) + TEXT(".") + Value;
	return Value;
}
/////////////////////////////////ArrayProperty///////////////////////////////////////


FString ArrayTypePropertyHandler::GetCppTypeName(UProperty* P)
{
	UArrayProperty* ArrayProp = Cast<UArrayProperty>(P);
	return FString::Printf(TEXT("TArray<%s>"), *Factory->GetCppParamTypeName(ArrayProp->Inner));
}


FString ArrayTypePropertyHandler::GetCppParamTypeName(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return GetCppTypeName(P);
	else
		return GetCppTypeName(P);
}

FString ArrayTypePropertyHandler::GetCppMarshalTypeName(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return TEXT("MonoArray**");
	else
		return TEXT("MonoArray*");
}

//转换
FString ArrayTypePropertyHandler::BuildCppFuncPreCall(UProperty* P)
{
	UArrayProperty* ArrayProp = Cast<UArrayProperty>(P);
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("%s %s_temp;"), *GetCppParamTypeName(ArrayProp), *P->GetName());
	else
		return "";
}
FString ArrayTypePropertyHandler::BuildCppCallParam(UProperty* P)
{
	UArrayProperty* ArrayProp = Cast<UArrayProperty>(P);
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("%s_temp"), *P->GetName());
	else
		return FString::Printf(TEXT("MonoArrayToTArray<%s>(%s)"), *Factory->GetCppParamTypeName(ArrayProp->Inner), *P->GetName());
}

FString ArrayTypePropertyHandler::GetPropertyFullNameCS(UProperty* Property)
{
	UProperty* ReturnValue = Property;
	if (ReturnValue->IsA(UIntProperty::StaticClass()))
	{
		return TEXT("System.Int32,mscorlib");
	}
	else if (ReturnValue->IsA(UByteProperty::StaticClass()))
	{
		return TEXT("System.Byte,mscorlib");
	}
	else if (ReturnValue->IsA(UDoubleProperty::StaticClass()))
	{
		return TEXT("System.Single,mscorlib");
	}
	else if (ReturnValue->IsA(UFloatProperty::StaticClass()))
	{
		return TEXT("System.Float,mscorlib");
	}
	else if (ReturnValue->IsA(UStrProperty::StaticClass()))
	{
		return TEXT("UnrealEngine.FString,UnrealEngine");
	}
	else if (ReturnValue->IsA(UNameProperty::StaticClass()))
	{
		return TEXT("UnrealEngine.FName,UnrealEngine");
	}
	else if (UArrayProperty* ArrayProp = Cast<UArrayProperty>(Property))
	{
		//if (ArrayProp->Inner->IsA(UObjectPropertyBase::StaticClass()))
		//{
		//	Initializer = TEXT("IntPtr[]");
		//}
		//else
		//{
		//	Initializer = FString::Printf(TEXT("%s[]"), *GetPropertyTypeCS(ArrayProp->Inner));
		//}
	}
	else if (ReturnValue->IsA(UBoolProperty::StaticClass()))
	{
		return TEXT("System.Boolean,mscorlib");
	}
	else if (ReturnValue->IsA(UInt8Property::StaticClass()))
	{
		return TEXT("System.Byte,mscorlib");
	}
	else if (Property->IsA(UInt16Property::StaticClass()))
	{
		return TEXT("System.Int16,mscorlib");
	}
	else if (Property->IsA(UInt64Property::StaticClass()))
	{
		return TEXT("System.Int64,mscorlib");
	}
	else if (Property->IsA(UUInt16Property::StaticClass()))
	{
		return TEXT("System.UInt16,mscorlib");
	}
	else if (Property->IsA(UUInt32Property::StaticClass()))
	{
		return TEXT("System.UInt32,mscorlib");
	}
	else if (Property->IsA(UUInt64Property::StaticClass()))
	{
		return TEXT("System.UInt64,mscorlib");
	}
	else if (ReturnValue->IsA(UStructProperty::StaticClass()))
	{
		return FString::Printf(TEXT("UnrealEngine.%s,UnrealEngine"), *Factory->GetCSharpTypeName(ReturnValue));
	}
	else if (ReturnValue->IsA(UObjectPropertyBase::StaticClass()))
	{
		return TEXT("System.IntPtr,mscorlib");
	}

	return TEXT("System.Void");
}

//转换
FString ArrayTypePropertyHandler::BuildCppFuncPostSet(UProperty* P)
{
	UArrayProperty* ArrayProp = Cast<UArrayProperty>(P);
	bool out = IsOutParam(P);
	if (out)
		return FString::Printf(TEXT("*%s=TArrayToMonoArray(%s_temp,\"%s\");"), *P->GetName(), *P->GetName(), *GetPropertyFullNameCS(ArrayProp->Inner));
	else
		return "";
}
FString ArrayTypePropertyHandler::BuildCppFuncReturn(UProperty* P)
{
	UArrayProperty* ArrayProp = Cast<UArrayProperty>(P);
	return FString::Printf(TEXT("return TArrayToMonoArray(___ret,\"%s\");"), *GetPropertyFullNameCS(ArrayProp->Inner));
}

FString ArrayTypePropertyHandler::GetCSharpTypeName(UProperty* P)
{
	UArrayProperty* ArrayProp = Cast<UArrayProperty>(P);
	return FString::Printf(TEXT("%s[]"), *Factory->GetCSharpTypeName(ArrayProp->Inner));
}


FString ArrayTypePropertyHandler::GetCSharpMemberTypeName(UProperty* P)
{
	UArrayProperty* ArrayProp = Cast<UArrayProperty>(P);
	return FString::Printf(TEXT("%s[]"), *Factory->GetCSharpMemberTypeName(ArrayProp->Inner));
}

FString ArrayTypePropertyHandler::GetCSharpParamTypeName(UProperty* P)
{
	bool out = IsOutParam(P);
	if (out)
		return "out " + GetCSharpMemberTypeName(P);
	else
		return GetCSharpMemberTypeName(P);
}
//返回作为C#静态参数时的类型名称
FString ArrayTypePropertyHandler::GetCSharpMarshalTypeName(UProperty* P)
{
	UArrayProperty* ArrayProp = Cast<UArrayProperty>(P);
	FString MarchalTypeName;

	if (ArrayProp->Inner->IsA(UObjectProperty::StaticClass()))	//Object类型需要封送为IntPtr[]
	{
		MarchalTypeName = TEXT("IntPtr[]");
	}
	else  //其他类型保持原始数组形式
	{
		MarchalTypeName = FString::Printf(TEXT("%s[]"), *Factory->GetCSharpMemberTypeName(ArrayProp->Inner));
	}

	bool out = IsOutParam(P);
	if (out)
		return "out " + MarchalTypeName;
	else
		return MarchalTypeName;
}

FString ArrayTypePropertyHandler::BuildCSharpFuncPreCall(UProperty* P)
{
	bool out = IsOutParam(P);
	UArrayProperty* ArrayProp = Cast<UArrayProperty>(P);

	if (out)
	{
		if (ArrayProp->Inner->IsA(UObjectPropertyBase::StaticClass()))
		{
			return FString::Printf(TEXT("IntPtr[] %s_temp;"), *P->GetName());
		}
	}
	return "";
}
FString ArrayTypePropertyHandler::BuildCSharpCallParam(UProperty* P)
{
	bool out = IsOutParam(P);
	UArrayProperty* ArrayProp = Cast<UArrayProperty>(P);

	if (out)
	{
		if (ArrayProp->Inner->IsA(UObjectPropertyBase::StaticClass()))
		{
			return FString::Printf(TEXT("out %s_temp"), *P->GetName());
		}
		else
		{
			return FString::Printf(TEXT("out %s"), *P->GetName());
		}
	}
	else
	{
		if (ArrayProp->Inner->IsA(UObjectPropertyBase::StaticClass()))
		{
			return FString::Printf(TEXT("MarshalUtil.ObjectArrayToIntPtrArray(%s)"), *P->GetName());
		}
		return FString::Printf(TEXT("%s"), *P->GetName());
	}
	return "";
}
FString ArrayTypePropertyHandler::BuildCSharpFuncPostSet(UProperty* P)
{
	bool out = IsOutParam(P);
	UArrayProperty* ArrayProp = Cast<UArrayProperty>(P);

	if (out)
	{
		if (ArrayProp->Inner->IsA(UObjectPropertyBase::StaticClass()))
		{

			return FString::Printf(TEXT("%s = MarshalUtil.IntPtrArrayToObjectArray<%s>(%s_temp);"), *P->GetName(), *Factory->GetCSharpMemberTypeName(ArrayProp->Inner), *P->GetName());
		}
	}
	return "";
}
FString ArrayTypePropertyHandler::BuildCSharpFuncReturn(UProperty* P)
{
	UArrayProperty* ArrayProp = Cast<UArrayProperty>(P);
	if (ArrayProp->Inner->IsA(UObjectPropertyBase::StaticClass()))
		return FString::Printf(TEXT("return MarshalUtil.IntPtrArrayToObjectArray<%s>(___ret);"), *Factory->GetCSharpMemberTypeName(ArrayProp->Inner));
	else
		return "return ___ret;";
}

FString GetCSharpTypeArrayInnerTypeName(UProperty* P_Inner, PropertyHandlerFactroy* Factory)
{
	UClassProperty* ClassP = Cast<UClassProperty>(P_Inner);
	if (ClassP != nullptr)
	{
		return "UClass";
	}
	return Factory->GetCSharpMemberTypeName(P_Inner);
}

FMonoTextBuilder ArrayTypePropertyHandler::BuildCSharpClassProperty(UProperty* P)
{
	UProperty* Property = P;
	UArrayProperty* ArrayProp = Cast<UArrayProperty>(Property);

	FMonoTextBuilder Text;
	FString PropertyName = P->GetName();
	FString PropertyOffsetName = FString::Printf(TEXT("%s__Offset"), *P->GetName());

	if (!ArrayProp->Inner->IsA(UObjectPropertyBase::StaticClass()))
	{
		Text.AppendLine(FString::Printf(TEXT("public TStructArray<%s> %s"), *Factory->GetCSharpMemberTypeName(ArrayProp->Inner), *PropertyName));
		Text.OpenBrace();

		FString Getter = FString::Printf(TEXT("get{ CheckIsValid();return new TStructArray<%s>((FScriptArray)Marshal.PtrToStructure(_this.Get()+%s, typeof(FScriptArray)));}"),
			*Factory->GetCSharpMemberTypeName(ArrayProp->Inner), *PropertyOffsetName);
		FString Setter = FString::Printf(TEXT("\t\tset{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+%s, false);}\r\n"),
			*PropertyOffsetName);

		Text.AppendLine(Getter);
		Text.AppendLine(Setter);
		Text.CloseBrace();

		return Text;
	}
	else
	{
		Text.AppendLine(FString::Printf(TEXT("public TObjectArray<%s>  %s"), *GetCSharpTypeArrayInnerTypeName(ArrayProp->Inner, Factory), *PropertyName));
		Text.OpenBrace();

		FString Getter = FString::Printf(TEXT("\t\tget{ CheckIsValid();return new TObjectArray<%s>((FScriptArray)Marshal.PtrToStructure(_this.Get()+%s, typeof(FScriptArray)));}\r\n"),
			*GetCSharpTypeArrayInnerTypeName(ArrayProp->Inner, Factory), *PropertyOffsetName);
		FString Setter = FString::Printf(TEXT("\t\tset{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+%s, false);}\r\n"),
			*PropertyOffsetName);
		Text.AppendLine(Getter);
		Text.AppendLine(Setter);
		Text.CloseBrace();

		return Text;
	}


}
FMonoTextBuilder ArrayTypePropertyHandler::BuildCSharpStructProperty(const FString& StructName, UProperty* P)
{
	UProperty* Property = P;
	FMonoTextBuilder Text;
	FString PropertyName = Property->GetName();
	UArrayProperty* ArrayProp = Cast<UArrayProperty>(Property);
	int offset = Property->GetOffset_ForInternal();
	if (!ArrayProp->Inner->IsA(UObjectPropertyBase::StaticClass()))
	{
		Text.AppendLine(FString::Printf(TEXT("public TStructArray<%s> %s"), *Factory->GetCSharpMemberTypeName(ArrayProp->Inner), *PropertyName));
		Text.OpenBrace();

		FString Getter = FString::Printf(TEXT("\t\t\tget{ unsafe { fixed (void* p = &this) { return new TStructArray<%s>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+%d, typeof(FScriptArray)));}}}\r\n"),
			*Factory->GetCSharpMemberTypeName(ArrayProp->Inner), offset);
		FString Setter = FString::Printf(TEXT("\t\t\tset{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+%d, false);}}}\r\n"),
			offset);

		Text.AppendLine(Getter);
		Text.AppendLine(Setter);
		Text.CloseBrace();

		return Text;
	}
	else
	{
		Text.AppendLine(FString::Printf(TEXT("public TObjectArray<%s> %s"), *GetCSharpTypeArrayInnerTypeName(ArrayProp->Inner, Factory), *PropertyName));
		Text.OpenBrace();

		FString Getter = FString::Printf(TEXT("\t\t\tget{ unsafe { fixed (void* p = &this) { return new TObjectArray<%s>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+%d, typeof(FScriptArray)));}}}\r\n"),
			*GetCSharpTypeArrayInnerTypeName(ArrayProp->Inner, Factory), offset);
		FString Setter = FString::Printf(TEXT("\t\t\tset{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+%d, false);}}}\r\n"),
			offset);
		Text.AppendLine(Getter);
		Text.AppendLine(Setter);
		Text.CloseBrace();

		return Text;
	}
}
////////////////////////////////FName//////////////////////////////////////////////////
//返回C++类型名称，带前缀
FString NameTypePropertyHandler::GetCppTypeName(UProperty* P)
{
	return "FName";
}
FString NameTypePropertyHandler::GetCppParamTypeName(UProperty* P)
{
	return ValueTypePropertyHandler::GetCppParamTypeName(P);
}

//返回作为C++参数时的类型名称
FString NameTypePropertyHandler::GetCppMarshalTypeName(UProperty* P)
{
	if (IsOutParam(P))
		return "MonoString**";
	else
		return "MonoString*";
}
//转换
FString NameTypePropertyHandler::BuildCppFuncPreCall(UProperty* P)
{
	if (IsOutParam(P))
	{
		return FString::Printf(TEXT("FName %s_temp;"), *P->GetName());
	}
	else
	{
		return FString::Printf(TEXT("FName %s_temp=MonoStringToFName(%s);"), *P->GetName(), *P->GetName());
	}
}
FString NameTypePropertyHandler::BuildCppCallParam(UProperty* P)
{
	return FString::Printf(TEXT("%s_temp"), *P->GetName());
}
//转换
FString NameTypePropertyHandler::BuildCppFuncPostSet(UProperty* P)
{
	if (IsOutParam(P))
	{
		return FString::Printf(TEXT("*%s=FNameToMonoString(%s_temp);"), *P->GetName(), *P->GetName());
	}
	else
	{
		return "";
	}
}
FString NameTypePropertyHandler::BuildCppFuncReturn(UProperty* P)
{
	return FString::Printf(TEXT("return FNameToMonoString(___ret);"));
}

//返回带前缀的C#名称
FString NameTypePropertyHandler::GetCSharpTypeName(UProperty* P)
{
	return "string";
}

FString NameTypePropertyHandler::GetCSharpMemberTypeName(UProperty* P)
{
	return "FName";
}
FString NameTypePropertyHandler::GetCSharpParamTypeName(UProperty* P)
{
	return ValueTypePropertyHandler::GetCSharpParamTypeName(P);
}
//返回作为C#静态参数时的类型名称
FString NameTypePropertyHandler::GetCSharpMarshalTypeName(UProperty* P)
{
	return ValueTypePropertyHandler::GetCSharpMarshalTypeName(P);
}

FMonoTextBuilder NameTypePropertyHandler::BuildCSharpClassProperty(UProperty* P)
{
	return ValueTypePropertyHandler::BuildCSharpClassProperty(P);
}
FMonoTextBuilder NameTypePropertyHandler::BuildCSharpStructProperty(const FString& StructName, UProperty* P)
{
	return ValueTypePropertyHandler::BuildCSharpStructProperty(StructName,P);
}

FString NameTypePropertyHandler::GetCSharpDefaultParameterValue(UFunction* Function, UProperty* ParamProperty)
{
	FString Value = PropertyHandlerBase::GetCSharpDefaultParameterValue(Function, ParamProperty);
	if (Value.Len() > 0)
		return "\"" + Value + "\"";
	else
		return Value;
}

//////////////////////////////FString///////////////////////////////////////////////////
//返回C++类型名称，带前缀
FString StrTypePropertyHandler::GetCppTypeName(UProperty* P)
{
	return "FString";
}
FString StrTypePropertyHandler::GetCppParamTypeName(UProperty* P)
{
	return ValueTypePropertyHandler::GetCppParamTypeName(P);
}

//返回作为C++参数时的类型名称
FString StrTypePropertyHandler::GetCppMarshalTypeName(UProperty* P)
{
	if (IsOutParam(P))
		return "MonoString**";
	else
		return "MonoString*";
}
//转换
FString StrTypePropertyHandler::BuildCppFuncPreCall(UProperty* P)
{
	if (IsOutParam(P))
	{
		return FString::Printf(TEXT("FString %s_temp;"), *P->GetName());
	}
	else
	{
		return FString::Printf(TEXT("FString %s_temp=MonoStringToFString(%s);"), *P->GetName(), *P->GetName());
	}
}
FString StrTypePropertyHandler::BuildCppCallParam(UProperty* P)
{
	return FString::Printf(TEXT("%s_temp"), *P->GetName());
}
//转换
FString StrTypePropertyHandler::BuildCppFuncPostSet(UProperty* P)
{
	if (IsOutParam(P))
	{
		return FString::Printf(TEXT("*%s=FStringToMonoString(%s_temp);"), *P->GetName(), *P->GetName());
	}
	else
	{
		return "";
	}
}
FString StrTypePropertyHandler::BuildCppFuncReturn(UProperty* P)
{
	return FString::Printf(TEXT("return FStringToMonoString(___ret);"));
}

//返回带前缀的C#名称
FString StrTypePropertyHandler::GetCSharpTypeName(UProperty* P)
{
	return "string";
}

FString StrTypePropertyHandler::GetCSharpMemberTypeName(UProperty* P)
{
	return "FString";
}
FString StrTypePropertyHandler::GetCSharpParamTypeName(UProperty* P)
{
	return ValueTypePropertyHandler::GetCSharpParamTypeName(P);
}
//返回作为C#静态参数时的类型名称
FString StrTypePropertyHandler::GetCSharpMarshalTypeName(UProperty* P)
{
	return ValueTypePropertyHandler::GetCSharpMarshalTypeName(P);
}

FMonoTextBuilder StrTypePropertyHandler::BuildCSharpClassProperty(UProperty* P)
{
	return ValueTypePropertyHandler::BuildCSharpClassProperty(P);
}
FMonoTextBuilder StrTypePropertyHandler::BuildCSharpStructProperty(const FString& StructName, UProperty* P)
{
	return ValueTypePropertyHandler::BuildCSharpStructProperty(StructName,P);
}

FString StrTypePropertyHandler::GetCSharpDefaultParameterValue(UFunction* Function, UProperty* ParamProperty)
{
	FString Value = PropertyHandlerBase::GetCSharpDefaultParameterValue(Function, ParamProperty);
	if (Value.Len() > 0)
		return "\"" + Value + "\"";
	else
		return Value;
}
///////////////////////////////////FText/////////////////////////////////////////////
//返回C++类型名称，带前缀
FString TextTypePropertyHandler::GetCppTypeName(UProperty* P)
{
	return "FText";
}
FString TextTypePropertyHandler::GetCppParamTypeName(UProperty* P)
{
	return PropertyHandlerBase::GetCppParamTypeName(P);
}
//返回作为C++参数时的类型名称
FString TextTypePropertyHandler::GetCppMarshalTypeName(UProperty* P)
{
	if (IsOutParam(P))
		return "MonoString**";
	else
		return "MonoString*";
}
//转换
FString TextTypePropertyHandler::BuildCppFuncPreCall(UProperty* P)
{
	if (IsOutParam(P))
	{
		return FString::Printf(TEXT("FText %s_temp;"), *P->GetName());
	}
	else
	{
		return FString::Printf(TEXT("FText %s_temp=FText::FromString(MonoStringToFString(%s));"), *P->GetName(), *P->GetName());
	}
}
FString TextTypePropertyHandler::BuildCppCallParam(UProperty* P)
{
	return FString::Printf(TEXT("%s_temp"), *P->GetName());
}
//转换
FString TextTypePropertyHandler::BuildCppFuncPostSet(UProperty* P)
{
	if (IsOutParam(P))
	{
		return FString::Printf(TEXT("*%s=FStringToMonoString(%s_temp.ToString());"), *P->GetName(), *P->GetName());
	}
	else
	{
		return "";
	}
}
FString TextTypePropertyHandler::BuildCppFuncReturn(UProperty* P)
{
	return FString::Printf(TEXT("return FStringToMonoString(___ret.ToString());"));
}

//返回带前缀的C#名称
FString TextTypePropertyHandler::GetCSharpTypeName(UProperty* P)
{
	return "string";
}

FString TextTypePropertyHandler::GetCSharpMemberTypeName(UProperty* P)
{
	return "FText";
}
FString TextTypePropertyHandler::GetCSharpParamTypeName(UProperty* P)
{
	if (IsOutParam(P))
		return "out string";
	return "string";
}
//返回作为C#静态参数时的类型名称
FString TextTypePropertyHandler::GetCSharpMarshalTypeName(UProperty* P)
{
	return TextTypePropertyHandler::GetCSharpParamTypeName(P);
}

FMonoTextBuilder TextTypePropertyHandler::BuildCSharpClassProperty(UProperty* P)
{
	FMonoTextBuilder Text;
	FString PropertyOffsetName = FString::Printf(TEXT("%s__Offset"), *P->GetName());
	Text.AppendLine(FString::Printf(TEXT("public string %s"), *P->GetName()));
	Text.OpenBrace();

	Text.AppendLine(FString::Printf(TEXT("get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+%s, typeof(FText))).ToString();}"),
		*PropertyOffsetName));
	bool bSetter = P->PropertyFlags & CPF_Edit;
	if (bSetter)
	{
		Text.AppendLine(FString::Printf(TEXT("set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+%s, false);}"),
			*PropertyOffsetName));
	}

	Text.CloseBrace();

	return Text;
}
FMonoTextBuilder TextTypePropertyHandler::BuildCSharpStructProperty(const FString& StructName, UProperty* P)
{
	FMonoTextBuilder Text;

	Text.AppendLine(FString::Printf(TEXT("[FieldOffset(%d)]"), P->GetOffset_ForInternal()));
	Text.AppendLine(FString::Printf(TEXT("public FText %s;"), *P->GetName()));

	return Text;
}

FString TextTypePropertyHandler::GetCSharpDefaultParameterValue(UFunction* Function, UProperty* ParamProperty)
{
	FString Value = PropertyHandlerBase::GetCSharpDefaultParameterValue(Function, ParamProperty);
	if (Value.Len() > 0)
		return "\"" + Value + "\"";
	else
		return Value;
}


////////////////////////////////////////////MulticastDelegatePropertyHandler///////////////////////////////////////////////
FMonoTextBuilder MulticastDelegatePropertyHandler::BuildCSharpClassProperty(UProperty* P)
{
	FMonoTextBuilder Text;
	FString PropertyOffsetName = FString::Printf(TEXT("%s__Offset"), *P->GetName());
	Text.AppendLine(FString::Printf(TEXT("public FMulticastScriptDelegate %s"), *P->GetName()));
	Text.OpenBrace();

	Text.AppendLine(FString::Printf(TEXT("get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+%s, typeof(FMulticastScriptDelegate)));}"),
		*PropertyOffsetName));
	//bool bSetter = P->PropertyFlags & CPF_Edit;
	//if (bSetter)
	{
		Text.AppendLine(FString::Printf(TEXT("set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+%s, false);}"),
			*PropertyOffsetName));
	}

	Text.CloseBrace();

	return Text;
}
FMonoTextBuilder MulticastDelegatePropertyHandler::BuildCSharpStructProperty(const FString& StructName, UProperty* P)
{
	FMonoTextBuilder Text;

	Text.AppendLine(FString::Printf(TEXT("[FieldOffset(%d)]"), P->GetOffset_ForInternal()));
	Text.AppendLine(FString::Printf(TEXT("public FMulticastScriptDelegate %s;"), *P->GetName()));

	return Text;
}


//////////////////////////////PropertyHandlerFactroy//////////////////////////////////
#pragma optimize( "", off )

PropertyHandlerFactroy::PropertyHandlerFactroy()
{
	PropertyHandlers.Add(UIntProperty::StaticClass(), new Int32TypePropertyHandler());
	PropertyHandlers.Add(UByteProperty::StaticClass(), new ByteTypePropertyHandler());
	PropertyHandlers.Add(UBoolProperty::StaticClass(), new BoolTypePropertyHandler());
	PropertyHandlers.Add(UDoubleProperty::StaticClass(), new ValueTypePropertyHandler());
	PropertyHandlers.Add(UFloatProperty::StaticClass(), new FloatTypePropertyHandler());
	PropertyHandlers.Add(UStrProperty::StaticClass(), new StrTypePropertyHandler());
	PropertyHandlers.Add(UNameProperty::StaticClass(), new NameTypePropertyHandler());
	PropertyHandlers.Add(UInt8Property::StaticClass(), new ByteTypePropertyHandler());
	PropertyHandlers.Add(UInt16Property::StaticClass(), new UInt16TypePropertyHandler());
	PropertyHandlers.Add(UInt64Property::StaticClass(), new UInt64TypePropertyHandler());
	PropertyHandlers.Add(UUInt16Property::StaticClass(), new UInt16TypePropertyHandler());
	PropertyHandlers.Add(UUInt32Property::StaticClass(), new UInt32TypePropertyHandler());
	PropertyHandlers.Add(UUInt64Property::StaticClass(), new UInt64TypePropertyHandler());
	PropertyHandlers.Add(UStructProperty::StaticClass(), new StructTypePropertyHandler());
	PropertyHandlers.Add(UObjectProperty::StaticClass(), new ObjectTypePropertyHandler());
	PropertyHandlers.Add(UTextProperty::StaticClass(), new TextTypePropertyHandler());
	PropertyHandlers.Add(UMulticastDelegateProperty::StaticClass(), new MulticastDelegatePropertyHandler());
	ArrayTypePropertyHandler* ArrayHandler = new ArrayTypePropertyHandler();
	ArrayHandler->Factory = this;
	PropertyHandlers.Add(UArrayProperty::StaticClass(), ArrayHandler);
	PropertyHandlers.Add(UClassProperty::StaticClass(), new ClassTypePropertyHandler());

	EnumHandler = new EnumTypePropertyHandler();
}

PropertyHandlerFactroy::~PropertyHandlerFactroy()
{
	for (auto v : PropertyHandlers)
	{
		delete v.Value;
	}
	PropertyHandlers.Empty();

	delete EnumHandler;
}

IPropertyHandler* PropertyHandlerFactroy::GetPropertyHandler(UProperty* Property)
{
	if (Property->IsA(UByteProperty::StaticClass()))
	{
		UByteProperty* ByteProp = (UByteProperty*)Property;
		if (ByteProp->GetIntPropertyEnum() != NULL)
			return EnumHandler;
	}

	UClass* key = Property->GetClass();
	if (PropertyHandlers.Contains(key))
	{
		return PropertyHandlers[key];
	}
	return nullptr;
}

bool PropertyHandlerFactroy::IsPropertySupported(UProperty* Property)
{
	UClass* key = Property->GetClass();

	if (PropertyHandlers.Contains(key))
	{
		UArrayProperty* ArrayProp = Cast<UArrayProperty>(Property);
		if (ArrayProp != nullptr)
		{
			return IsPropertySupported(ArrayProp->Inner);
		}

		return true;
	}
	return false;
}


#pragma optimize( "", on )