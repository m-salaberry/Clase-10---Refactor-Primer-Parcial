﻿using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriaBusiness
    {
        CategoriaDAO catDAO = new CategoriaDAO();

        public List<Categoria> ObtenerListaCategorias()
        {
            try
            {
                return catDAO.GetCategorias();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
