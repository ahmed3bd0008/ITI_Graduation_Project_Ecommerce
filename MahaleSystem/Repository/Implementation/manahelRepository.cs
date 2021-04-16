using MahaleSystem.Models;
using MahaleSystem.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Repository.Implementation
{
    public class manahelRepository:GenaricRepository<Manahel>, ImanahelRepository
    {
        private readonly ManahelContext _Context;

        public manahelRepository(ManahelContext context):base(context)
        {
            _Context = context;
        }
    }
   
}
