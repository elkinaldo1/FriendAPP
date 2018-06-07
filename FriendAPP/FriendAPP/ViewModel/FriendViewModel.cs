using FriendAPP.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FriendAPP.ViewModel
{
    public class FriendViewModel
    {
        #region Propiedades

        public Command SaveCommand { get; set; }
        public Command DeleteCommand { get; set; }
        public Boolean IsEnable { get; set; }
        public Friend FriendModel { get; set; }

        #endregion

        #region Contructores

        public FriendViewModel()
        {

        }
        #endregion
    }
}
