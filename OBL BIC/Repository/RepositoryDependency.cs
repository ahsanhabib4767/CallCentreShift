using Microsoft.Data.SqlClient;
using OBL.BIC.Model;
using OBL.CSRM.IRepository;
using OBL.CSRM.Model;
using System.Data;
using System.Data.Common;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace OBL.CSRM.Repository
{
    public class RepositoryDependency : IRepositoryDependency
    {
        private readonly string _connectionString;

        public RepositoryDependency(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("TestCon");
        }
        public List<DynamicData> GetItemsByType(string itemType)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("GetDictionaryData", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@info", itemType);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<DynamicData> items = new List<DynamicData>();
                while (reader.Read())
                {
                    DynamicData item = new DynamicData();
                    item.ShiftTimingID = reader.GetInt32(reader.GetOrdinal("ShiftTimingID"));
                    item.ShiftName = reader.GetString(reader.GetOrdinal("ShiftName"));
                    item.ShiftCode = reader.GetString(reader.GetOrdinal("ShiftCode"));
                    items.Add(item);
                }
                return items;
            }
        }

        public List<ShiftAllInformation> GetAllShiftInformation(string itemType)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("GetShiftInfoData", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@stat", itemType);
                command.Parameters.AddWithValue("@empid", 0);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<ShiftAllInformation> items = new List<ShiftAllInformation>();
                while (reader.Read())
                {
                    ShiftAllInformation item = new ShiftAllInformation();
                    item.ShiftTimingID = reader.GetInt32(reader.GetOrdinal("ShiftTimingID"));
                    item.ShiftName = reader.GetString(reader.GetOrdinal("ShiftName"));
                    item.EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID"));
                    item.EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName"));
                    item.ShiftDate = reader.GetDateTime(reader.GetOrdinal("ShiftDate"));
                    item.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    
                    items.Add(item);
                }
                return items;
            }
        }


        public List<ShiftAllInformation> GetAllShiftInformationByID(string itemType,int empid)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("GetShiftInfoData", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@stat", itemType);
                command.Parameters.AddWithValue("@empid", empid);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<ShiftAllInformation> items = new List<ShiftAllInformation>();
                while (reader.Read())
                {
                    ShiftAllInformation item = new ShiftAllInformation();
                    item.ShiftTimingID = reader.GetInt32(reader.GetOrdinal("ShiftTimingID"));
                    item.ShiftName = reader.GetString(reader.GetOrdinal("ShiftName"));
                    item.EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID"));
                    item.EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName"));
                    item.ShiftDate = reader.GetDateTime(reader.GetOrdinal("ShiftDate"));
                    item.Gender = reader.GetString(reader.GetOrdinal("Gender"));

                    items.Add(item);
                }
                return items;
            }
        }
        public List<ShiftTimingDropDown> GetAllShiftDropdownInformationByDate(DateTime itemtype)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("GetShiftInfoDataByDate", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@dateparam", itemtype);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<ShiftTimingDropDown> items = new List<ShiftTimingDropDown>();
                while (reader.Read())
                {
                    ShiftTimingDropDown item = new ShiftTimingDropDown();
                    item.EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID"));
                    item.DropDownInfo = reader.GetString(reader.GetOrdinal("DropDownInfo"));
                    

                    items.Add(item);
                }
                return items;
            }

        }

        public DataTable GetAllShiftCount()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetShiftDataPivot", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter outputParameter = new SqlParameter("@ShiftDataPivotResult", SqlDbType.NVarChar, -1);
                outputParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(outputParameter);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        //Insert 
        public string InsertDataIntoDB(int employeeId1, int employeeId2, DateTime dropDownInfo)
        {
            string message = "";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("InsertSwapSP", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@employeeIdA", employeeId1);
                command.Parameters.AddWithValue("@employeeIdB", employeeId2);
                command.Parameters.AddWithValue("@swapDate", dropDownInfo);
                SqlParameter outputParameter = new SqlParameter("@outputMessage", SqlDbType.NVarChar, 100);
                outputParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(outputParameter);
                connection.Open();
                command.ExecuteNonQuery();
                message = command.Parameters["@outputMessage"].Value.ToString()??"";
            }

            return message;
        }


    }
}

