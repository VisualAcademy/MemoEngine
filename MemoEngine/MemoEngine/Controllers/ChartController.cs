using Dul.Models;
using System.Linq;
using System.Web.Mvc;

namespace MemoEngine.Controllers
{
    /// <summary>
    /// 컨트롤러 클래스
    /// </summary>
    public class ChartController : Controller
    {
        private readonly ChartRepositoryInMemory _chartRepository;

        public ChartController()
        {
            _chartRepository = new ChartRepositoryInMemory();
        }

        /// <summary>
        /// 액션 메서드
        /// </summary>
        public ActionResult Index()
        {
            return View();
        }

        public string ChartDemo()
        {
            return "안녕하세요.";
        }

        public ActionResult ChartReport(int id = 0)
        {
            ViewBag.Id = id; 

            return View();
        }

        /// <summary>
        /// 월별 누적된 전기사용량 및 발전량
        /// </summary>
        public ActionResult ChartMonthSumLoadsAndGenerations()
        {
            int id = 1234;

            // [!] 리포지토리로부터 월별 누적 발전량 데이터 가져오기
            var generations = _chartRepository.GetChartMonthSumGenerations(id);
            var loads = _chartRepository.GetChartMonthSumLoads(id);

            // 1, ..., 12까지의 레이블 용도의 문자열 생성
            string labels = string.Join(",", generations.OrderBy(g => g.Key).Select(g => g.Key).ToArray());

            string generationValues = string.Join(",", generations.OrderBy(g => g.Key).Select(g => g.Value).ToArray());

            string loadValues = string.Join(",", loads.OrderBy(g => g.Key).Select(g => g.Value).ToArray());

            ViewData["Labels"] = labels; // 레이블
            ViewBag.Generations = generationValues; // 값
            ViewBag.Loads = loadValues; // 값

            return View();
        }

        /// <summary>
        /// 월별 누적된 태양광 발전량
        /// 액션(동작) 메서드 
        /// </summary>
        public ActionResult ChartMonthSumGenerations()
        {
            int id = 1234; 

            // [!] 리포지토리로부터 월별 누적 발전량 데이터 가져오기
            var generations = _chartRepository.GetChartMonthSumGenerations(id);

            // 1, ..., 12까지의 레이블 용도의 문자열 생성
            string labels = string.Join(",", generations.OrderBy(g => g.Key).Select(g => g.Key).ToArray());

            string values = string.Join(",", generations.OrderBy(g => g.Key).Select(g => g.Value).ToArray());

            ViewData["Labels"] = labels; // 레이블
            ViewBag.Values = values; // 값

            return View();
        }
    }
}
