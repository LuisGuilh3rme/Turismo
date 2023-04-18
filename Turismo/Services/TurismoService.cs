﻿using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using Dapper;
using Turismo.Models;
using Turismo.Repositories;

namespace Turismo.Services
{
    internal class TurismoService
    {

        public void AtualizarCampo(int id, string tabela, string campo, string atualizarString)
        {
            new TurismoRepository().AtualizarCampo(id, tabela, campo, atualizarString);
        }

        public void RemoverPacote(int id)
        {
            new TurismoRepository().RemoverPacote(id);
        }

        public void Inserir(Pacote pacote)
        {
            new TurismoRepository().Inserir(pacote);
        }
    }
}
