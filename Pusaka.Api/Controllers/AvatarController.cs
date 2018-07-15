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
    public class AvatarController : Controller
    {
        AvatarService _svc = new AvatarService();

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAvatars(int avatarId = 0, string avatarName = "", byte avatarStatus = 0, int currentPage = 0, int pageSize = 0, string orderByColumn = "", bool isAscending = true, int totalRecords = 0)
        {
            ListAvatars oResult = new ListAvatars();
            try
            {
                oResult.listAvatars = await _svc.GetAllAsync(avatarId, avatarName, avatarStatus, currentPage,
                    pageSize, orderByColumn, isAscending, totalRecords);
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
        public async Task<IActionResult> InsertAvatar([FromBody]Avatars entity)
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
        public async Task<IActionResult> UpdateAvatar([FromBody]Avatars entity, string userId)
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