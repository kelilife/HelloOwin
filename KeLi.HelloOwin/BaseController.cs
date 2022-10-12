﻿using System.Collections.Generic;
using System.Web.Http;

namespace KeLi.HelloOwin
{
    public abstract class BaseController<T> : ApiController
    {
        public abstract void Post([FromBody] T value);

        public abstract void Delete(int id);

        public abstract void Put(int id, [FromBody] T value);

        public abstract T Get(int id);

        public abstract List<T> Get();
    }
}