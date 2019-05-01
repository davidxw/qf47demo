﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace qf47demo.Pages
{
    public class PrivacyModel : PageModel
    {
        public void OnGet()
        {
            System.Diagnostics.Trace.TraceError("Fake error from privacy page");
            System.Diagnostics.Trace.TraceWarning("Fake warning from privacy page");
        }
    }
}
