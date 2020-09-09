using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Contracts;
using Projeto.Application.Models;

namespace Projeto.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculaController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(MatriculaCadastroModel model,
            [FromServices] IMatriculaApplicationService matriculaApplicationService)
        {
            try
            {
                matriculaApplicationService.Insert(model);
                return Ok("Matricula Cadastrado com sucesso!");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(MatriculaEdicaoModel model,
            [FromServices] IMatriculaApplicationService matriculaApplicationService)
        {
            try
            {
                matriculaApplicationService.Update(model);
                return Ok("Matricula Atualizado com sucesso!");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id,
            [FromServices] IMatriculaApplicationService matriculaApplicationService)
        {
            try
            {
                matriculaApplicationService.Delete(id);
                return Ok("Matricula deletado com sucesso!");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpGet]
        public IActionResult GetAll([FromServices] IMatriculaApplicationService matriculaApplicationService)
        {
            try
            {
                return Ok(matriculaApplicationService.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id,
            [FromServices] IMatriculaApplicationService matriculaApplicationService)
        {
            try
            {
                return Ok(matriculaApplicationService.GetById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
