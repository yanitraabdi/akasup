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
    [Route("api/User")]
    public class UserController : Controller
    {
        //UserService _svc = new UserService();

        //[HttpGet("[action]")]
        //public async Task<IActionResult> GetTVChannels()
        //{
        //    ListUsers oResult = new ListUsers();
        //    try
        //    {
        //        oResult.listUsers = await _svc.GetAllAsync();
        //        oResult.ErrorCode = (int)ExceptionType.SUCCESS;
        //        oResult.ErrorDesc = ExceptionType.SUCCESS.ToString();

        //    }
        //    catch (Exception ex)
        //    {
        //        oResult.ErrorCode = (int)ExceptionType.CATCH;
        //        oResult.ErrorDesc = ex.ToString();
        //    }
        //    return Ok(oResult);
        //}

        //[HttpGet("[action]")]
        //public async Task<IActionResult> GetTVChannel(int id)
        //{
        //    SingleUsers oResult = new SingleUsers();
        //    try
        //    {
        //        oResult.Users = await _svc.Get(id);
        //        oResult.ErrorCode = (int)ExceptionType.SUCCESS;
        //        oResult.ErrorDesc = ExceptionType.SUCCESS.ToString();

        //    }
        //    catch (Exception ex)
        //    {
        //        oResult.ErrorCode = (int)ExceptionType.CATCH;
        //        oResult.ErrorDesc = ex.ToString();
        //    }
        //    return Ok(oResult);
        //}

        //[HttpPost("[action]")]
        //public async Task<IActionResult> InsertTVChannel([FromBody]Users entity)
        //{
        //    ExceptionModel oResult = new ExceptionModel();
        //    try
        //    {
        //        bool isSuccess = await _svc.Add(entity);
        //        if (isSuccess)
        //        {
        //            oResult.ErrorCode = (int)ExceptionType.SUCCESS;
        //            oResult.ErrorDesc = ExceptionType.SUCCESS.ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        oResult.ErrorCode = (int)ExceptionType.CATCH;
        //        oResult.ErrorDesc = ex.ToString();
        //    }
        //    return Ok(oResult);
        //}

        //[HttpPut("[action]")]
        //public async Task<IActionResult> UpdateTVChannel([FromBody]Users entity)
        //{
        //    ExceptionModel oResult = new ExceptionModel();
        //    try
        //    {
        //        bool isSuccess = await _svc.Update(entity);
        //        if (isSuccess)
        //        {
        //            oResult.ErrorCode = (int)ExceptionType.SUCCESS;
        //            oResult.ErrorDesc = ExceptionType.SUCCESS.ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        oResult.ErrorCode = (int)ExceptionType.CATCH;
        //        oResult.ErrorDesc = ex.ToString();
        //    }
        //    return Ok(oResult);
        //}

        //[HttpDelete("[action]")]
        //public async Task<IActionResult> DeleteTVChannel([FromBody]Users entity)
        //{
        //    ExceptionModel oResult = new ExceptionModel();
        //    try
        //    {
        //        bool isSuccess = await _svc.Delete(entity);
        //        if (isSuccess)
        //        {
        //            oResult.ErrorCode = (int)ExceptionType.SUCCESS;
        //            oResult.ErrorDesc = ExceptionType.SUCCESS.ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        oResult.ErrorCode = (int)ExceptionType.CATCH;
        //        oResult.ErrorDesc = ex.ToString();
        //    }
        //    return Ok(oResult);
        //}
    }
}