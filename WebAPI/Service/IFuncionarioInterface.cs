using WebAPI.Models;

namespace WebAPI.Service
{
    public interface IFuncionarioInterface 
    {
        Task<ServiceRespose<List<FuncionarioModel>>> GetFuncionarios();
        Task<ServiceRespose<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario);
        Task<ServiceRespose<FuncionarioModel>> GetFuncionarioById(int id);
        Task<ServiceRespose<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editadoFuncionario);
        Task<ServiceRespose<List<FuncionarioModel>>> DeleteFuncionarios(int id);
        Task<ServiceRespose<List<FuncionarioModel>>> InativaFuncionario(int id);
    }
}
