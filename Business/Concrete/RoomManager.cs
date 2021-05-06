using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RoomManager : IRoomService
    {
        IRoomDal _roomDal;
        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public IResult Add(Room room)
        {
            _roomDal.Add(room);
            return new SuccessResult();
        }

        public IResult Delete(Room room)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Room>> GetAll()
        {
            return new SuccessDataResult<List<Room>>(_roomDal.GetAll());
        }

        public IDataResult<List<Room>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Room room)
        {
            throw new NotImplementedException();
        }
    }
}
