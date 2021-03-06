﻿using System.Windows;
using System.Windows.Input;
using Editor.Helpers;
using Editor.Models;
using ScheduleData;

namespace Editor.ViewModels.Panels.Edit
{
    class LecturerEditPanelViewModel : HasProjectProperty
    {

        #region Commands

        public ICommand AddLecturerCommand { get { return new DelegateCommand(OnAddLecturer); } }
        public ICommand RemoveLecturerCommand { get { return new DelegateCommand(OnRemoveLecturer); } }

        private void OnRemoveLecturer()
        {
            MessageBox.Show("Remove");
            //var year = param as Lecturer;
            //if (year == null) return;
            //Project.Schedule.RemoveLecturer(year);
        }

        #endregion

        #region Command Handlers

        private void OnAddLecturer()
        {
            Project.Schedule.AddLecturer(new Lecturer { Name = "Новый" });
        }

        #endregion 
        
    }
}
