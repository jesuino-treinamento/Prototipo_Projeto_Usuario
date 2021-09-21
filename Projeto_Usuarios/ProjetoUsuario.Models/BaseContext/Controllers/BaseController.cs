using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Net;
using ProjetoUsuario.Models.BaseContext.Entities;

namespace ProjetoUsuario.Models.BaseContext.Controllers
{
    public class BaseController : Controller
    {
        #region /* Private Methods */
        private ActionResult DefineCorrectResult(object result, HttpStatusCode statusCode, string redirectUrl = null)
        {
            switch (statusCode)
            {
                case HttpStatusCode.Accepted:
                    return this.Accepted(result);
                case HttpStatusCode.Created:
                    if (redirectUrl == null)
                        return this.StatusCode((int)statusCode, result);
                    else
                        return this.Created(redirectUrl, result);
                case HttpStatusCode.BadRequest:
                    return this.BadRequest(result);
                case HttpStatusCode.NotFound:
                    return this.NotFound(result);
                case HttpStatusCode.NoContent:
                    return this.NoContent();
                case HttpStatusCode.OK:
                    return this.Ok(result);
                case HttpStatusCode.Unauthorized:
                    return this.Unauthorized();
                case HttpStatusCode.Conflict:
                    return this.Conflict();
                default:
                    return this.StatusCode((int)statusCode, result);
            }
        }
        #endregion

        #region /* Public Methods */
        public ActionResult DefineCorrectResult<T>(T response, string redirectUrl = null) where T : IBaseDTO
        {
            HttpStatusCode statusCode;

            if (!response.IsSuccessful || response.Messages.Count > 0)
            {
                HttpStatusCode httpStatusCode = HttpStatusCode.BadRequest;

                if (response.Messages.Any(re => re.Code == ((int)HttpStatusCode.Unauthorized).ToString()))
                    statusCode = HttpStatusCode.Unauthorized;
                else if (response.Messages.Count == 1 && Enum.TryParse(response.Messages.First().Code, out httpStatusCode))
                    statusCode = httpStatusCode;
                else
                    statusCode = HttpStatusCode.BadRequest;

                return this.DefineCorrectResult(response, statusCode, redirectUrl);
            }

            return this.DefineCorrectResult(response, HttpStatusCode.OK);
        }
        #endregion
    }
}
