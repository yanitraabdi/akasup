using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pusaka.Library;
using Pusaka.Model;
using Pusaka.Services.Services;

namespace Pusaka.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Mission")]
    public class MissionController : Controller
    {
        MissionService _svc = new MissionService();

        [HttpGet("[action]")]
        public async Task<IActionResult> GetMissions(int? CategoryId = 0, string City = "", string MisName = "", int? MisStatus = 0, int? CurrentPage = 0, int? PageSize = 0, string OrderByColumn = "", int? IsAscending = 0, int? TotalRecords = 0)
        {
            ListMissions oResult = new ListMissions();
            try
            {
                oResult.listMissions = await _svc.GetAllAsync(CategoryId, City, MisName, MisStatus, CurrentPage, PageSize, OrderByColumn,IsAscending,TotalRecords);
                oResult.ErrorCode = (int)ExceptionType.SUCCESS;
                oResult.ErrorDesc = ExceptionType.SUCCESS.ToString();

            }
            catch (Exception ex)
            {
                oResult.ErrorCode = (int)ExceptionType.CATCH;
                oResult.ErrorDesc = ex.ToString();
            }
            return Ok(oResult);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> InsertMission([FromBody]Missions entity)
        {
            ExceptionModel oResult = new ExceptionModel();
            try
            {
                bool isSuccess = await _svc.Add(entity);
                if (isSuccess)
                {
                    oResult.ErrorCode = (int)ExceptionType.SUCCESS;
                    oResult.ErrorDesc = ExceptionType.SUCCESS.ToString();
                }
            }
            catch (Exception ex)
            {
                oResult.ErrorCode = (int)ExceptionType.CATCH;
                oResult.ErrorDesc = ex.ToString();
            }
            return Ok(oResult);
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateMission([FromBody]Missions entity, string userId)
        {
            ExceptionModel oResult = new ExceptionModel();
            try
            {
                bool isSuccess = await _svc.Update(entity, userId);
                if (isSuccess)
                {
                    oResult.ErrorCode = (int)ExceptionType.SUCCESS;
                    oResult.ErrorDesc = ExceptionType.SUCCESS.ToString();
                }
            }
            catch (Exception ex)
            {
                oResult.ErrorCode = (int)ExceptionType.CATCH;
                oResult.ErrorDesc = ex.ToString();
            }
            return Ok(oResult);
        }
    }
}