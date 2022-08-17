using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testAlarm.Controls
{
    public partial class Login : UserControl
    {
        internal static DataSet Local_UserAccess = new DataSet();

        internal static DataTable Local_UserTable = new DataTable();
        internal static DataTable Local_AccessTable = new DataTable();

        private static Login instance = null;
        private static readonly object padlock = new object();
        public Login()
        {
            InitializeComponent();

            ConfigDataset();

            DBAccess_Provider.Tools.Config();

            DBAccess_Provider.Adapter.Fill(Local_UserAccess, "Local_AccessTable", "AccessTable", DataGrid_Access);
        }

        public static Login GetInstance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new Login();
                    return instance;
                }
            }
        }

		private static void ConfigDataset()
		{
			DataColumn UserKey_ID = new DataColumn("A", System.Type.GetType("System.Int16"));
			DataColumn UserName = new DataColumn("B", System.Type.GetType("System.String"));
			DataColumn UserPassword = new DataColumn("C", System.Type.GetType("System.String"));
			DataColumn Access_Id = new DataColumn("D", System.Type.GetType("System.Int16"));

			DataColumn AccessKey_Id = new DataColumn("E", System.Type.GetType("System.Int16"));
			DataColumn AccessName = new DataColumn("F", System.Type.GetType("System.String"));
			DataColumn AllowCreateID = new DataColumn("G", System.Type.GetType("System.Boolean"));
			DataColumn AllowDestroyID = new DataColumn("H", System.Type.GetType("System.Boolean"));
			DataColumn AllowConfigAlarm = new DataColumn("I", System.Type.GetType("System.Boolean"));
			DataColumn UserCreation = new DataColumn("J", System.Type.GetType("System.Boolean"));

			Local_UserTable.TableName = "Local_UserTable";
			Local_AccessTable.TableName = "Local_AccessTable";

			Local_UserAccess.Tables.Add(Local_UserTable);
			Local_UserAccess.Tables.Add(Local_AccessTable);

			UserKey_ID.AutoIncrement = true;
			UserKey_ID.Unique = true;
			UserKey_ID.ColumnName = "UserKey_ID";
			UserKey_ID.DataType = System.Type.GetType("System.Int32");
			Local_UserTable.Columns.Add(UserKey_ID);

			UserName.AutoIncrement = false;
			UserName.Unique = false;
			UserName.ColumnName = "UserName";
			UserName.DataType = System.Type.GetType("System.String");
			Local_UserTable.Columns.Add(UserName);

			UserPassword.AutoIncrement = false;
			UserPassword.Unique = false;
			UserPassword.ColumnName = "UserPassword";
			UserPassword.DataType = System.Type.GetType("System.String");
			Local_UserTable.Columns.Add(UserPassword);

			Access_Id.AutoIncrement = false;
			Access_Id.Unique = false;
			Access_Id.ColumnName = "Access_Id";
			Access_Id.DataType = System.Type.GetType("System.Int32");
			Local_UserTable.Columns.Add(Access_Id);

			AccessKey_Id.AutoIncrement = true;
			AccessKey_Id.Unique = true;
			AccessKey_Id.ColumnName = "AccessKey_Id";
			AccessKey_Id.DataType = System.Type.GetType("System.Int32");
			Local_AccessTable.Columns.Add(AccessKey_Id);

			AccessName.AutoIncrement = false;
			AccessName.Unique = false;
			AccessName.ColumnName = "AccessName";
			AccessName.DataType = System.Type.GetType("System.String");
			Local_AccessTable.Columns.Add(AccessName);

			AllowCreateID.AutoIncrement = false;
			AllowCreateID.Unique = false;
			AllowCreateID.ColumnName = "AllowCreateID";
			AllowCreateID.DataType = System.Type.GetType("System.Boolean");
			Local_AccessTable.Columns.Add(AllowCreateID);

			AllowDestroyID.AutoIncrement = false;
			AllowDestroyID.Unique = false;
			AllowDestroyID.ColumnName = "AllowDestroyID";
			AllowDestroyID.DataType = System.Type.GetType("System.Boolean");
			Local_AccessTable.Columns.Add(AllowDestroyID);

			AllowConfigAlarm.AutoIncrement = false;
			AllowConfigAlarm.Unique = false;
			AllowConfigAlarm.ColumnName = "AllowConfigAlarm";
			AllowConfigAlarm.DataType = System.Type.GetType("System.Boolean");
			Local_AccessTable.Columns.Add(AllowConfigAlarm);

			UserCreation.AutoIncrement = false;
			UserCreation.Unique = false;
			UserCreation.ColumnName = "UserCreation";
			UserCreation.DataType = System.Type.GetType("System.Boolean");
			Local_AccessTable.Columns.Add(UserCreation);

			DataColumn parentColumn = Local_UserAccess.Tables["Local_AccessTable"].Columns["AccessKey_Id"];
			DataColumn childColumn = Local_UserAccess.Tables["Local_UserTable"].Columns["Access_Id"];

			DataRelation relation = new DataRelation("parent2Child", parentColumn, childColumn);

			Local_UserAccess.Tables["Local_UserTable"].ParentRelations.Add(relation);
		}

		private void Login_Load(object sender, EventArgs e)
        {
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            DBAccess_Provider.Adapter.Update(Local_UserAccess.Tables["Local_UserTable"]);

        }

        private void Button_DBRead_Click(object sender, EventArgs e)
        {
            DBAccess_Provider.DataReader.Read(DataGrid_DBUsers, "UserTable");

        }

        private void Button_DBInsert_Click(object sender, EventArgs e)
        {
            DBAccess_Provider.Adapter.Insert(TextBox_Name.Text);

        }

        private void Button_DBDelete_Click(object sender, EventArgs e)
        {
            DBAccess_Provider.Adapter.Delete(TextBox_Name.Text);

        }
    }
}
