public:
	String() { _v = 0; }
	String(const char* c);
	~String() { delete[] _v; }
private:
	char* _v;
public:
	const char* c_str() { return _v; }