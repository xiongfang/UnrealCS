#pragma once
class String;
struct Boolean;
class Object{
	public:
	
	virtual String* ToString();
	public:
	
	virtual Boolean Equals(Object*  v);
};
