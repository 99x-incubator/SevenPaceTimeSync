namespace TimetrackerOnline.BusinessLayer.Models
{
    [global::Microsoft.OData.Client.OriginalNameAttribute("ExportItemViewModelApiSingle")]
    public partial class ExportItemViewModelApiSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ExportItemViewModelApi>
    {
        public ExportItemViewModelApiSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) { }

        public ExportItemViewModelApiSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) { }

        public ExportItemViewModelApiSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ExportItemViewModelApi> query)
            : base(query) { }

    }

    [global::Microsoft.OData.Client.Key("RowID")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ExportItemViewModelApi")]
    public partial class ExportItemViewModelApi : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static ExportItemViewModelApi CreateExportItemViewModelApi(global::System.Guid rowID,
                    global::System.Guid userID,
                    global::System.DateTimeOffset recordDate,
                    global::System.DateTimeOffset recordDateStop,
                    double timeTracked,
                    bool budgetClosed,
                    double durationInSeconds)
        {
            ExportItemViewModelApi exportItemViewModelApi = new ExportItemViewModelApi();
            exportItemViewModelApi.RowID = rowID;
            exportItemViewModelApi.UserID = userID;
            exportItemViewModelApi.RecordDate = recordDate;
            exportItemViewModelApi.RecordDateStop = recordDateStop;
            exportItemViewModelApi.TimeTracked = timeTracked;
            exportItemViewModelApi.BudgetClosed = budgetClosed;
            exportItemViewModelApi.DurationInSeconds = durationInSeconds;
            return exportItemViewModelApi;
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RowID")]
        public global::System.Guid RowID
        {
            get
            {
                return this._RowID;
            }
            set
            {
                this.OnRowIDChanging(value);
                this._RowID = value;
                this.OnRowIDChanged();
                this.OnPropertyChanged("RowID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Guid _RowID;
        partial void OnRowIDChanging(global::System.Guid value);
        partial void OnRowIDChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("UserID")]
        public global::System.Guid UserID
        {
            get
            {
                return this._UserID;
            }
            set
            {
                this.OnUserIDChanging(value);
                this._UserID = value;
                this.OnUserIDChanged();
                this.OnPropertyChanged("UserID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Guid _UserID;
        partial void OnUserIDChanging(global::System.Guid value);
        partial void OnUserIDChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TeamMember")]
        public string TeamMember
        {
            get
            {
                return this._TeamMember;
            }
            set
            {
                this.OnTeamMemberChanging(value);
                this._TeamMember = value;
                this.OnTeamMemberChanged();
                this.OnPropertyChanged("TeamMember");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _TeamMember;
        partial void OnTeamMemberChanging(string value);
        partial void OnTeamMemberChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TFSID")]
        public global::System.Nullable<int> TFSID
        {
            get
            {
                return this._TFSID;
            }
            set
            {
                this.OnTFSIDChanging(value);
                this._TFSID = value;
                this.OnTFSIDChanged();
                this.OnPropertyChanged("TFSID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<int> _TFSID;
        partial void OnTFSIDChanging(global::System.Nullable<int> value);
        partial void OnTFSIDChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TFSTitle")]
        public string TFSTitle
        {
            get
            {
                return this._TFSTitle;
            }
            set
            {
                this.OnTFSTitleChanging(value);
                this._TFSTitle = value;
                this.OnTFSTitleChanged();
                this.OnPropertyChanged("TFSTitle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _TFSTitle;
        partial void OnTFSTitleChanging(string value);
        partial void OnTFSTitleChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Comment")]
        public string Comment
        {
            get
            {
                return this._Comment;
            }
            set
            {
                this.OnCommentChanging(value);
                this._Comment = value;
                this.OnCommentChanged();
                this.OnPropertyChanged("Comment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _Comment;
        partial void OnCommentChanging(string value);
        partial void OnCommentChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RecordDate")]
        public global::System.DateTimeOffset RecordDate
        {
            get
            {
                return this._RecordDate;
            }
            set
            {
                this.OnRecordDateChanging(value);
                this._RecordDate = value;
                this.OnRecordDateChanged();
                this.OnPropertyChanged("RecordDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.DateTimeOffset _RecordDate;
        partial void OnRecordDateChanging(global::System.DateTimeOffset value);
        partial void OnRecordDateChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RecordDateStop")]
        public global::System.DateTimeOffset RecordDateStop
        {
            get
            {
                return this._RecordDateStop;
            }
            set
            {
                this.OnRecordDateStopChanging(value);
                this._RecordDateStop = value;
                this.OnRecordDateStopChanged();
                this.OnPropertyChanged("RecordDateStop");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.DateTimeOffset _RecordDateStop;
        partial void OnRecordDateStopChanging(global::System.DateTimeOffset value);
        partial void OnRecordDateStopChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TimeTracked")]
        public double TimeTracked
        {
            get
            {
                return this._TimeTracked;
            }
            set
            {
                this.OnTimeTrackedChanging(value);
                this._TimeTracked = value;
                this.OnTimeTrackedChanged();
                this.OnPropertyChanged("TimeTracked");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private double _TimeTracked;
        partial void OnTimeTrackedChanging(double value);
        partial void OnTimeTrackedChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ActivityType")]
        public string ActivityType
        {
            get
            {
                return this._ActivityType;
            }
            set
            {
                this.OnActivityTypeChanging(value);
                this._ActivityType = value;
                this.OnActivityTypeChanged();
                this.OnPropertyChanged("ActivityType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _ActivityType;
        partial void OnActivityTypeChanging(string value);
        partial void OnActivityTypeChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TrackedTimeType")]
        public string TrackedTimeType
        {
            get
            {
                return this._TrackedTimeType;
            }
            set
            {
                this.OnTrackedTimeTypeChanging(value);
                this._TrackedTimeType = value;
                this.OnTrackedTimeTypeChanged();
                this.OnPropertyChanged("TrackedTimeType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _TrackedTimeType;
        partial void OnTrackedTimeTypeChanging(string value);
        partial void OnTrackedTimeTypeChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkItemType")]
        public string WorkItemType
        {
            get
            {
                return this._WorkItemType;
            }
            set
            {
                this.OnWorkItemTypeChanging(value);
                this._WorkItemType = value;
                this.OnWorkItemTypeChanged();
                this.OnPropertyChanged("WorkItemType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _WorkItemType;
        partial void OnWorkItemTypeChanging(string value);
        partial void OnWorkItemTypeChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TeamProject")]
        public string TeamProject
        {
            get
            {
                return this._TeamProject;
            }
            set
            {
                this.OnTeamProjectChanging(value);
                this._TeamProject = value;
                this.OnTeamProjectChanged();
                this.OnPropertyChanged("TeamProject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _TeamProject;
        partial void OnTeamProjectChanging(string value);
        partial void OnTeamProjectChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Effort")]
        public global::System.Nullable<double> Effort
        {
            get
            {
                return this._Effort;
            }
            set
            {
                this.OnEffortChanging(value);
                this._Effort = value;
                this.OnEffortChanged();
                this.OnPropertyChanged("Effort");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<double> _Effort;
        partial void OnEffortChanging(global::System.Nullable<double> value);
        partial void OnEffortChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("StoryPoints")]
        public global::System.Nullable<double> StoryPoints
        {
            get
            {
                return this._StoryPoints;
            }
            set
            {
                this.OnStoryPointsChanging(value);
                this._StoryPoints = value;
                this.OnStoryPointsChanged();
                this.OnPropertyChanged("StoryPoints");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<double> _StoryPoints;
        partial void OnStoryPointsChanging(global::System.Nullable<double> value);
        partial void OnStoryPointsChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("OriginalEstimate")]
        public global::System.Nullable<double> OriginalEstimate
        {
            get
            {
                return this._OriginalEstimate;
            }
            set
            {
                this.OnOriginalEstimateChanging(value);
                this._OriginalEstimate = value;
                this.OnOriginalEstimateChanged();
                this.OnPropertyChanged("OriginalEstimate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<double> _OriginalEstimate;
        partial void OnOriginalEstimateChanging(global::System.Nullable<double> value);
        partial void OnOriginalEstimateChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CompletedWork")]
        public global::System.Nullable<double> CompletedWork
        {
            get
            {
                return this._CompletedWork;
            }
            set
            {
                this.OnCompletedWorkChanging(value);
                this._CompletedWork = value;
                this.OnCompletedWorkChanged();
                this.OnPropertyChanged("CompletedWork");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<double> _CompletedWork;
        partial void OnCompletedWorkChanging(global::System.Nullable<double> value);
        partial void OnCompletedWorkChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Budget")]
        public string Budget
        {
            get
            {
                return this._Budget;
            }
            set
            {
                this.OnBudgetChanging(value);
                this._Budget = value;
                this.OnBudgetChanged();
                this.OnPropertyChanged("Budget");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _Budget;
        partial void OnBudgetChanging(string value);
        partial void OnBudgetChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetID")]
        public global::System.Nullable<global::System.Guid> BudgetID
        {
            get
            {
                return this._BudgetID;
            }
            set
            {
                this.OnBudgetIDChanging(value);
                this._BudgetID = value;
                this.OnBudgetIDChanged();
                this.OnPropertyChanged("BudgetID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<global::System.Guid> _BudgetID;
        partial void OnBudgetIDChanging(global::System.Nullable<global::System.Guid> value);
        partial void OnBudgetIDChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("InheritedBudget")]
        public global::System.Nullable<bool> InheritedBudget
        {
            get
            {
                return this._InheritedBudget;
            }
            set
            {
                this.OnInheritedBudgetChanging(value);
                this._InheritedBudget = value;
                this.OnInheritedBudgetChanged();
                this.OnPropertyChanged("InheritedBudget");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<bool> _InheritedBudget;
        partial void OnInheritedBudgetChanging(global::System.Nullable<bool> value);
        partial void OnInheritedBudgetChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetHours")]
        public global::System.Nullable<int> BudgetHours
        {
            get
            {
                return this._BudgetHours;
            }
            set
            {
                this.OnBudgetHoursChanging(value);
                this._BudgetHours = value;
                this.OnBudgetHoursChanged();
                this.OnPropertyChanged("BudgetHours");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<int> _BudgetHours;
        partial void OnBudgetHoursChanging(global::System.Nullable<int> value);
        partial void OnBudgetHoursChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetClosed")]
        public bool BudgetClosed
        {
            get
            {
                return this._BudgetClosed;
            }
            set
            {
                this.OnBudgetClosedChanging(value);
                this._BudgetClosed = value;
                this.OnBudgetClosedChanged();
                this.OnPropertyChanged("BudgetClosed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private bool _BudgetClosed;
        partial void OnBudgetClosedChanging(bool value);
        partial void OnBudgetClosedChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetClosedDate")]
        public global::System.Nullable<global::System.DateTimeOffset> BudgetClosedDate
        {
            get
            {
                return this._BudgetClosedDate;
            }
            set
            {
                this.OnBudgetClosedDateChanging(value);
                this._BudgetClosedDate = value;
                this.OnBudgetClosedDateChanged();
                this.OnPropertyChanged("BudgetClosedDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<global::System.DateTimeOffset> _BudgetClosedDate;
        partial void OnBudgetClosedDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnBudgetClosedDateChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectID")]
        public string ProjectID
        {
            get
            {
                return this._ProjectID;
            }
            set
            {
                this.OnProjectIDChanging(value);
                this._ProjectID = value;
                this.OnProjectIDChanged();
                this.OnPropertyChanged("ProjectID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _ProjectID;
        partial void OnProjectIDChanging(string value);
        partial void OnProjectIDChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("IterationID")]
        public global::System.Nullable<int> IterationID
        {
            get
            {
                return this._IterationID;
            }
            set
            {
                this.OnIterationIDChanging(value);
                this._IterationID = value;
                this.OnIterationIDChanged();
                this.OnPropertyChanged("IterationID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<int> _IterationID;
        partial void OnIterationIDChanging(global::System.Nullable<int> value);
        partial void OnIterationIDChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("IterationPath")]
        public string IterationPath
        {
            get
            {
                return this._IterationPath;
            }
            set
            {
                this.OnIterationPathChanging(value);
                this._IterationPath = value;
                this.OnIterationPathChanged();
                this.OnPropertyChanged("IterationPath");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _IterationPath;
        partial void OnIterationPathChanging(string value);
        partial void OnIterationPathChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AreaPath")]
        public string AreaPath
        {
            get
            {
                return this._AreaPath;
            }
            set
            {
                this.OnAreaPathChanging(value);
                this._AreaPath = value;
                this.OnAreaPathChanged();
                this.OnPropertyChanged("AreaPath");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _AreaPath;
        partial void OnAreaPathChanging(string value);
        partial void OnAreaPathChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TopTFSID")]
        public global::System.Nullable<int> TopTFSID
        {
            get
            {
                return this._TopTFSID;
            }
            set
            {
                this.OnTopTFSIDChanging(value);
                this._TopTFSID = value;
                this.OnTopTFSIDChanged();
                this.OnPropertyChanged("TopTFSID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<int> _TopTFSID;
        partial void OnTopTFSIDChanging(global::System.Nullable<int> value);
        partial void OnTopTFSIDChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TopTFSTitle")]
        public string TopTFSTitle
        {
            get
            {
                return this._TopTFSTitle;
            }
            set
            {
                this.OnTopTFSTitleChanging(value);
                this._TopTFSTitle = value;
                this.OnTopTFSTitleChanged();
                this.OnPropertyChanged("TopTFSTitle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _TopTFSTitle;
        partial void OnTopTFSTitleChanging(string value);
        partial void OnTopTFSTitleChanged();

 [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TopTFSStoryPoint")]
        public global::System.Nullable<double> TopTFSStoryPoint
        {
            get
            {
                return this._TopTFSStoryPoint;
            }
            set
            {
                this.OnTopTFSStoryPointChanging(value);
                this._TopTFSStoryPoint = value;
                this.OnTopTFSStoryPointChanged();
                this.OnPropertyChanged("TopTFSStoryPoint");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<double> _TopTFSStoryPoint;
        partial void OnTopTFSStoryPointChanging(global::System.Nullable<double> value);
        partial void OnTopTFSStoryPointChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ParentTFSID")]
        public global::System.Nullable<int> ParentTFSID
        {
            get
            {
                return this._ParentTFSID;
            }
            set
            {
                this.OnParentTFSIDChanging(value);
                this._ParentTFSID = value;
                this.OnParentTFSIDChanged();
                this.OnPropertyChanged("ParentTFSID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<int> _ParentTFSID;
        partial void OnParentTFSIDChanging(global::System.Nullable<int> value);
        partial void OnParentTFSIDChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ParentTFSTitle")]
        public string ParentTFSTitle
        {
            get
            {
                return this._ParentTFSTitle;
            }
            set
            {
                this.OnParentTFSTitleChanging(value);
                this._ParentTFSTitle = value;
                this.OnParentTFSTitleChanged();
                this.OnPropertyChanged("ParentTFSTitle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _ParentTFSTitle;
        partial void OnParentTFSTitleChanging(string value);
        partial void OnParentTFSTitleChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ParentTFSStoryPoint")]
        public global::System.Nullable<double> ParentTFSStoryPoint
        {
            get
            {
                return this._ParentTFSStoryPoint;
            }
            set
            {
                this.OnParentTFSStoryPointChanging(value);
                this._ParentTFSStoryPoint = value;
                this.OnParentTFSStoryPointChanged();
                this.OnPropertyChanged("ParentTFSStoryPoint");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<double> _ParentTFSStoryPoint;
        partial void OnParentTFSStoryPointChanging(global::System.Nullable<double> value);
        partial void OnParentTFSStoryPointChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkItemState")]
        public string WorkItemState
        {
            get
            {
                return this._WorkItemState;
            }
            set
            {
                this.OnWorkItemStateChanging(value);
                this._WorkItemState = value;
                this.OnWorkItemStateChanged();
                this.OnPropertyChanged("WorkItemState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _WorkItemState;
        partial void OnWorkItemStateChanging(string value);
        partial void OnWorkItemStateChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DurationInSeconds")]
        public double DurationInSeconds
        {
            get
            {
                return this._DurationInSeconds;
            }
            set
            {
                this.OnDurationInSecondsChanging(value);
                this._DurationInSeconds = value;
                this.OnDurationInSecondsChanged();
                this.OnPropertyChanged("DurationInSeconds");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private double _DurationInSeconds;
        partial void OnDurationInSecondsChanging(double value);
        partial void OnDurationInSecondsChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("IsBillable")]
        public global::System.Nullable<bool> IsBillable
        {
            get
            {
                return this._IsBillable;
            }
            set
            {
                this.OnIsBillableChanging(value);
                this._IsBillable = value;
                this.OnIsBillableChanged();
                this.OnPropertyChanged("IsBillable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<bool> _IsBillable;
        partial void OnIsBillableChanging(global::System.Nullable<bool> value);
        partial void OnIsBillableChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BillablePeriodLength")]
        public global::System.Nullable<double> BillablePeriodLength
        {
            get
            {
                return this._BillablePeriodLength;
            }
            set
            {
                this.OnBillablePeriodLengthChanging(value);
                this._BillablePeriodLength = value;
                this.OnBillablePeriodLengthChanged();
                this.OnPropertyChanged("BillablePeriodLength");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<double> _BillablePeriodLength;
        partial void OnBillablePeriodLengthChanging(global::System.Nullable<double> value);
        partial void OnBillablePeriodLengthChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ApprovalState")]
        public string ApprovalState
        {
            get
            {
                return this._ApprovalState;
            }
            set
            {
                this.OnApprovalStateChanging(value);
                this._ApprovalState = value;
                this.OnApprovalStateChanged();
                this.OnPropertyChanged("ApprovalState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _ApprovalState;
        partial void OnApprovalStateChanging(string value);
        partial void OnApprovalStateChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }

    public static class ExtensionMethods
    {
        public static global::TimetrackerOnline.BusinessLayer.Models.ExportItemViewModelApiSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::TimetrackerOnline.BusinessLayer.Models.ExportItemViewModelApi> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::TimetrackerOnline.BusinessLayer.Models.ExportItemViewModelApiSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }

        public static global::TimetrackerOnline.BusinessLayer.Models.ExportItemViewModelApiSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::TimetrackerOnline.BusinessLayer.Models.ExportItemViewModelApi> source,
            global::System.Guid rowID)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "RowID", rowID }
            };
            return new global::TimetrackerOnline.BusinessLayer.Models.ExportItemViewModelApiSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
    }
}
namespace Default
{

    [global::Microsoft.OData.Client.OriginalNameAttribute("Container")]
    public partial class Container : global::Microsoft.OData.Client.DataServiceContext
    {

 [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public Container(global::System.Uri serviceRoot) :
                base(serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion.V4)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
        partial void OnContextCreated();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, "TimetrackerOnline.BusinessLayer.Models", "TimetrackerOnline.BusinessLayer.Models");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            resolvedType = this.DefaultResolveType(typeName, "Default", "Default");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            global::Microsoft.OData.Client.OriginalNameAttribute originalNameAttribute = (global::Microsoft.OData.Client.OriginalNameAttribute)global::System.Linq.Enumerable.SingleOrDefault(global::Microsoft.OData.Client.Utility.GetCustomAttributes(clientType, typeof(global::Microsoft.OData.Client.OriginalNameAttribute), true));
            if (clientType.Namespace.Equals("TimetrackerOnline.BusinessLayer.Models", global::System.StringComparison.Ordinal))
            {
                if (originalNameAttribute != null)
                {
                    return string.Concat("TimetrackerOnline.BusinessLayer.Models.", originalNameAttribute.OriginalName);
                }
                return string.Concat("TimetrackerOnline.BusinessLayer.Models.", clientType.Name);
            }
            if (clientType.Namespace.Equals("Default", global::System.StringComparison.Ordinal))
            {
                if (originalNameAttribute != null)
                {
                    return string.Concat("Default.", originalNameAttribute.OriginalName);
                }
                return string.Concat("Default.", clientType.Name);
            }
            return null;
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TimeEntryExport")]
        public global::Microsoft.OData.Client.DataServiceQuery<global::TimetrackerOnline.BusinessLayer.Models.ExportItemViewModelApi> TimeEntryExport
        {
            get
            {
                if ((this._TimeEntryExport == null))
                {
                    this._TimeEntryExport = base.CreateQuery<global::TimetrackerOnline.BusinessLayer.Models.ExportItemViewModelApi>("TimeEntryExport");
                }
                return this._TimeEntryExport;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::TimetrackerOnline.BusinessLayer.Models.ExportItemViewModelApi> _TimeEntryExport;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public void AddToTimeEntryExport(global::TimetrackerOnline.BusinessLayer.Models.ExportItemViewModelApi exportItemViewModelApi)
        {
            base.AddObject("TimeEntryExport", exportItemViewModelApi);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private static global::Microsoft.OData.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private const string Edmx = @"<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""TimetrackerOnline.BusinessLayer.Models"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""ExportItemViewModelApi"">
        <Key>
          <PropertyRef Name=""RowID"" />
        </Key>
        <Property Name=""RowID"" Type=""Edm.Guid"" Nullable=""false"" />
        <Property Name=""UserID"" Type=""Edm.Guid"" Nullable=""false"" />
        <Property Name=""TeamMember"" Type=""Edm.String"" />
        <Property Name=""TFSID"" Type=""Edm.Int32"" />
        <Property Name=""TFSTitle"" Type=""Edm.String"" />
        <Property Name=""Comment"" Type=""Edm.String"" />
        <Property Name=""RecordDate"" Type=""Edm.DateTimeOffset"" Nullable=""false"" />
        <Property Name=""RecordDateStop"" Type=""Edm.DateTimeOffset"" Nullable=""false"" />
        <Property Name=""TimeTracked"" Type=""Edm.Double"" Nullable=""false"" />
        <Property Name=""ActivityType"" Type=""Edm.String"" />
        <Property Name=""TrackedTimeType"" Type=""Edm.String"" />
        <Property Name=""WorkItemType"" Type=""Edm.String"" />
        <Property Name=""TeamProject"" Type=""Edm.String"" />
        <Property Name=""Effort"" Type=""Edm.Double"" />
        <Property Name=""StoryPoints"" Type=""Edm.Double"" />
        <Property Name=""OriginalEstimate"" Type=""Edm.Double"" />
        <Property Name=""CompletedWork"" Type=""Edm.Double"" />
        <Property Name=""Budget"" Type=""Edm.String"" />
        <Property Name=""BudgetID"" Type=""Edm.Guid"" />
        <Property Name=""InheritedBudget"" Type=""Edm.Boolean"" />
        <Property Name=""BudgetHours"" Type=""Edm.Int32"" />
        <Property Name=""BudgetClosed"" Type=""Edm.Boolean"" Nullable=""false"" />
        <Property Name=""BudgetClosedDate"" Type=""Edm.DateTimeOffset"" />
        <Property Name=""ProjectID"" Type=""Edm.String"" />
        <Property Name=""IterationID"" Type=""Edm.Int32"" />
        <Property Name=""IterationPath"" Type=""Edm.String"" />
        <Property Name=""AreaPath"" Type=""Edm.String"" />
        <Property Name=""TopTFSID"" Type=""Edm.Int32"" />
        <Property Name=""TopTFSTitle"" Type=""Edm.String"" />
        <Property Name=""TopTFSStoryPoint"" Type=""Edm.Double"" />
        <Property Name=""ParentTFSID"" Type=""Edm.Int32"" />
        <Property Name=""ParentTFSTitle"" Type=""Edm.String"" />
        <Property Name=""ParentTFSStoryPoint"" Type=""Edm.Double"" />
        <Property Name=""WorkItemState"" Type=""Edm.String"" />
        <Property Name=""DurationInSeconds"" Type=""Edm.Double"" Nullable=""false"" />
        <Property Name=""IsBillable"" Type=""Edm.Boolean"" />
        <Property Name=""BillablePeriodLength"" Type=""Edm.Double"" />
        <Property Name=""ApprovalState"" Type=""Edm.String"" />
      </EntityType>
    </Schema>
    <Schema Namespace=""Default"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <Function Name=""TimeExport"">
        <Parameter Name=""StartDate"" Type=""Edm.String"" Nullable=""false"" />
        <Parameter Name=""EndDate"" Type=""Edm.String"" Nullable=""false"" />
        <Parameter Name=""PopulateTopParentColumns"" Type=""Edm.Boolean"" />
        <Parameter Name=""GroupTimeByDateByUser"" Type=""Edm.Boolean"" />
        <Parameter Name=""IncludeBillable"" Type=""Edm.Boolean"" />
        <ReturnType Type=""Collection(TimetrackerOnline.BusinessLayer.Models.ExportItemViewModelApi)"" />
      </Function>
      <EntityContainer Name=""Container"">
        <EntitySet Name=""TimeEntryExport"" EntityType=""TimetrackerOnline.BusinessLayer.Models.ExportItemViewModelApi"" />
        <FunctionImport Name=""TimeExport"" Function=""Default.TimeExport"" EntitySet=""TimeEntryExport"" IncludeInServiceDocument=""true"" />
      </EntityContainer>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            public static global::Microsoft.OData.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private static global::Microsoft.OData.Edm.IEdmModel LoadModelFromString()
            {
                global::System.Xml.XmlReader reader = CreateXmlReader(Edmx);
                try
                {
                    return global::Microsoft.OData.Edm.Csdl.EdmxReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }

        [global::Microsoft.OData.Client.OriginalNameAttribute("TimeExport")]
        public global::Microsoft.OData.Client.DataServiceQuery<global::TimetrackerOnline.BusinessLayer.Models.ExportItemViewModelApi> TimeExport(string StartDate, string EndDate, global::System.Nullable<bool> PopulateTopParentColumns, global::System.Nullable<bool> GroupTimeByDateByUser, global::System.Nullable<bool> IncludeBillable)
        {
            return this.CreateFunctionQuery<global::TimetrackerOnline.BusinessLayer.Models.ExportItemViewModelApi>("", "TimeExport", false, new global::Microsoft.OData.Client.UriOperationParameter("StartDate", StartDate),
                    new global::Microsoft.OData.Client.UriOperationParameter("EndDate", EndDate),
                    new global::Microsoft.OData.Client.UriOperationParameter("PopulateTopParentColumns", PopulateTopParentColumns),
                    new global::Microsoft.OData.Client.UriOperationParameter("GroupTimeByDateByUser", GroupTimeByDateByUser),
                    new global::Microsoft.OData.Client.UriOperationParameter("IncludeBillable", IncludeBillable));
        }
    }
}
