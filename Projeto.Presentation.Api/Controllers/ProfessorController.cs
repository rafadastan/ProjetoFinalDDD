using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Contracts;
using Projeto.Application.Models;

namespace Projeto.Presentation.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(ProfessorCadastroModel model,
            [FromServices] IProfessorApplicationService professorApplicationService)
        {
            try
            {
                professorApplicationService.Insert(model);
                //retornar status de sucesso 200 (OK)
                return Ok("Professor cadastrado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(ProfessorEdicaoModel model,
            [FromServices] IProfessorApplicationService professorApplicationService)
        {
            try
            {
                professorApplicationService.Update(model);
                //retornar status de atualizado 200 (OK)
                return Ok("Professor atualizado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id,
            [FromServices] IProfessorApplicationService professorApplicationService)
        {
            try
            {
                professorApplicationService.Delete(id);
                //retornar status de sucesso 200 (OK)
                return Ok("Professor deletado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll(
            [FromServices] IProfessorApplicationService professorApplicationService)
        {
            try
            {
                //retornar status de sucesso 200 (OK)
                return Ok(professorApplicationService.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id,
            [FromServices] IProfessorApplicationService professorApplicationService)
        {
            try
            {
                //retornar status de sucesso 200 (OK)
                return Ok(professorApplicationService.GetById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
