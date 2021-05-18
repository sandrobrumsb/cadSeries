using System.Collections.Generic;

namespace cadSeries.Interfaces
{
    public class Irepositorio
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Excluir(int id);
        void Atualizar(int id, T entidade);
        int Proximo();

        private class T
        {
        }
    }
}