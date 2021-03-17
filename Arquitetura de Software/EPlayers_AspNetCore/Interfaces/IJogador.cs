using System.Collections.Generic;
using EPlayers_AspNetCore.Models;

namespace Interfaces
{
    public interface IJogador
    {
        // CRUD Jogador
        void Create(Jogador j);
        List<Jogador> ReadAll();
        void Update(Jogador j);
        void Delete(int id);
    }
}