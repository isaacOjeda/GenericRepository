using GenericRepository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenericRepository.Services
{
    public class BaseService
    {
        private IRepository _repository;

        protected IRepository Repository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = new EntityFrameworkRepository<NORTHWNDEntities>(new NORTHWNDEntities());
                }

                return _repository;
            }
        }
    }
}