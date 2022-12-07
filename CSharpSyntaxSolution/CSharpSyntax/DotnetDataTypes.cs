namespace CSharpSyntax;

public class DotnetDataTypes
{
    [Fact]
    public void AliasesToTypes()
    {
        // Type Identifier [initializer]
        int age = 53;
        Int32 yourAge = 30;

        string myName = "Jeff";
        String yourName = "Sue";

        Assert.Equal(53, age);
    }

    [Fact]
    public void SomeExampleLiterals()
    {
        int age = 3;
        double pay = 3.144;
        decimal yourPay = 21.01M;

        string myName = "Jeff";
        string story = "Chapter 1\n It was a dark stormy night\t\t";
        string configFile = "c:\\testdata\\newstuff\\demo";
        // verbatim string
        string configFile2 = @"c:\testdata\newstuff\demo";
        Assert.Equal(configFile, configFile2);

        string story2 = @"Chapter 1
It was          DARK AND STORMY NIGHT. His name was ""Tiger""";


        string aboutMe = "The name is " + myName + " And the age is " + age;
        Assert.Equal("The name is Jeff And the age is 3", aboutMe);

        string aboutMe2 = string.Format("The name is {0} And the Age is {1}", myName, age);
        Assert.Equal("The name is Jeff And the Age is 3", aboutMe2);

        string aboutMe3 = $"The name is {myName} And the Age is {age}";
        Assert.Equal("The name is Jeff And the Age is 3", aboutMe3);

        decimal hourlyRate = 123.45M;

        Assert.Equal("My pay is $123.45", $"My pay is {hourlyRate:c}");
    }

    [Fact]
    public void Chars()
    {
        char mi = 'M';

    }

    [Fact]
    public void ImplictlyTypedLocalVariables()
    {
        // implictly typed variable
        var myAge = 53; // MUST initialize it.

        var christmas = new DateTime(2022, 12, 25);
        var yourPet = new Dog();
        Dog myPet = new();
        //myAge = "old";

    }

    [Fact]
    public void AssignmentAndValueAndReferenceTypes()
    {
        int age1 = 21;
        int age2 = age1;

        //age2 = age2 + 3;
        age2 += 3;

        Assert.Equal(21, age1);

        Dog dog1 = new Dog();
        dog1.Name = "Fido";
        Dog dog2 = dog1;
        dog2.Name = "Rover";

        Assert.Equal("Rover", dog1.Name);

    }
}

public class Dog
{
    public string Name = string.Empty;
}