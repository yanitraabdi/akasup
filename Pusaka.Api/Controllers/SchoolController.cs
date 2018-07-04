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
    public class SchoolController : Controller
    {
        SchoolService _svc = new SchoolService();

        [HttpGet("[action]")]
        public async Task<IActionResult> GetSchools(int? CategoryId = 0, string City = "", string MisName = "", int? MisStatus = 0, int? CurrentPage = 0, int? PageSize = 0, string OrderByColumn = "", int? IsAscending = 0, int? TotalRecords = 0)
        {
            ListSchools oResult = new ListSchools();
            try
            {
                oResult.listSchools = await _svc.GetAllAsync();
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
        public async Task<IActionResult> InsertSchool([FromBody]Schools entity)
        {
            ExceptionModel oResult = new ExceptionModel();
            try
            {
                bool isSuccess = await _svc.Add(entity, "0");
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
        public async Task<IActionResult> UpdateSchool([FromBody]Schools entity, string userId)
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