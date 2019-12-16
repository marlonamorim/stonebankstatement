using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using AutoMapper;
using Stone.BankStatement.Domain.Repositories;
using Stone.BankStatement.WebApi.Models;

namespace Stone.BankStatement.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/bankaccount")]
    public class BankAccountController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<BankAccountModel>>> Get([FromServices] IBankAccountRepository repository,
            [FromServices] IMapper _mapper, DateTime? dateIni = null, DateTime? dateEnd = null)
        {
            var banksAccounts = await repository.GetByDate(dateIni, dateEnd);

            var model = _mapper.Map<List<BankAccountModel>>(banksAccounts);
            return model;
        }
    }
}