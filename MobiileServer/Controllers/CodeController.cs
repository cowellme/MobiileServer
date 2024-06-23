using Microsoft.AspNetCore.Mvc;
using MobileServer.DataBase;

namespace MobiileServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CodeController : ControllerBase
    {
        [HttpPost]
        public bool Code(string code)
        {
            try
            {
                Db.SaveToDataBase(code);
                return true;
            }
            catch
            {
                return false;
            }

            return false;
        }
    }
}
