using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Application.Services;
using Projeto.Infra.Data.Contracts;

namespace Projeto.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
 
        [HttpPost]
        public IActionResult Post(AlunoCadastroModel model,
            [FromServices] IAlunoApplicationService alunoApplicationService)
        {
            try
            {
                alunoApplicationService.Insert(model); 
                //retornar status de sucesso 200 (OK)
                return Ok("Plano cadastrado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
