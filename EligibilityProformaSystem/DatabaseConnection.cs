using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace EligibilityProformaSystem
{
    class DatabaseConnection
    {
        public SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["EligibilityProformaSystem"].ConnectionString);
        public SqlCommand query;


        public int ValidateAdmin(string Username, string Password)
        {
            try
            {
                conn.Open();
                query = new SqlCommand("select * from Admin_Table where Username='" + Username + "' and Password='" + Password + "'", conn);
                SqlDataReader ValidData = query.ExecuteReader();
                if (ValidData.Read())
                {
                    return 0;
                }
                return 1;
            }
            catch (Exception ex)
            {
                return 2;
            }
            finally 
            {
                conn.Close();
            }
        }

        public int ValidateFavPlayer(string favPlayer) 
        {
            try
            {
                conn.Open();
                query = new SqlCommand("select * from Admin_Table where Fav_Player='"+favPlayer+"'",conn);
                SqlDataReader ValidData = query.ExecuteReader();
                if (ValidData.Read())
                {
                    return 0;
                }
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 2;
            }
            finally
            {
                conn.Close();
            }
        }

        public int SavePassword(string password)
        {
            try
            {
                conn.Open();
                query = new SqlCommand("update Admin_Table set Password='" + password + "'", conn);

                if (query.ExecuteNonQuery() > 0)
                {
                    return 0;
                }
                return 1;
            }
            catch (Exception ex)
            {
                return 2;
            }
            finally
            {
                conn.Close();
            }
        }

        public int InsertPlayerData(params string[] data)
        {
            try
            {
                conn.Open();
                query = new SqlCommand("insert into Player_Table values('"+Convert.ToInt64(data[0])+"','"+Convert.ToInt32(data[1])+"','"+data[2]+"','"+data[3]+"','"+data[4]+"','"+data[5]+"','"+data[6]+"','"+Convert.ToInt32(data[7])+"','"+Convert.ToInt32(data[8])+"','"+Convert.ToInt32(data[9])+"','"+Convert.ToInt64(data[10])+"','"+data[11]+"')", conn);
                if (query.ExecuteNonQuery() > 0)
                {
                    return 0;
                }
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 2;
            }
            finally
            {
                conn.Close();
            }
        }

        public SqlDataAdapter GetAllData(string tablename)
        {
            SqlDataAdapter da=null;;
            try
            {
                conn.Open();
                query = new SqlCommand("select * from " + tablename, conn);
                da = new SqlDataAdapter(query);
                return da;
            }
            catch (Exception ex)
            {
                return da;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool UpdateData(string dataof,string StoreProcedureName,params string[] data)
        {
            try
            {
                conn.Open();
                query = new SqlCommand(StoreProcedureName, conn);
                query.CommandType = CommandType.StoredProcedure;
                if (dataof == "Player Data")
                {
                    query.Parameters.AddWithValue("@PRNNumber", Convert.ToInt64(data[0]));
                    query.Parameters.AddWithValue("@RollNumber", Convert.ToInt32(data[1]));
                    query.Parameters.AddWithValue("@FullName", data[2]);
                    query.Parameters.AddWithValue("@MotherName", data[3]);
                    query.Parameters.AddWithValue("@DateOfBirth", data[4]);
                    query.Parameters.AddWithValue("@HSCPassingYear", data[5]);
                    query.Parameters.AddWithValue("@CourceYearAndClass", data[6]);
                    query.Parameters.AddWithValue("@AdmissionToCollege", Convert.ToInt32(data[7]));
                    query.Parameters.AddWithValue("@AdmissionToCource", Convert.ToInt32(data[8]));
                    query.Parameters.AddWithValue("@AdmissionToClass", Convert.ToInt32(data[9]));
                    query.Parameters.AddWithValue("@ContactNumber", Convert.ToInt64(data[10]));
                    query.Parameters.AddWithValue("@Email", data[11]);
                }
                if (dataof == "Staff Data")
                {
                    query.Parameters.Add("@ID", Convert.ToInt32(data[0]));
                    query.Parameters.Add("@FullName", data[1]);
                    query.Parameters.Add("@StatusOfStaff", data[2]);
                    query.Parameters.Add("@ContactNumber", Convert.ToInt64(data[3]));
                    query.Parameters.Add("@Address", data[4]);
                }
                if (dataof == "Match Data")
                {
                    query.Parameters.Add("@ID", Convert.ToInt32(data[0]));
                    query.Parameters.Add("@TournamentName", data[1]);
                    query.Parameters.Add("@TournamentStartDate", data[2]);
                    query.Parameters.Add("@TournamentEndDate", data[3]);
                    query.Parameters.Add("@ParticipatingCollege", data[4]);
                    query.Parameters.Add("@OrganizingCollege", data[5]);
                }
                if (query.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally 
            {
                conn.Close();
            }
        }

        public int InsertIntoStaffTable(params string[] data)
        {
            try
            {
                conn.Open();
                query = new SqlCommand("insert into Staff_Table(FullName,StatusOfStaff,ContactNumber,Address) values('"+data[0]+"','"+data[1]+"','"+Convert.ToInt64(data[2])+"','"+data[3]+"')", conn);
                if (query.ExecuteNonQuery() > 0)
                {
                    return 0;
                }
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 2;
            }
            finally
            {
                conn.Close();
            }
        }

        public int InsertIntoMatchTable(params string[] data)
        {
            try
            {
                conn.Open();
                query = new SqlCommand("insert into Match_Table(TournamentName,TournamentStartDate,TournamentEndDate,ParticipatingCollege,OrganizingCollege) values('"+data[0]+"','"+data[1]+"','"+data[2]+"','"+data[3]+"','"+data[4]+"')", conn);
                if (query.ExecuteNonQuery() > 0)
                {
                    return 0;
                }
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 2;
            }
            finally
            {
                conn.Close();
            }
        }

        public int InsertIntoEligibilityTable(long prn,params string[] otherinfo)
        {
            try
            {
                conn.Open();
                query = new SqlCommand("insert into Eligibility_Table(PRNNumber,PlayerFullName,StaffFullName,TournamentName,TournamentStartDate,TournamentEndDate) values('"+prn+"','"+otherinfo[0]+"','"+otherinfo[1]+"','"+otherinfo[2]+"','"+otherinfo[3]+"','"+otherinfo[4]+"')", conn);
                if (query.ExecuteNonQuery() > 0)
                {
                    return 0;
                }
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 2;
            }
            finally
            {
                conn.Close();
            }
        }

        public string chkDataExist(int id)
        {
            try
            {
                conn.Open();
                query = new SqlCommand("select * from ProductIDs where ProductID='"+id+"'", conn);
                SqlDataReader dr = query.ExecuteReader();
                if (dr.Read())
                    return dr["ProductName"].ToString();
            }
            catch (Exception ex)
            {
                return "Data Not Found";
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public void InsertIntoProductIDs(params string[] productids)
        {
            try
            {
                conn.Open();
                query = new SqlCommand("insert into ProductIDs values('"+Convert.ToInt32(productids[0])+"','"+productids[1]+"','"+Convert.ToInt32(productids[2])+"',0)", conn);
                if (query.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("ID Created Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //return 2;
            }
            finally
            {
                conn.Close();
            }
        }

        private void UpdateProductIds(int id,int number)
        {
            int qty = 0;
            try
            {
                conn.Open();
                query = new SqlCommand("select CurrentQuantity from ProductIDs where ProductID='" + id + "'", conn);
                SqlDataReader dr = query.ExecuteReader();
                if (dr.Read())
                    qty = Convert.ToInt32(dr["CurrentQuantity"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                query = new SqlCommand("update ProductIDs set CurrentQuantity='"+(qty+number)+"',LastYearQuantity='"+qty+"' where ProductID='"+id+"'", conn);
                if (query.ExecuteNonQuery() > 0)
                {
                    //return 0;
                }
               // return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //return 2;
            }
            finally
            {
                conn.Close();
            }
        }

        public int UpdateProductIDsInfo(int id, int number)
        {
            try
            {
                conn.Open();
                query = new SqlCommand("update ProductIDs set CurrentQuantity='" + (number) + "' where ProductID='" + id + "'", conn);
                if (query.ExecuteNonQuery() > 0)
                {
                    return 0;
                }
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 2;
            }
            finally
            {
                conn.Close();
            }
        }

        public int InsertIntoProductDetails(bool chk,params string[] pd)
        {
            try
            {
                if (chk == false)
                {
                    UpdateProductIds(Convert.ToInt32(pd[0]), Convert.ToInt32(pd[4]));
                }
                conn.Open();
                query = new SqlCommand("insert into ProductDetails(ProductID,ProductYear,ProductSuplier,BillNo,Quantity,Amount,Total) values('" + Convert.ToInt32(pd[0]) + "','" + pd[1].ToString() + "','" + pd[2].ToString() + "','" + Convert.ToInt64(pd[3]) + "','" + Convert.ToInt32(pd[4]) + "','"+Convert.ToInt64(pd[5])+"','"+Convert.ToInt64(pd[6])+"')", conn);
                if (query.ExecuteNonQuery() > 0)
                {
                    return 0;
                }
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 2;
            }
            finally
            {
                conn.Close();
            }
        }

        public int InsertIntoProductInfo(params string[] pd)
        {
            try
            {
                UpdateProductIDsInfo(Convert.ToInt32(pd[0]), Convert.ToInt32(pd[3]));
                conn.Open();
                query = new SqlCommand("insert into ProductInfo(ProductID,PurchaseYear,WriteOff,CurrentBalance,CurrentDate) values('"+Convert.ToInt32(pd[0])+"','"+pd[1]+"','"+Convert.ToInt32(pd[2])+"','"+Convert.ToInt32(pd[3])+"','"+pd[4]+"')", conn);
                if (query.ExecuteNonQuery() > 0)
                {
                    return 0;
                }
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 2;
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteData(string tablename,params string[] data)
        {
            try
            {
                conn.Open();
                if (tablename == "Player_Table")
                {
                    query = new SqlCommand("delete from Player_Table where PRNNumber='" + Convert.ToInt64(data[0]) + "'",conn);
                    if (query.ExecuteNonQuery() > 0)
                    {
                        //return;
                        query = new SqlCommand("insert into DeletePlayer(PRNNumber,FullName,AdmissionToCollege,ContactNumber) values('" + Convert.ToInt64(data[0]) + "','" + data[1].ToString() + "','" + Convert.ToInt32(data[2].ToString()) + "','" + Convert.ToInt64(data[3].ToString()) + "')", conn);
                        if (query.ExecuteNonQuery() > 0)
                        {
                            //count++;
                        }
                    }
                }
                if (tablename == "Match_Table")
                {
                    query = new SqlCommand("delete from Match_Table where ID='" + Convert.ToInt32(data[0]) + "'", conn);
                    if (query.ExecuteNonQuery() > 0)
                    {
                        //return;
                        query = new SqlCommand("insert into DeleteMatch(TournamentName,TournamentDate,OrganizingCollege) values('" + data[1].ToString() + "','" + data[2].ToString() + "','" + data[3].ToString() + "')", conn);
                        if (query.ExecuteNonQuery() > 0)
                        {
                            //count++;
                        }
                    }
                }
                if (tablename == "Staff_Table")
                {
                    query = new SqlCommand("delete from Staff_Table where ID='" + Convert.ToInt32(data[0]) + "'", conn);
                    if (query.ExecuteNonQuery() > 0)
                    {
                        //return;
                        query = new SqlCommand("insert into DeleteStaff(FullName,ContactNumber) values('" + data[1].ToString() + "','" + data[2].ToString() + "')", conn);
                        if (query.ExecuteNonQuery() > 0)
                        {
                            //count++;
                        }
                    }
                }
                if (tablename == "Eligibility_Table")
                {
                    query = new SqlCommand("delete from Eligibility_Table where ID='" + Convert.ToInt32(data[0]) + "'", conn);
                    if (query.ExecuteNonQuery() > 0)
                    {
                        //return;
                        query = new SqlCommand("insert into DeleteEligibility(PRNNumber,PlayerFullName,StaffFullName,TournamentName,TournamentDate) values('" + data[1].ToString() + "','" + data[2].ToString() + "','" + data[3].ToString() + "','" + data[4].ToString() + "','" + data[5].ToString() + "')", conn);
                        if (query.ExecuteNonQuery() > 0)
                        {
                            //count++;
                        }
                    }
                }

                //MessageBox.Show(count.ToString());
                //count = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
