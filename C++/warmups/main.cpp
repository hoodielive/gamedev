#include <iostream>

// Create your own namespace string implementation
namespace ConsoleHelper
{
    class string
    {
        friend bool operator == (const string &string1, const string &string2);
				friend bool operator < (const string &string1, const string &string2);

			public:
        string();
        string(const char* input);
        ~string();
    };

}

int main()
{

	ConsoleHelper::string name = new ConsoleHelper::string("Ogun");
	std::cout << name << std::endl;
	return 0;
}
