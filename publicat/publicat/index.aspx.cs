﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using publicat.Data;


using System.Data;

namespace publicat
{
    

    public partial class index : System.Web.UI.Page
    {
        public DataTable dtThemes;
        public DataTable dtArticles;

        protected void Page_Load(object sender, EventArgs e)
        {

            dtThemes = Data.Data.getThemes();
            dtArticles = Data.Data.getArticles();
        }
    }
}