using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Application.Services;
using Projeto.Infra.Data.Contracts;

namespace Projeto.Presentation.Api.Controllers
{
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
                //retornar status de sucesso 200 (OK)
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
                //retornar status de atualizado 200 (OK)
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
                //retornar status de sucesso 200 (OK)
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
                //retornar status de sucesso 200 (OK)
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
                //retornar status de sucesso 200 (OK)
                return Ok(alunoApplicationService.GetById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

    }
}
