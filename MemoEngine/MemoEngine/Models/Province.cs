namespace MemoEngine.Models
{
    /// <summary>
    /// 지방 모델
    /// </summary>
    public class Province
    {
        /// <summary>
        /// 번호
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 지자체명
        /// </summary>
        public string ProvinceName { get; set; }

        /// <summary>
        /// 지역명
        /// </summary>
        public string LocationName { get; set; }

        /// <summary>
        /// 지역코드
        /// </summary>
        public string LocationCode { get; set; }

        /// <summary>
        /// 위도
        /// </summary>
        public float Latitude { get; set; }

        /// <summary>
        /// 경도
        /// </summary>
        public float Longitude { get; set; }

        /// <summary>
        /// 해발 높이, 고도
        /// </summary>
        public string Elevation { get; set; }
    }
}
