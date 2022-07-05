using System;
using System.Collections;
using System.Windows.Forms;
using Bulofnaia.API.Entities;
using Bulofnaia.API.Services;
using Bulofnaia.Forms.Components.Table;

namespace Bulofnaia.Forms.Controllers
{
    public class ProfilesController : TableController
    {
        public void Load(TableLayoutPanel layout)
        {
            // read from db
            String[][] dummyData =
            {
                new [] {"1", "Иван Иванов", "заведующий складом"},
                new [] {"2", "Александр Маслов", "кладовщик"},
                new [] {"3", "Пётр Васильев", "грузчик"},
                new [] {"4", "Владислав Цепеш", "фасовщик-упаковщик"}
            };

            layout.SuspendLayout();
            ClearTable(layout, false);
            
            foreach (String[] data in dummyData)
            {
                int lastRowNumber = layout.RowCount;

                layout.Controls.Add(new ProfileData(data[0], data[1], data[2]), 0, lastRowNumber); // profile
                layout.RowCount++;
            }
            layout.ResumeLayout();
        }

        public void CreateProfile(String name, String surname, String position)
        {
            // add to DB
        }
    }
}