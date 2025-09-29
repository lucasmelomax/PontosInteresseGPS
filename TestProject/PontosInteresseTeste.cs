using Moq;
using AutoMapper;
using GPS.Services;
using GPS.UnitOfWork;
using GPS.Models;
using GPS.DTOs;
using GPS.Repository;


namespace TestProject {

    public class PontosInteresseTeste {
        [Fact]
        public async Task PontosProximos_DeveConterPontoQueEstaDentroDoRaio() {

            var uofMock = new Mock<IUnitOfWork>();
            var repoMock = new Mock<IPontosRepository>(); 
            var mapperMock = new Mock<IMapper>();

            var service = new PontosService(mapperMock.Object, uofMock.Object);


            var pontoEsperado = new PontosInteresse { x = 2, y = 3 };

            var pontos = new List<PontosInteresse>
            {
            pontoEsperado,
            new PontosInteresse { x = 50, y = 50 } 
        };

            repoMock.Setup(r => r.GetAll()).ReturnsAsync(pontos);
            uofMock.SetupGet(u => u.PontosRepository).Returns(repoMock.Object);

            mapperMock.Setup(m => m.Map<IEnumerable<PontosInteresseDTO>>(It.IsAny<IEnumerable<PontosInteresse>>()))
                      .Returns((IEnumerable<PontosInteresse> src) =>
                          src.Select(s => new PontosInteresseDTO { x = s.x, y = s.y }).ToList());

            var result = await service.PontosProximos(0, 0, 10); 

            Assert.NotNull(result);
            Assert.Contains(result, r =>  r.x == pontoEsperado.x && r.y == pontoEsperado.y);
        }
    }
}
