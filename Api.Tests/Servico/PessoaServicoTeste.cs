using Api.Infraestrutura.Interfaces;
using Api.Servico;
using Moq;
using Xunit; // Necessário para [Fact] e Assert
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Api.Infraestrutura.Dominio.Entidades; // Necessário para PessoaDominio

namespace Api.Tests.Servico;

// Usa o 'Fact' para identificar que é uma classe de testes
public class PessoaServicoTeste
{
    private readonly Mock<IPessoaRepositorio> _repositorioMock;
    private readonly PessoaServico _service;

    public PessoaServicoTeste()
  {
        _repositorioMock = new Mock<IPessoaRepositorio>();
  }

    // Construtor: Inicializa as dependências antes de cada teste

}
