/**
* @file $fileinputname$
* 
* @author $author$ <$username$@example.com>
* @date $date$
* 
* @brief Tests for class:function
*
*/

#include "gtest/gtest.h"

class Test_$test_name$Suite : public TestSuite
{
	void setup() {
		
	}

	void teardown()	{
		
	}
};


class Test_$test_name$Test : public TestCase
{
private:
	Test_$test_name$Suite* _suite;

public:
	Test_$test_name$Suite(TestSuite suite) { _suite = suite; }


	public void Test_MyFirstTest()
	{
		
	}
};


extern "C" TestSuite test_$test_name$()
{
	Test_$test_name$Suite* suite = new Test_$test_name$Suite();

	suite->add(new Test_$test_name$(suite));

	return suite;
}