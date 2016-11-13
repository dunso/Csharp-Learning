using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace WorkFlowWinForms
{
    // stop the winform and write the information to the workflow
    public sealed class InputDaysActivity : NativeActivity
    {
        // Define an activity input argument of type string
        public InArgument<string> inBookMarkName { get; set; }

        public OutArgument<int> outDays { get; set; }

        public InOutArgument<string> inOutStr { get; set; }

        protected override bool CanInduceIdle
        {
            get
            {
                return true;
            }
        }
        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(NativeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            //string text = context.GetValue(this.Text);


            //stop the workflow

            //when have data , let the workflow continue
            string bookMarkName = context.GetValue(inBookMarkName);

            //create bookmark
            Console.WriteLine("cretae bookmark");
            context.CreateBookmark(bookMarkName,new BookmarkCallback(CallBackFun));

            //int days = int.Parse(Console.ReadLine());

            //context.SetValue(outDays, days);
        }

        //after bookmark,it will be callback
        private void CallBackFun(NativeActivityContext context, Bookmark bookmark, object value)
        {
            context.SetValue(outDays, (int)value);
            Console.WriteLine("bookmark continue");
        }
    }
}
