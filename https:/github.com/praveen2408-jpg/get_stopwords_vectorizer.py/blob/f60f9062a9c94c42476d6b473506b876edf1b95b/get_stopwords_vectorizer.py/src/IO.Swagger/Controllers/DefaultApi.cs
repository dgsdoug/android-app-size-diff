/*
 * Sample Access Code Flow OAuth2 Project
 *
 * This is an example of using OAuth2 Access Code Flow in a specification to describe security to your API.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DefaultApiController : ControllerBase
    { 
        /// <summary>
        /// Server example operation
        /// </summary>
        /// <remarks>This is an example operation to show how security is applied to the call.</remarks>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/dgsdoug/Dgs/1.0.0/example")]
        [ValidateModelState]
        [SwaggerOperation("ExampleGet")]
        public virtual IActionResult ExampleGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Server heartbeat operation
        /// </summary>
        /// <remarks>This operation shows how to override the global security defined above, as we want to open it up for all users.</remarks>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/dgsdoug/Dgs/1.0.0/ping")]
        [ValidateModelState]
        [SwaggerOperation("PingGet")]
        public virtual IActionResult PingGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }
    }
}
