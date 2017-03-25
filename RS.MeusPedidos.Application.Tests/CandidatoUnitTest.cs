using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using RS.MeusPedidos.Application.Interfaces;
using RS.MeusPedidos.Application.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace RS.MeusPedidos.Application.Tests
{
    [TestClass]
    public class CandidatoUnitTest
    {
        private ICandidatoAppService _candidatoAppService;
        private IConhecimentoAppService _conhecimentoAppService;

        [TestInitialize]
        public void CandidatoUnitTestInitialize()
        {
            RS.MeusPedidos.Application.AutoMapper.AutoMapperConfig.RegisterMappings();

            var kernel = new StandardKernel(
                new RS.MeusPedidos.Infrastructure.CrossCutting.IoC.Application.Modules(),
                new RS.MeusPedidos.Infrastructure.CrossCutting.IoC.Domain.Modules()
            );

            _candidatoAppService = kernel.Get<ICandidatoAppService>();
            _conhecimentoAppService = kernel.Get<IConhecimentoAppService>();
        }

        [TestMethod]
        public void CandidatoUnitTest_Ninject_ICandidatoAppService()
        {
            Assert.IsNotNull(_candidatoAppService);
        }

        [TestMethod]
        public void CandidatoUnitTest_CRUD_Insert_Update_FindByEmail()
        {
            var respostas = _conhecimentoAppService.Todos().Select(s => new RespostaViewModel
            {
                ConhecimentoId = s.Id,
                Pontos = 2
            });

            CandidatoViewModel model = new CandidatoViewModel
            {
                Id = Guid.NewGuid(),
                Nome = "Testandecio da Silva",
                Email = "tsilva@teste.com",
                RespostaSet = respostas
            };

            _candidatoAppService.Incluir(model);

            var _model = _candidatoAppService.ObterPorEmail(model.Email, model.Nome);

            bool check = model.Nome == _model.Nome && model.Email == _model.Email;
            foreach (var x in _model.RespostaSet)
                check = check && x.Pontos == 2;

            Assert.IsTrue(check);
        }

        [TestMethod]
        public void CandidatoUnitTest_CRUD_FindByEmail_Delete()
        {
            var _model = _candidatoAppService.ObterPorEmail("Testandecio da Silva", "tsilva@teste.com");

            if (_model != null)
                _candidatoAppService.Remover(_model);

            _model = _candidatoAppService.ObterPorEmail("Testandecio da Silva", "tsilva@teste.com");

            Assert.IsNull(_model);
        }
    }
}
