using System;
using System.Collections;
/// <summary>
///NaN
/// </summary>
public class SingleNaN
{
    public static int Main()
    {
        SingleNaN SingleNaN = new SingleNaN();

        TestLibrary.TestFramework.BeginTestCase("SingleNaN");
        if (SingleNaN.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }

    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: Compare to ExpectNaN.");
        try
        {
            Single zero = 0;

            if ((0 / zero) == Single.NaN)
            {
                TestLibrary.TestFramework.LogError("001", "NaN has error.");
                retVal = false;
            }
            if (!Single.IsNaN(Single.NaN))
            {
                TestLibrary.TestFramework.LogError("002", "NaN has error.");
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("003", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }

}
