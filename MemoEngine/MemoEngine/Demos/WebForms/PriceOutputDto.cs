namespace MemoEngine.Models
{
    /// <summary>
    /// 가격 출력 모델
    /// </summary>
    public class PriceOutputDto
    {
        /// <summary>
        /// 년차
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// 년도
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// 사용자 단가
        /// </summary>
        public double UserPrice { get; set; }
        /// <summary>
        /// 기준 단가
        /// </summary>
        public double StandardPrice { get; set; }
    }
}
