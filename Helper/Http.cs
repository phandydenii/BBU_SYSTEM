using System;
using System.Net; 
using Microsoft.AspNetCore.Mvc;

namespace BBU_SYSTEM.Helper
{
	public class Http : ControllerBase
    {
        public IActionResult GetRes(object data)
        {
            if (data != null)
            {
                return Ok(new
                {
                    data = data,
                    status = new
                    {
                        code = HttpStatusCode.success,
                        message = "Success"
                    }
                });
            }
            return NotFound(new
            {
                data = new { },
                status = new
                {
                    code = "404",
                    message = "Not Found"
                }
            });
        }

        public IActionResult PostRes(object data)
        {
            if (data != null)
            {
                return Ok(new
                {
                    data = data,
                    status = new
                    {
                        code = "200",
                        message = "Success"
                    }
                });
            }
            return BadRequest(new
            {
                data = new { },
                status = new
                {
                    code = "400",
                    message = "Bad Request"
                }
            });
        }
        public IActionResult PutRes(object data)
        {
            if (data != null)
            {
                return Ok(new
                {
                    data = data,
                    status = new
                    {
                        code = "200",
                        message = "Success"
                    }
                });
            }
            return BadRequest(new
            {
                data = new { },
                status = new
                {
                    code = "400",
                    message = "Bad Request"
                }
            });
        }
        public IActionResult DeleteRes(bool data)
        {
            if (data)
            {
                return Ok(new
                {
                    data = new { },
                    status = new
                    {
                        code = "200",
                        message = "Success"
                    }
                });
            }
            return BadRequest(new
            {
                data = new { },
                status = new
                {
                    code = "400",
                    message = "Bad Request"
                }
            });
        }
        public IActionResult BadRequestRes()
        {
            return BadRequest(new
            {
                data = new { },
                status = new
                {
                    code = "400",
                    message = "Bad Request"
                }
            });
        }
    }
}

