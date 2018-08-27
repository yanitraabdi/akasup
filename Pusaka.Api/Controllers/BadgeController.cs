using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pusaka.Library;
using Pusaka.Model;
using Pusaka.Services.Services;

namespace Pusaka.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Badge")]
    public class BadgeController : Controller
    {
        BadgeService _svc = new BadgeService();

        [HttpGet("[action]")]
        public async Task<IActionResult> GetBadges(int? CategoryId = 0, string City = "", string MisName = "", int? MisStatus = 0, int? CurrentPage = 0, int? PageSize = 0, string OrderByColumn = "", int? IsAscending = 0, int? TotalRecords = 0)
        {
            ListBadges oResult = new ListBadges();
            try
            {
                //oResult.listBadges = await _svc.GetAllAsync(CategoryId, City, MisName, MisStatus, CurrentPage, PageSize, OrderByColumn, IsAscending, TotalRecords);
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
        public async Task<IActionResult> InsertBadge([FromBody]Badge entity)
        {
            ExceptionModel oResult = new ExceptionModel();
            try
            {
                bool isSuccess = await _svc.AddAsync(entity, "0");
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
        public async Task<IActionResult> UpdateBadge([FromBody]Badge entity, string userId)
        {
            ExceptionModel oResult = new ExceptionModel();
            try
            {
                bool isSuccess = await _svc.UpdateAsync(entity, userId);
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