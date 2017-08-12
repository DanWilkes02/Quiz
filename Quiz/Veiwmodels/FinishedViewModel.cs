using Quiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Quiz.Veiwmodels
{
    public class FinishedViewModel : BaseViewModel
    {

        


        public ApplicationViewModel ApplicationViewModel { get; private set; }
        

        public FinishedViewModel(ScoreModel scoreModel, ApplicationViewModel applicationViewModel)
        {
            ScoreModel = scoreModel;

            ApplicationViewModel = applicationViewModel;
          
        }

      


        
    }
}
