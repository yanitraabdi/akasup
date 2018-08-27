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
    [Route("api/Category")]
    public class CategoryController : Controller
    {
        CategoryService _svc = new CategoryService();

        [HttpGet("")]
        public async Task<IActionResult> GetCategory(int? BadgeStatus = 0, int? CurrentPage = 0, int? PageSize = 0, int? TotalRecords = 0)
        {
            ListCategory oResult = new ListCategory();
            try
            {
                oResult.listCategory = await _svc.GetAllAsync(CurrentPage, PageSize, TotalRecords);
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

        [HttpPost("")]
        public async Task<IActionResult> InsertCategory([FromBody]Category entity)
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

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateCategory([FromBody]Category entity, string id)
        {
            ExceptionModel oResult = new ExceptionModel();
            try
            {
                bool isSuccess = await _svc.UpdateAsync(entity, id);
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

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteCategory(string id)
        {
            ExceptionModel oResult = new ExceptionModel();
            try
            {
                bool isSuccess = await _svc.DeleteAsync(id ,"0");
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