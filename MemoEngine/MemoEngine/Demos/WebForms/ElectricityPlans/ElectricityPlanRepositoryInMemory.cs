using System.Collections.Generic;
/// <summary>
/// 전기 요금제 리포지토리 클래스
/// </summary>
public class ElectricityPlanRepositoryInMemory : IElectricityPlanRepository
{
    /// <summary>
    /// 전기 용도 선택 
    /// </summary>
    /// <returns>주택용(Home) 또는 일반/산업용(Industry)</returns>
    public Dictionary<string, string> GetElectricUses()
    {
        Dictionary<string, string> pairs = new Dictionary<string, string>();

        pairs.Add("주택용", ElectricUsesType.Home.ToFriendlyString());
        pairs.Add("일반/산업용", ElectricUsesType.Industry.ToFriendlyString());

        return pairs; 
    }

    /// <summary>
    /// 전기 용도에 따른 요금 유형 
    /// </summary>
    /// <param name="electricUsesType">ElectricUsesType.Home 또는 ElectricUsesType.Industry</param>
    /// <returns>Dictionary 키와 값의 쌍</returns>
    public Dictionary<string, string> GetRateTypeByElectricUses(ElectricUsesType electricUsesType)
    {
        Dictionary<string, string> pairs = new Dictionary<string, string>();

        if (electricUsesType == ElectricUsesType.Home)
        {
            // 주택용
            pairs.Add("고압", "HighPressure");
            pairs.Add("저압", "LowPressure");
        }
        else
        {
            // 일반/산업용
            pairs.Add("갑", "First");
            pairs.Add("을", "Second");
        }

        return pairs; 
    }

    /// <summary>
    /// 세부 요금 선택 
    /// </summary>
    /// <returns></returns>
    public Dictionary<string, string> GetRateDetailsByRateType(RateTypeOption rateTypeOption)
    {
        Dictionary<string, string> pairs = new Dictionary<string, string>();

        // 갑, 을 선택
        if (rateTypeOption == RateTypeOption.First)
        {
            // 갑
            pairs.Add("갑_고압", "HighPressure");
            pairs.Add("갑_저압", "LowPressure");
        }
        else if (rateTypeOption == RateTypeOption.Second)
        {
            // 을
            pairs.Add("을_고압", "HighPressure");
            pairs.Add("을_저압", "LowPressure");
        }
        else
        {
            // 주택용
            pairs.Add("고압", "HighPressure");
            pairs.Add("저압", "LowPressure");
        }

        return pairs;
    }
}
