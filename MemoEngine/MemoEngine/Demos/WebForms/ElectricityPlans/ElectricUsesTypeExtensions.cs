
/// <summary>
/// 전기 용도 선택
/// </summary>
public static class ElectricUsesTypeExtensions
{
    public static string ToFriendlyString(this ElectricUsesType electricUsesType)
    {
        string r = "";

        switch (electricUsesType)
        {
            case ElectricUsesType.Home:
                r = "Home";
                break;
            case ElectricUsesType.Industry:
                r = "Industry";
                break;
            default:
                r = "Home";
                break;
        }

        return r;
    }
}
