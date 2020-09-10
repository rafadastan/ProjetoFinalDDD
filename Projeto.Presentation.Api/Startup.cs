using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Projeto.Application.Contracts;
using Projeto.Application.Services;
using Projeto.CrossCutting.CrossCuttings;
using Projeto.Domain.Contracts.CrossCutting;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Services;
using Projeto.Infra.Data.Contexts;
using Projeto.Infra.Data.Contracts;
using Projeto.Infra.Data.Repositories;

namespace Projeto.Presentation.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            #region SWAGGER
            //configurando a documenta��o da API gerada pelo swagger
            services.AddSwaggerGen(s =>
            {
                new OpenApiInfo
                {
                    Title = "API de controle de escolas e cursos",
                    Version = "v1",
                    Description = "Sistema desenvolvido em NET CORE API com arquitetura DDD(Domain Driven Design)",
        
                    Contact = new OpenApiContact
                    {
                        Name = "COTI Inform�tica",
                        Url = new Uri("http://www.cotiinformatica.com.br"),
                        Email = "contato@cotiinformatica.com.br"
                    }
                };
            });
            #endregion

            #region EntityFramework
            services.AddDbContext<DataContext>
                (options => options.UseSqlServer(
                    Configuration.GetConnectionString("ProjetoFinal")));
            #endregion

            #region UnitOfWork
            // services.AddTransient<IUnitOfWork,UnitOfWork>();
            #endregion

            #region Inje��o de Dependencia

            services.AddTransient<IAlunoApplicationService, AlunoApplicationService>();
            services.AddTransient<IMatriculaApplicationService, MatriculaApplicationService>();
            services.AddTransient<IProfessorApplicationService, ProfessorApplicationService>();
            services.AddTransient<ITurmaApplicationService, TurmaApplicationService>();
            services.AddTransient<IUsuarioApplicationService, UsuarioApplicationService>();

            services.AddTransient<IAlunoDomainService, AlunoDomainService>();
            services.AddTransient<IMatriculaDomainService, MatriculaDomainService>();
            services.AddTransient<IProfessorDomainService, ProfessorDomainService>();
            services.AddTransient<ITurmaDomainService, TurmaDomainService>();
            services.AddTransient<IUsuarioDomainService, UsuarioDomainService>();

            services.AddTransient<IAlunoRepository, AlunoRepository>();
            services.AddTransient<IMatriculaRepository, MatriculaRepository>();
            services.AddTransient<IProfessorRepository, ProfessorRepository>();
            services.AddTransient<ITurmaRepository, TurmaRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();

            services.AddTransient<IMD5Cryptography, MD5Cryptography>();

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            #region Swagger
            app.UseSwagger();

            app.UseSwaggerUI(s => s.SwaggerEndpoint
            ("/swagger/v1/swagger.json", "apicotiescola"));
            #endregion

            app.UseEndpoints(endpoints =>
            {   
                endpoints.MapControllers();
            });
        }
    }
}
