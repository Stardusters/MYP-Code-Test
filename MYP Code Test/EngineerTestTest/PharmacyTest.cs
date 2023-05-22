using EngineerTest;
using Xunit;

namespace EngineerTestTest;

public class PharmacyTest
{
    [Fact]
    public void TestShouldDecreaseBenefitAndExpiresIn()
    {
        Assert.Equal(new Drug[] { new Drug("Dafalgan", 1, 1)}, 
            new Pharmacy(new Drug[] { new Drug("Dafalgan", 2, 3)}).UpdateBenefitValue());
    }

    [Fact]
    public void TestShouldNotExistNegativeBenefits()
    {
        var drugBenefit= new Drug("Dafalgan",1,2).Benefit;
        Assert.InRange<int>(drugBenefit, 0, 50);
    }
}