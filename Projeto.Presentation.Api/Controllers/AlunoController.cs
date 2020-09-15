using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Application.Services;
using Projeto.Infra.Data.Contracts;

namespace Projeto.Presentation.Api.Controllers
{
    [EnableCors("DefaultPolicy")]
    [Authorize]
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
                return Ok("Aluno cadastrado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(AlunoEdicaoModel model,
            [FromServices] IAlunoApplicationService alunoApplicationService)
        {
            try
            {
                alunoApplicationService.Update(model);
                return Ok("Aluno atualizado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id,
            [FromServices] IAlunoApplicationService alunoApplicationService)
        {
            try
            {
                alunoApplicationService.Delete(id);
                return Ok("Aluno deletado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll(
            [FromServices] IAlunoApplicationService alunoApplicationService)
        {
            try
            {
                return Ok(alunoApplicationService.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id,
            [FromServices] IAlunoApplicationService alunoApplicationService)
        {
            try
            {
                return Ok(alunoApplicationService.GetById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

    }
}
