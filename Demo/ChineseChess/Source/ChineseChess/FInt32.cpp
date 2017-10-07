#include "ChineseChess.h"
#include "FInt32.h"
#include "Object.h"
#include "Int32.h"
#include "FInt32_ExtCpp.h"
Int32 FInt32::ToInt32()
{
	return this->ToInt32(*this);
}
