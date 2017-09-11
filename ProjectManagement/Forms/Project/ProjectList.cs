using BussinessDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectManagement.Forms.Project
{
    public partial class ProjectList : Common.BaseForm
    {
        ProjectBLL proBLL = new ProjectBLL();
        public DomainDLL.Project CurrentProject = null;
        public ProjectList()
        {
            InitializeComponent();
        }
        public int ProjectCount = 0;

        private void ProjectList_Load(object sender, EventArgs e)
        {
            InitControls();
            List<DomainDLL.Project> projectList = proBLL.GetProList();
            ProjectCount = projectList.Count;
            if (projectList.Count > 0)
            {
                foreach (DomainDLL.Project p in projectList)
                {
                    LB_ProjectList.Items.Add(p);
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        void InitControls()
        {
            LB_ProjectList.Items.Clear();
        }


        private void LB_ProjectList_ItemDoubleClick(object sender, MouseEventArgs e)
        {
            if (LB_ProjectList.SelectedItem != null)
            {
                CurrentProject = (DomainDLL.Project)LB_ProjectList.SelectedItem;
                //ProjectId = CurrentProject.ID;
                CurrentNode = null;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
