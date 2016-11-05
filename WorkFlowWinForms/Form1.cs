using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkFlowWinForms
{
    public partial class Form1 : Form
    {
        private WorkflowApplication workflowApplication;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void txtBookMarkName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWorkFlowStart_Click(object sender, EventArgs e)
        {
            //WorkflowInvoker.Invoke(new LeaveActivity(), new Dictionary<string, object>()
            //{
            //    {"BookMarkName",this.txtBookMarkName}
            //});

            workflowApplication = new WorkflowApplication(new LeaveActivity(), new Dictionary<string, object>()
            {
                {"BookMarkName",this.txtBookMarkName.Text}
            });

            workflowApplication.Idle += AfterWorkflowIdel;
            workflowApplication.OnUnhandledException += OnWorkflowExp;
            workflowApplication.Unloaded = a => { Console.WriteLine("workflow unloaded"); };
            workflowApplication.Aborted = a => { Console.WriteLine("workflow abort"); };
            workflowApplication.Run();
        }

        private UnhandledExceptionAction OnWorkflowExp(WorkflowApplicationUnhandledExceptionEventArgs arg)
        {
            Console.WriteLine(arg.UnhandledException.ToString());
            return UnhandledExceptionAction.Terminate;
        }

        private void AfterWorkflowIdel(WorkflowApplicationIdleEventArgs obj)
        {
            Console.WriteLine("workflow stop"); 
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            workflowApplication.ResumeBookmark(txtBookMarkName.Text, int.Parse(txtDays.Text));
        }

        private void txtDays_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStateWorkflowStart_Click(object sender, EventArgs e)
        {
            WorkflowApplication wfApp = new WorkflowApplication(new StateActivity());
            wfApp.Run();
        }
    }
}
