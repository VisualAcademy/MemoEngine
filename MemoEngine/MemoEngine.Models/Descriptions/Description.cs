namespace MemoEngine.Models
{
    public class Description
    {
        /// <summary>
        /// 일련번호: DescriptonManager에서는 큰 의미없음
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 사이트 이름
        /// </summary>
        public string SiteName { get; set; }

        /// <summary>
        /// 사이트 설명 
        /// </summary>
        public string SiteDescription { get; set; }

        /// <summary>
        /// 사용자 가이드
        /// </summary>
        public string UserGuide { get; set; }
    }
}
