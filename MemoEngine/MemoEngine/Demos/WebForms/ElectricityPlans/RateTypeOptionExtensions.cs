
/// <summary>
/// 요금 유형 선택
/// </summary>
public static class RateTypeOptionExtensions
{
    public static string ToFriendlyString(this RateTypeOption rateTypeOption)
    {
        string r = "";

        switch (rateTypeOption)
        {
            case RateTypeOption.First:
                r = "First";
                break;
            case RateTypeOption.Second:
                r = "Second";
                break;
            default:
                r = "Second";
                break;
        }

        return r;
    }
}
