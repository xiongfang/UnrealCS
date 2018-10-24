// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#include "InclusionLists.h"
#include "MonoHelperPrivatePCH.h"


bool FInclusionLists::HasFunction(const UStruct* Struct, const UFunction* Function) const
{
	if (AllFunctions.Contains(Struct->GetFName()))
	{
		return true;
	}
	const TSet<FName>* List = Functions.Find(Struct->GetFName());
	if (List && List->Contains(Function->GetFName()))
	{
		return true;
	}
	//const TSet<FString>* CategoryList = FunctionCategories.Find(Struct->GetFName());
	//if (CategoryList && Function->HasMetaData(MD_FunctionCategory))
	//{
	//	const FString& Category = Function->GetMetaData(MD_FunctionCategory);

	//	return CategoryList->Contains(Category);
	//}
	return false;
}
