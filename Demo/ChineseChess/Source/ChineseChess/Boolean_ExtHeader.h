public:
	operator bool()
	{
		return _v;
	}
	Boolean(int v)
	{
		_v = v != 0;
	}
	Boolean()
	{
		_v = false;
	}
	UPROPERTY()
	bool _v;