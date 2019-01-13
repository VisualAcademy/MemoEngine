namespace MemoEngine.Models
{
    /// <summary>
    /// 가격 출력 모델: UserPrices와 일대일로 매핑되는 모델 클래스 
    /// </summary>
    public class UserPriceData
    {
        /// <summary>
        /// 일련번호 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 부모 테이블의 Id 
        /// </summary>
        public int ProjectId { get; set; }

        /// <summary>
        /// 년차
        /// </summary>
        public int Num { get; set; }

        /// <summary>
        /// 년도
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// 기준 단가
        /// </summary>
        public double StandardPrice { get; set; }

        /// <summary>
        /// 사용자 단가
        /// </summary>
        public double UserPrice { get; set; }
    }
}
