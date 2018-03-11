using System;
using System.Collections.Generic;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class JobFieldsViewModel : BaseViewModel
    {
        // TODO #7.2 - Extract members common to SearchJobsViewModel --DONE: Kyla
        // to BaseViewModel

        // All fields in the given column
        public IEnumerable<JobField> Fields { get; set; }

    //Constructor
        public JobFieldsViewModel()
        {


        }
    }
}
