/*using System;
using System.Collections.Generic;*/
using System.Data;
/*using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace LibraryAppProject
{
    public static class UIUtilities
    {
        public static void BindComboBox(this ComboBox cmb, DataTable dt, string displayMember, string valueMember)
        {
            DataRow row = dt.NewRow();
            row[valueMember] = DBNull.Value;
            row[displayMember] = "";
            dt.Rows.InsertAt(row, 0);

            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
            cmb.DataSource = dt;
        }

        public static void Bind(this ComboBox cmb, DataTable dt, string displayMember, string valueMember)
        {
            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
            cmb.DataSource = dt;
        }

        public static void Bind(this ComboBox cmb, DataTable dt, string displayMember, string valueMember, string defaultValue)
        {
            DataRow dr = dt.NewRow();
            dr[displayMember] = defaultValue;
            dr[valueMember] = DBNull.Value;

            dt.Rows.InsertAt(dr, 0);

            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
            cmb.DataSource = dt;
        }
    }
}
