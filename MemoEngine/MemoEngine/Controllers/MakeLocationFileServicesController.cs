using System;
using System.IO;
using System.Web;
using System.Web.Http;

namespace MemoEngine.Controllers
{
    /// <summary>
    /// jQuery Ajax를 사용하여 서버 쪽에 텍스트파일 생성하기
    /// </summary>
    public class MakeLocationFileServicesController : ApiController
    {
        [HttpPost]
        [Route("api/MakeLocationFileServices/PostMakeFile")]
        public void PostMakeFile(int id)
        {
            var folder = HttpContext.Current.Server.MapPath("/BoardFiles/Projects");
            var file = Path.Combine(folder, Guid.NewGuid().ToString() + ".dat");

            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(id.ToString());
            }
        }
    }
}
