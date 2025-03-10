var testInstance = new A();
testInstance.ReturnMethod(0);

var testInstance2 = new Justaclasstests();
testInstance2.ReturnMethod_returnsPIKACHUifvalue0_returnsPIKACHU();


    public class A
    {
        public string ReturnMethod(int value)
        {
            if (value == 0)
            {
                return "PIKACHU!";
            }
            else
            {
                return "FUCK YOU!";
            }
        }
    }
public class Justaclasstests
    {
        public void ReturnMethod_returnsPIKACHUifvalue0_returnsPIKACHU()
        {
            //Arrange
            A instance = new A();
            int value = 9;
            string expectedString = "PIKACHU!";

            //Act
            string result = instance.ReturnMethod(value);

            //Assert
            if(result == expectedString)
            {
                System.Console.WriteLine( $"Test case passed: {result} is called");
            }
            else
            {
                System.Console.WriteLine(  $"Test case failed: {result} is called");
            }
        }
    }