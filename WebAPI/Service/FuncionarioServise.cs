using WebAPI.DataContext;
using WebAPI.Models;

namespace WebAPI.Service.FuncionariosService
{
    public class FuncionarioService : IFuncionarioInterface
    {
        private readonly ApplicationDbContext _context;
        public FuncionarioService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<ServiceRespose<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceRespose<List<FuncionarioModel>>> DeleteFuncionarios(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceRespose<FuncionarioModel>> GetFuncionarioById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceRespose<List<FuncionarioModel>>> GetFuncionarios()
        {
            ServiceResponse<List< FuncionarioModel >> serviceResponse = new ServiceResponse<List<FuncionarioModel>>();

            try
            {
                serviceResponse.Dados = _context.Funcionarios.ToList();



            }
            catch (Exception ex)
            {

              
            }

            return serviceResponse;


        }
        public Task<ServiceRespose<List<FuncionarioModel>>> InativaFuncionario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceRespose<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editadoFuncionario)
        {
            throw new NotImplementedException();
        }
    }
}
