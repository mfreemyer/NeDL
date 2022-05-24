using System;

namespace Calculator_MVC
{
    class CalcController
    {
        // The CalcController class brings together the CalcModel and CalcView classes.
        // the the controller takes the inputs, looks at the model, and the does the math

        private CalcModel model;
        private CalcView view;

        public CalcController()
        {
            // instantiate a model
            model = new CalcModel(view.Num1, view.Num2, view.Op);
            // instantiate a view
            view = new CalcView();

            // interaction between model and view in inputting and outputting the information
            view.Result = model.DoOperation();
            view.ShowResult();

        }


    }

    
}