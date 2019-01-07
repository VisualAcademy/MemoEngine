using System.Collections.Generic;

public interface IElectricityPlanRepository
{
    Dictionary<string, string> GetElectricUses();
    Dictionary<string, string> GetRateDetailsByRateType(RateTypeOption rateTypeOption);
    Dictionary<string, string> GetRateTypeByElectricUses(ElectricUsesType electricUsesType);
}