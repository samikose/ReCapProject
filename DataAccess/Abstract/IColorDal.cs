using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IColorDal
    {
        Color GetById(int id);
        List<Color> GetAll();

        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);

    }
}
