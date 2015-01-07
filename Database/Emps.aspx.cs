﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database
{
    public partial class Emps : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			//if ((int)Session["Role"] == -1)
			//	Server.Transfer("Load.aspx");


			gv_emps.DataBind();
        }


        protected void btn_emps_Click(object sender, EventArgs e)
        {
            Server.Transfer("Emps.aspx");
        }


        protected void btn_emp_phones_Click(object sender, EventArgs e)
        {
            Server.Transfer("Phones.aspx");
        }


        protected void btn_emp_addr_Click(object sender, EventArgs e)
        {
            Server.Transfer("Addresses.aspx");
        }


        protected void btn_add_emp_Click(object sender, EventArgs e)
        {
            Server.Transfer("Add_employee.aspx");
        }
    }
}