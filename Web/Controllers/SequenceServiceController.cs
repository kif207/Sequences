using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Common.Helpers;

namespace Web.Controllers
{
    public class SequenceServiceController : ApiController
    {
        // GET: api/sequenceservice/GetAllNumbers/10
        [HttpGet]
        [Route("api/sequenceservice/GetAllNumbers/{number}")]
        public string GetAllNumbers(int number)
        {
            try
            {
                return string.Join(",",SequenceHelper.AllNumbers(number));
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message));
            }
        }

        // GET: api/sequenceservice/GetAllOddNumbers/10
        [HttpGet]
        [Route("api/sequenceservice/GetAllOddNumbers/{number}")]
        public string GetAllOddNumbers(int number)
        {
            try
            {
                return string.Join(",", SequenceHelper.AllOddNumbers(number));
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message));
            }
        }

        // GET: api/sequenceservice/GetAllEvenNumbers/10
        [HttpGet]
        [Route("api/sequenceservice/GetAllEvenNumbers/{number}")]
        public string GetAllEvenNumbers(int number)
        {
            try
            {
                return string.Join(",", SequenceHelper.AllEvenNumbers(number));
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message));
            }
        }

        // GET: api/sequenceservice/GetCEZSequence/10
        [HttpGet]
        [Route("api/sequenceservice/GetCEZSequence/{number}")]
        public string GetCEZSequence(int number)
        {
            try
            {
                return string.Join(",", SequenceHelper.CEZSequence(number));
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message));
            }
        }

        // GET: api/sequenceservice/GetFibonacciNumbers/10
        [HttpGet]
        [Route("api/sequenceservice/GetFibonacciNumbers/{number}")]
        public string GetFibonacciNumbers(int number)
        {
            try
            {
                return string.Join(",", SequenceHelper.FibonacciNumbers(number));
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message));
            }
        }

    }
}
