using AutoMapper;
using GPS.Context;
using GPS.DTOs;
using GPS.Models;
using GPS.UnitOfWork;

namespace GPS.Services {
    public class PontosService : IPontosService {

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uof;
        private PontosDbContext context;

        public PontosService(IMapper mapper, IUnitOfWork uof) {
            _mapper = mapper;
            _uof = uof;
        }
        public async Task<IEnumerable<PontosInteresseDTO>> GetAll() {
            
            var pontos = await _uof.PontosRepository.GetAll();

            if (pontos == null) throw new ArgumentNullException("Não existe nenhum ponto.");

            var todos = _mapper.Map<IEnumerable<PontosInteresseDTO>>(pontos);

            return todos;
        }
        public async Task<PontosInteresseDTO> Post(PontosInteresseDTO dto) {
            if (dto == null) throw new ArgumentNullException("Ponto invalido.");

            var ponto = _mapper.Map<PontosInteresse>(dto);

            var pontoCriado = await _uof.PontosRepository.Post(ponto);

            await _uof.CommitAsync();

            return _mapper.Map<PontosInteresseDTO>(pontoCriado);
        }

        public async Task<IEnumerable<PontosInteresseDTO>> PontosProximos(double x, double y, double dist) {

            var pontos = await _uof.PontosRepository.GetAll();

            if (pontos == null) throw new ArgumentNullException("Não existe nenhum ponto.");

            var pontosPertos = pontos
                .Where(p => Math.Sqrt(Math.Pow(p.x - x, 2) + Math.Pow(p.y - y, 2)) <= dist)
                .ToList();

            return _mapper.Map<IEnumerable<PontosInteresseDTO>>(pontosPertos);
        }

    }
}
