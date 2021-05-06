using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRoomService
    {
        IDataResult<List<Room>> GetAll();
        IDataResult<List<Room>> GetById(int id);
        IResult Add(Room room);
        IResult Update(Room room);
        IResult Delete(Room room);
    }
}
