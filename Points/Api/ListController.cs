using Points.DataLayer;
using Points.DataLayer.dto;
using Points.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Points.Api
{
    public class ListController : ApiController
    {
        private ListRepository _manager;

        public ListController()
        {
            _manager = new ListRepository();
        }

        [HttpGet]
        public ICollection<Point> GetList(int listID)
        {
            return _manager.GetList(listID);
        }

        [HttpGet] 
        public ICollection<ReducedList> GetAllLists()
        {
            return _manager.GetAllLists();
        }

        public void RemoveList(int listID)
        {
            _manager.RemoveList(listID);
        }

    }
}