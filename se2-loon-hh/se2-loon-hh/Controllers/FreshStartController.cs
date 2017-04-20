﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se2_loon_hh.Controllers
{
    class FreshStartController : IDisposable
    {
        Entities _db;

        /// <summary>
        /// This function returns a list of fresh start programs for display in a data grid.
        /// </summary>
        /// <returns>List of generic objects for display in a data grid.</returns>
        public List<object> getAllFreshStartPrograms()
        {
            List<object> freshStartPrograms = new List<object>();//create list
            //loop through each fresh start program and add data to the list
            foreach (var freshStart in _db.FreshStarts.ToList())
            {
                freshStartPrograms.Add(new {
                    Name = freshStart.Name,
                    CurriculumType = freshStart.CurriculumType,
                    Comment = freshStart.Comment
                });
            }
            //send the list to the view
            return freshStartPrograms;
        }

        /// <summary>
        /// This function stores a fresh start program into the database.
        /// </summary>
        /// <param name="freshStart"></param>
        public void saveFreshStart(FreshStart freshStart)
        {
            _db.FreshStarts.Add(freshStart);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            ((IDisposable)_db).Dispose();
        }
    }
}
