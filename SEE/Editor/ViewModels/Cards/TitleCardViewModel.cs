﻿using Editor.Models;

namespace Editor.ViewModels.Cards
{
    class TitleCardViewModel : HasClassesScheduleProperty
    {
        #region Properties

        #region Item

        private HavingName _item;
        public HavingName Item
        {
            get { return _item; }
            set
            {
                if (_item != value)
                {
                    _item = value;
                    RaisePropertyChanged(() => Item);
                }
            }
        }

        #endregion

        #endregion

        #region Ctor


        public TitleCardViewModel(HavingName name)
        {
            _item = name;
        }

        #endregion

        protected override void ClassesScheduleOnPropertyChanged()
        {
            
        }
    }
}
