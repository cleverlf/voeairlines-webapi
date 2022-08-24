using VoeAirlines.Contexts;
using VoeAirlines.Entities;
using VoeAirlines.ViewModels.Aeronave;

namespace VoeAirlines.Services
{
    
    public class AeronaveService
    {
        private readonly VoeAirlinesContext _context;

        public AeronaveService(VoeAirlinesContext context)
        {
            _context = context;
        }

        public DetalhesAeronaveViewModel AdicionarAeronave(AdicionarAeronaveViewModel dados)
        {
            var aeronave = new Aeronave(dados.Fabricante, dados.Modelo, dados.Codigo);

            _context.Add(aeronave);
            _context.SaveChanges();

            return new DetalhesAeronaveViewModel(aeronave.Id, aeronave.Fabricante, aeronave.Modelo, aeronave.Codigo);
        }

        public DetalhesAeronaveViewModel AtualizarAeronave(AtualizarAeronaveViewModel dados)
        {
            var aeronave = new Aeronave(dados.Fabricante, dados.Modelo, dados.Codigo);
            aeronave.Id = dados.Id;

            _context.Update(aeronave);
            _context.SaveChanges();

            return new DetalhesAeronaveViewModel(aeronave.Id, aeronave.Fabricante, aeronave.Modelo, aeronave.Codigo);

        }

        public IEnumerable<Aeronave> ListarAeronaves()
        {
            return _context.Aeronaves.ToList();           
            
        }

        public DetalhesAeronaveViewModel RemoverAeronave(int id)
        {
            var aeronavaParaRemover = _context.Aeronaves.Find(id);
            if (aeronavaParaRemover == null)
            {
                return new DetalhesAeronaveViewModel();
            }
            else
            {
                _context.Aeronaves.Remove(aeronavaParaRemover);
                _context.SaveChanges();
                return new DetalhesAeronaveViewModel(aeronavaParaRemover.Id,aeronavaParaRemover.Fabricante,aeronavaParaRemover.Modelo,aeronavaParaRemover.Codigo);
            } 
        }
        
    }
}
