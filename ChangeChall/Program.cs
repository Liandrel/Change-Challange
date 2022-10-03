using ChangeChall;


List<DenominationInfo> denominations = new();
denominations.Add(new DenominationInfo { Name = "One Dollar Bill", Amount = 1M });
denominations.Add(new DenominationInfo { Name = "Five Dollar Bill", Amount = 5M });
denominations.Add(new DenominationInfo { Name = "Ten Dollar Bill", Amount = 10M });
denominations.Add(new DenominationInfo { Name = "Nickel", Amount = 0.05M });
denominations.Add(new DenominationInfo { Name = "Quarter", Amount = 0.25M });
denominations.Add(new DenominationInfo { Name = "Dime", Amount = 0.10M });
denominations.Add(new DenominationInfo { Name = "Penny", Amount = 0.01M });

static (decimal remainder, int numberOfItems) CalculateSpecificChange(decimal amount, decimal denomination)
{
    (decimal remainder, int numberOfItems) output = (0, 0);

    output.numberOfItems = (int)Math.Floor(amount / denomination);
    output.remainder = amount - (output.numberOfItems * denomination);

    return output;
}