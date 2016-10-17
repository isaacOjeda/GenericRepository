using GenericRepository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenericRepository.Services
{
    public class BaseService
    {
        private IGenericRepository _repository;

        protected IGenericRepository Repository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = new GenericRepository<NORTHWNDEntities>(new NORTHWNDEntities());
                }

                return _repository;
            }
        }
    }
}