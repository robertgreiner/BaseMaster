﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaseMaster {
    public partial class _Default : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            BaseResult.Text = "50";
        }

        //TODO: Calculate answer without having to click the submit button
        protected void ConvertToList_SelectedIndexChanged(object sender, EventArgs e) {

        }

        protected void Submit_Click(object sender, EventArgs e) {
            BaseResult.Text = "200";
        }
    }
}
