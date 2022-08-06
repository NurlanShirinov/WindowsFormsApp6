using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.Models;
using WindowsFormsApp6.Vievs;

namespace WindowsFormsApp6.Presenters
{
    public class MainPresenter
    {
        private readonly IMainInterface _view;
        public MainPresenter(IMainInterface view)
        {
            _view = view;
            _view.SaveButton += ViewSaveButtonClick;

        }

        public void ViewSaveButtonClick(object sender, EventArgs e)
        {

            User user = new User
            {
                Name = _view.NameText,
                Surname = _view.SurnameText,
            };
            File.WriteAllText("Users.txt", user.ToString());

        }
    }
}