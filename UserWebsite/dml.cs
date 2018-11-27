using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UserWebsite
{
    public class dml:connection
    {
        public DataTable getmodeldetails()
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                //Adpt = new SqlDataAdapter("select * from MODEL_TABLE", sqlcon);
                Adpt = new SqlDataAdapter("SELECT DISTINCT MODEL_TABLE.MODEL_NAME, MODEL_TABLE.MODEL_ID,MODEL_TABLE.MODEL_PICTURE,MODEL_TABLE.VIDEO_LINK FROM MODEL_TABLE INNER JOIN SUBMODEL_DETAILS ON MODEL_TABLE.MODEL_ID = SUBMODEL_DETAILS.MODEL_ID INNER JOIN PRICE_DETAILS ON MODEL_TABLE.MODEL_ID = PRICE_DETAILS.MODEL_ID INNER JOIN SMFEATURE_DETAILS ON MODEL_TABLE.MODEL_ID = SMFEATURE_DETAILS.MODEL_ID", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }

        }

        public DataTable getsubmodeldetails(string s)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT SUBMODEL_DETAILS.SUBMODEL_NAME, SUBMODEL_DETAILS.PICTURE,SUBMODEL_DETAILS.SUBMODEL_ID FROM MODEL_TABLE INNER JOIN SUBMODEL_DETAILS ON MODEL_TABLE.MODEL_ID = SUBMODEL_DETAILS.MODEL_ID WHERE (MODEL_TABLE.MODEL_ID = @s)", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@s", s);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }

        public DataTable getcolordetails()
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT COLOR_NAME FROM COLOR_DETAILS", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public DataTable getpricedetails()
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT PRICE FROM PRICE_DETAILS", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }

        public DataTable getsubmodeldetails_1(string s)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT PRICE_DETAILS.COLOR_ID, COLOR_DETAILS.COLOR_NAME, SUBMODEL_DETAILS.SUBMODEL_NAME, PRICE_DETAILS.PRICE, SUBMODEL_DETAILS.PICTURE, PRICE_DETAILS.SUBMODEL_ID FROM COLOR_DETAILS INNER JOIN PRICE_DETAILS ON COLOR_DETAILS.COLOR_ID = PRICE_DETAILS.COLOR_ID INNER JOIN SUBMODEL_DETAILS ON PRICE_DETAILS.SUBMODEL_ID = SUBMODEL_DETAILS.SUBMODEL_ID where SUBMODEL_DETAILS.SUBMODEL_ID=@s", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@s", s);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public DataTable getsubmodeldetails_drop(string s)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT COLOR_DETAILS.COLOR_NAME, COLOR_DETAILS.COLOR_ID AS Expr1 FROM COLOR_DETAILS INNER JOIN PRICE_DETAILS ON COLOR_DETAILS.COLOR_ID = PRICE_DETAILS.COLOR_ID where PRICE_DETAILS.SUBMODEL_ID=@s", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@s", s);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                dt.Rows.InsertAt(dt.NewRow(), 0);
                dt.Rows[0]["COLOR_NAME"] = "<---Select---->";
                dt.Rows[0]["Expr1"] = "0";
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public DataTable getsubmodeldetails_label(string s,string sub)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT COLOR_DETAILS.COLOR_NAME, PRICE_DETAILS.PRICE, PRICE_DETAILS.COLOR_ID FROM COLOR_DETAILS INNER JOIN PRICE_DETAILS ON COLOR_DETAILS.COLOR_ID = PRICE_DETAILS.COLOR_ID WHERE (PRICE_DETAILS.COLOR_ID = @s) AND (PRICE_DETAILS.SUBMODEL_ID = @sub)", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@s", s);
                Adpt.SelectCommand.Parameters.AddWithValue("@sub", sub);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public DataTable getfeatures(string s)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT SMFEATURE_DETAILS.SUBMODEL_ID, FEATURE_DETAILS.FEATURE_NAME, FEATURE_DETAILS.FEATURE_ID FROM FEATURE_DETAILS INNER JOIN SMFEATURE_DETAILS ON FEATURE_DETAILS.FEATURE_ID = SMFEATURE_DETAILS.FEATURE_ID INNER JOIN SUBMODEL_DETAILS ON SMFEATURE_DETAILS.SUBMODEL_ID = SUBMODEL_DETAILS.SUBMODEL_ID where SUBMODEL_DETAILS.SUBMODEL_ID=@s", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public DataTable getsubmodel_details(string id)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from SUBMODEL_DETAILS where SUBMODEL_ID=@id", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@id", id);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch(Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
           
        }
        public string inc1()
        {
            SqlCommand cmd = new SqlCommand("select isnull(max(BOOKING_ID)+1,1) from BOOKING_DETAILS", sqlcon);
            return cmd.ExecuteScalar().ToString();
        }
        public string getmodel_id(string id)
        {
            SqlCommand cmd = new SqlCommand(" SELECT MODEL_TABLE.MODEL_ID FROM MODEL_TABLE INNER JOIN SUBMODEL_DETAILS ON MODEL_TABLE.MODEL_ID = SUBMODEL_DETAILS.MODEL_ID where SUBMODEL_DETAILS.SUBMODEL_ID=@id ", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteScalar().ToString();
        }
        public string getprice(string id1,string id2,string id3)
        {
            SqlCommand cmd = new SqlCommand("select PRICE from PRICE_DETAILS where MODEL_ID=@id1 and SUBMODEL_ID=@id2 and COLOR_ID=@id3", sqlcon);
            cmd.Parameters.AddWithValue("@id1", id1);
            cmd.Parameters.AddWithValue("@id2", id2);
            cmd.Parameters.AddWithValue("@id3", id3);
            return cmd.ExecuteScalar().ToString();
        }
        public void booking_details(string bookingid,string userid,string modelid,string colorid,string submodelid,System.DateTime bookingdate,string amount,string status,string bal_amount,string name,string number,string email)
        {
            SqlCommand cmd = new SqlCommand("insert into BOOKING_DETAILS(BOOKING_ID,USER_ID,MODEL_ID,COLOR_ID,SUBMODEL_ID,BOOKING_DATE,AMOUNT,STATUS,BALANCE_AMOUNT,NAME,CONTACT_NUMBER,EMAIL) values(@bid,@uid,@mid,@cid,@sid,@date,@amount,@status,@balamount,@name,@number,@email)", sqlcon);
            cmd.Parameters.AddWithValue("@bid", bookingid);
            cmd.Parameters.AddWithValue("@uid", userid);
            cmd.Parameters.AddWithValue("@mid", modelid);
            cmd.Parameters.AddWithValue("@cid", colorid);
            cmd.Parameters.AddWithValue("@sid", submodelid);
            cmd.Parameters.AddWithValue("@date", bookingdate);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@balamount", bal_amount);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@number", number);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();
        }
        public DataTable check(string name,string password)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from USER_DETAILS where USER_NAME=@name and PASSWORD=@password", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@name", name);
                Adpt.SelectCommand.Parameters.AddWithValue("@password", password);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public void user_details(string userid,string fname,string lname,string email,string password)
        {
            SqlCommand cmd = new SqlCommand("insert into USER_DETAILS values(@userid,@fname,@lname,@email,@password)", sqlcon);
            cmd.Parameters.AddWithValue("@userid",userid);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname",lname);
            cmd.Parameters.AddWithValue("@email",email);
            cmd.Parameters.AddWithValue("@password",password);
            cmd.ExecuteNonQuery();
        }
        public string inc2()
        {
            SqlCommand cmd = new SqlCommand("select isnull(max(USER_ID)+1,1) from USER_DETAILS", sqlcon);
            return cmd.ExecuteScalar().ToString();
        }
        public DataTable get_detials(string submodel_id,string color_id)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT TYPE_DETAILS.TYPE_NAME, PRICE_DETAILS.PRICE, PRICE_DETAILS.EXPECTED_DAYS, SUBMODEL_DETAILS.SUBMODEL_NAME, MODEL_TABLE.MODEL_NAME, COLOR_DETAILS.COLOR_NAME,SUBMODEL_DETAILS.ADV_AMOUNT, SUBMODEL_DETAILS.SUBMODEL_ID, COLOR_DETAILS.COLOR_ID, MODEL_TABLE.MODEL_ID FROM SUBMODEL_DETAILS INNER JOIN MODEL_TABLE ON SUBMODEL_DETAILS.MODEL_ID = MODEL_TABLE.MODEL_ID INNER JOIN TYPE_DETAILS ON SUBMODEL_DETAILS.TYPE_ID = TYPE_DETAILS.TYPE_ID INNER JOIN COLOR_DETAILS INNER JOIN PRICE_DETAILS ON COLOR_DETAILS.COLOR_ID = PRICE_DETAILS.COLOR_ID ON MODEL_TABLE.MODEL_ID = PRICE_DETAILS.MODEL_ID AND  SUBMODEL_DETAILS.SUBMODEL_ID = PRICE_DETAILS.SUBMODEL_ID WHERE(SUBMODEL_DETAILS.SUBMODEL_ID = @submodelid) AND (COLOR_DETAILS.COLOR_ID = @colorid)", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@submodelid", submodel_id);
                Adpt.SelectCommand.Parameters.AddWithValue("@colorid", color_id);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }

        public DataTable get_datalist_search(string search)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                //Adpt = new SqlDataAdapter("SELECT DISTINCT SUBMODEL_DETAILS.SUBMODEL_NAME, SUBMODEL_DETAILS.SUBMODEL_ID, SUBMODEL_DETAILS.PICTURE, SUBMODEL_DETAILS.ADV_AMOUNT, COLOR_DETAILS.COLOR_NAME,MODEL_TABLE.MODEL_NAME, PRICE_DETAILS.PRICE, TYPE_DETAILS.TYPE_NAME FROM TYPE_DETAILS INNER JOIN MODEL_TABLE INNER JOIN PRICE_DETAILS INNER JOIN COLOR_DETAILS ON PRICE_DETAILS.COLOR_ID = COLOR_DETAILS.COLOR_ID ON MODEL_TABLE.MODEL_ID = PRICE_DETAILS.MODEL_ID INNER JOIN SUBMODEL_DETAILS ON MODEL_TABLE.MODEL_ID = SUBMODEL_DETAILS.MODEL_ID ON TYPE_DETAILS.TYPE_ID = SUBMODEL_DETAILS.TYPE_ID INNER JOIN SMFEATURE_DETAILS ON MODEL_TABLE.MODEL_ID = SMFEATURE_DETAILS.MODEL_ID AND SUBMODEL_DETAILS.SUBMODEL_ID = SMFEATURE_DETAILS.SUBMODEL_ID INNER JOIN FEATURE_DETAILS ON SMFEATURE_DETAILS.FEATURE_ID = FEATURE_DETAILS.FEATURE_ID WHERE(TYPE_DETAILS.TYPE_NAME LIKE @search) OR (MODEL_TABLE.MODEL_NAME LIKE @search) OR (SUBMODEL_DETAILS.SUBMODEL_NAME LIKE @search)", sqlcon);
                Adpt = new SqlDataAdapter("SELECT DISTINCT SUBMODEL_DETAILS.SUBMODEL_NAME, SUBMODEL_DETAILS.SUBMODEL_ID, SUBMODEL_DETAILS.PICTURE, SUBMODEL_DETAILS.ADV_AMOUNT, MODEL_TABLE.MODEL_NAME, TYPE_DETAILS.TYPE_NAME FROM FEATURE_DETAILS INNER JOIN TYPE_DETAILS INNER JOIN SUBMODEL_DETAILS INNER JOIN MODEL_TABLE ON SUBMODEL_DETAILS.MODEL_ID = MODEL_TABLE.MODEL_ID ON TYPE_DETAILS.TYPE_ID = SUBMODEL_DETAILS.TYPE_ID INNER JOIN SMFEATURE_DETAILS ON MODEL_TABLE.MODEL_ID = SMFEATURE_DETAILS.MODEL_ID AND SUBMODEL_DETAILS.SUBMODEL_ID = SMFEATURE_DETAILS.SUBMODEL_ID ON FEATURE_DETAILS.FEATURE_ID = SMFEATURE_DETAILS.FEATURE_ID WHERE (TYPE_DETAILS.TYPE_NAME LIKE @search) OR (MODEL_TABLE.MODEL_NAME LIKE @search) OR (SUBMODEL_DETAILS.SUBMODEL_NAME LIKE @search)", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@search","%"+search+"%");
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }

        public DataTable get_datalist_searchColor(string search,string srch,string src)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                //Adpt = new SqlDataAdapter("SELECT DISTINCT SUBMODEL_DETAILS.SUBMODEL_NAME, SUBMODEL_DETAILS.SUBMODEL_ID, SUBMODEL_DETAILS.PICTURE, SUBMODEL_DETAILS.ADV_AMOUNT, COLOR_DETAILS.COLOR_NAME,MODEL_TABLE.MODEL_NAME, PRICE_DETAILS.PRICE, TYPE_DETAILS.TYPE_NAME FROM TYPE_DETAILS INNER JOIN MODEL_TABLE INNER JOIN PRICE_DETAILS INNER JOIN COLOR_DETAILS ON PRICE_DETAILS.COLOR_ID = COLOR_DETAILS.COLOR_ID ON MODEL_TABLE.MODEL_ID = PRICE_DETAILS.MODEL_ID INNER JOIN SUBMODEL_DETAILS ON MODEL_TABLE.MODEL_ID = SUBMODEL_DETAILS.MODEL_ID ON TYPE_DETAILS.TYPE_ID = SUBMODEL_DETAILS.TYPE_ID INNER JOIN SMFEATURE_DETAILS ON MODEL_TABLE.MODEL_ID = SMFEATURE_DETAILS.MODEL_ID AND SUBMODEL_DETAILS.SUBMODEL_ID = SMFEATURE_DETAILS.SUBMODEL_ID INNER JOIN FEATURE_DETAILS ON SMFEATURE_DETAILS.FEATURE_ID = FEATURE_DETAILS.FEATURE_ID WHERE(TYPE_DETAILS.TYPE_NAME LIKE @search) OR (MODEL_TABLE.MODEL_NAME LIKE @search) OR (SUBMODEL_DETAILS.SUBMODEL_NAME LIKE @search)", sqlcon);
                Adpt = new SqlDataAdapter("SELECT DISTINCT SUBMODEL_DETAILS.SUBMODEL_NAME, SUBMODEL_DETAILS.SUBMODEL_ID, SUBMODEL_DETAILS.PICTURE, SUBMODEL_DETAILS.ADV_AMOUNT, MODEL_TABLE.MODEL_NAME, TYPE_DETAILS.TYPE_NAME FROM PRICE_DETAILS INNER JOIN COLOR_DETAILS ON PRICE_DETAILS.COLOR_ID = COLOR_DETAILS.COLOR_ID INNER JOIN TYPE_DETAILS INNER JOIN SUBMODEL_DETAILS ON TYPE_DETAILS.TYPE_ID = SUBMODEL_DETAILS.TYPE_ID INNER JOIN SMFEATURE_DETAILS ON SUBMODEL_DETAILS.MODEL_ID = SMFEATURE_DETAILS.MODEL_ID AND SUBMODEL_DETAILS.SUBMODEL_ID = SMFEATURE_DETAILS.SUBMODEL_ID INNER JOIN FEATURE_DETAILS ON SMFEATURE_DETAILS.FEATURE_ID = FEATURE_DETAILS.FEATURE_ID INNER JOIN MODEL_TABLE ON SUBMODEL_DETAILS.MODEL_ID = MODEL_TABLE.MODEL_ID ON PRICE_DETAILS.MODEL_ID = MODEL_TABLE.MODEL_ID AND PRICE_DETAILS.SUBMODEL_ID = SUBMODEL_DETAILS.SUBMODEL_ID WHERE (COLOR_DETAILS.COLOR_NAME LIKE @search) OR (MODEL_TABLE.MODEL_NAME LIKE @srch) AND (PRICE_DETAILS.PRICE LIKE @src)", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                Adpt.SelectCommand.Parameters.AddWithValue("@srch", "%" + srch + "%");
                Adpt.SelectCommand.Parameters.AddWithValue("@src", "%" + src + "%");
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
            
        }

        public DataTable get_datalist_searchPrice(string search)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                //Adpt = new SqlDataAdapter("SELECT DISTINCT SUBMODEL_DETAILS.SUBMODEL_NAME, SUBMODEL_DETAILS.SUBMODEL_ID, SUBMODEL_DETAILS.PICTURE, SUBMODEL_DETAILS.ADV_AMOUNT, COLOR_DETAILS.COLOR_NAME,MODEL_TABLE.MODEL_NAME, PRICE_DETAILS.PRICE, TYPE_DETAILS.TYPE_NAME FROM TYPE_DETAILS INNER JOIN MODEL_TABLE INNER JOIN PRICE_DETAILS INNER JOIN COLOR_DETAILS ON PRICE_DETAILS.COLOR_ID = COLOR_DETAILS.COLOR_ID ON MODEL_TABLE.MODEL_ID = PRICE_DETAILS.MODEL_ID INNER JOIN SUBMODEL_DETAILS ON MODEL_TABLE.MODEL_ID = SUBMODEL_DETAILS.MODEL_ID ON TYPE_DETAILS.TYPE_ID = SUBMODEL_DETAILS.TYPE_ID INNER JOIN SMFEATURE_DETAILS ON MODEL_TABLE.MODEL_ID = SMFEATURE_DETAILS.MODEL_ID AND SUBMODEL_DETAILS.SUBMODEL_ID = SMFEATURE_DETAILS.SUBMODEL_ID INNER JOIN FEATURE_DETAILS ON SMFEATURE_DETAILS.FEATURE_ID = FEATURE_DETAILS.FEATURE_ID WHERE(TYPE_DETAILS.TYPE_NAME LIKE @search) OR (MODEL_TABLE.MODEL_NAME LIKE @search) OR (SUBMODEL_DETAILS.SUBMODEL_NAME LIKE @search)", sqlcon);
                Adpt = new SqlDataAdapter("SELECT DISTINCT SUBMODEL_DETAILS.SUBMODEL_NAME, SUBMODEL_DETAILS.SUBMODEL_ID, SUBMODEL_DETAILS.PICTURE, SUBMODEL_DETAILS.ADV_AMOUNT, MODEL_TABLE.MODEL_NAME, TYPE_DETAILS.TYPE_NAME FROM PRICE_DETAILS INNER JOIN COLOR_DETAILS ON PRICE_DETAILS.COLOR_ID = COLOR_DETAILS.COLOR_ID INNER JOIN TYPE_DETAILS INNER JOIN SUBMODEL_DETAILS ON TYPE_DETAILS.TYPE_ID = SUBMODEL_DETAILS.TYPE_ID INNER JOIN SMFEATURE_DETAILS ON SUBMODEL_DETAILS.MODEL_ID = SMFEATURE_DETAILS.MODEL_ID AND SUBMODEL_DETAILS.SUBMODEL_ID = SMFEATURE_DETAILS.SUBMODEL_ID INNER JOIN FEATURE_DETAILS ON SMFEATURE_DETAILS.FEATURE_ID = FEATURE_DETAILS.FEATURE_ID INNER JOIN MODEL_TABLE ON SUBMODEL_DETAILS.MODEL_ID = MODEL_TABLE.MODEL_ID ON PRICE_DETAILS.MODEL_ID = MODEL_TABLE.MODEL_ID AND PRICE_DETAILS.SUBMODEL_ID = SUBMODEL_DETAILS.SUBMODEL_ID WHERE (COLOR_DETAILS.COLOR_NAME LIKE @search)", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }

        }

        public string inc3()
        {
            SqlCommand cmd = new SqlCommand("select isnull(max(AD_ID)+1,1) from AD_POSTING", sqlcon);
            return cmd.ExecuteScalar().ToString();
        }
        public void adpost_details(string adid,string uid,string name,string number,string company,string model,string submodel,string fuel,string year,string kilometer,string price,string extension,string extension1)
        {
            SqlCommand cmd = new SqlCommand("insert into AD_POSTING values(@adid,@uid,@name,@number,@company,@model,@submodel,@fuel,@year,@kilometer,@price,@extension,@extension1)", sqlcon);
            cmd.Parameters.AddWithValue("@adid", adid);
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@number", number);
            cmd.Parameters.AddWithValue("@company", company);
            cmd.Parameters.AddWithValue("@model", model);
            cmd.Parameters.AddWithValue("@submodel", submodel);
            cmd.Parameters.AddWithValue("@fuel", fuel);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@kilometer", kilometer);
            cmd.Parameters.AddWithValue("@price",price);
            cmd.Parameters.AddWithValue("@extension", extension);
            cmd.Parameters.AddWithValue("@extension1", extension1);
            cmd.ExecuteNonQuery();

        }
        public DataTable get_datalist_adview()
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                //Adpt = new SqlDataAdapter("SELECT DISTINCT SUBMODEL_DETAILS.SUBMODEL_NAME, SUBMODEL_DETAILS.SUBMODEL_ID, SUBMODEL_DETAILS.PICTURE, SUBMODEL_DETAILS.ADV_AMOUNT, COLOR_DETAILS.COLOR_NAME,MODEL_TABLE.MODEL_NAME, PRICE_DETAILS.PRICE, TYPE_DETAILS.TYPE_NAME FROM TYPE_DETAILS INNER JOIN MODEL_TABLE INNER JOIN PRICE_DETAILS INNER JOIN COLOR_DETAILS ON PRICE_DETAILS.COLOR_ID = COLOR_DETAILS.COLOR_ID ON MODEL_TABLE.MODEL_ID = PRICE_DETAILS.MODEL_ID INNER JOIN SUBMODEL_DETAILS ON MODEL_TABLE.MODEL_ID = SUBMODEL_DETAILS.MODEL_ID ON TYPE_DETAILS.TYPE_ID = SUBMODEL_DETAILS.TYPE_ID INNER JOIN SMFEATURE_DETAILS ON MODEL_TABLE.MODEL_ID = SMFEATURE_DETAILS.MODEL_ID AND SUBMODEL_DETAILS.SUBMODEL_ID = SMFEATURE_DETAILS.SUBMODEL_ID INNER JOIN FEATURE_DETAILS ON SMFEATURE_DETAILS.FEATURE_ID = FEATURE_DETAILS.FEATURE_ID WHERE(TYPE_DETAILS.TYPE_NAME LIKE @search) OR (MODEL_TABLE.MODEL_NAME LIKE @search) OR (SUBMODEL_DETAILS.SUBMODEL_NAME LIKE @search)", sqlcon);
                Adpt = new SqlDataAdapter("SELECT * FROM AD_POSTING", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public DataTable get_datalist_search_oldcar(string search)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                //Adpt = new SqlDataAdapter("SELECT DISTINCT SUBMODEL_DETAILS.SUBMODEL_NAME, SUBMODEL_DETAILS.SUBMODEL_ID, SUBMODEL_DETAILS.PICTURE, SUBMODEL_DETAILS.ADV_AMOUNT, COLOR_DETAILS.COLOR_NAME,MODEL_TABLE.MODEL_NAME, PRICE_DETAILS.PRICE, TYPE_DETAILS.TYPE_NAME FROM TYPE_DETAILS INNER JOIN MODEL_TABLE INNER JOIN PRICE_DETAILS INNER JOIN COLOR_DETAILS ON PRICE_DETAILS.COLOR_ID = COLOR_DETAILS.COLOR_ID ON MODEL_TABLE.MODEL_ID = PRICE_DETAILS.MODEL_ID INNER JOIN SUBMODEL_DETAILS ON MODEL_TABLE.MODEL_ID = SUBMODEL_DETAILS.MODEL_ID ON TYPE_DETAILS.TYPE_ID = SUBMODEL_DETAILS.TYPE_ID INNER JOIN SMFEATURE_DETAILS ON MODEL_TABLE.MODEL_ID = SMFEATURE_DETAILS.MODEL_ID AND SUBMODEL_DETAILS.SUBMODEL_ID = SMFEATURE_DETAILS.SUBMODEL_ID INNER JOIN FEATURE_DETAILS ON SMFEATURE_DETAILS.FEATURE_ID = FEATURE_DETAILS.FEATURE_ID WHERE(TYPE_DETAILS.TYPE_NAME LIKE @search) OR (MODEL_TABLE.MODEL_NAME LIKE @search) OR (SUBMODEL_DETAILS.SUBMODEL_NAME LIKE @search)", sqlcon);
                Adpt = new SqlDataAdapter("SELECT * FROM AD_POSTING where (COMPANY like @search) OR (MODEL like @search)", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public DataTable get_addetails(string adid)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT * FROM AD_POSTING WHERE AD_ID=@adid", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@adid", adid);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public DataTable get_booked(string userid)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT BOOKING_DETAILS.USER_ID, MODEL_TABLE.MODEL_PICTURE, BOOKING_DETAILS.BOOKING_ID,MODEL_TABLE.MODEL_NAME FROM BOOKING_DETAILS INNER JOIN MODEL_TABLE ON BOOKING_DETAILS.MODEL_ID = MODEL_TABLE.MODEL_ID WHERE (BOOKING_DETAILS.USER_ID = @userid)", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@userid", userid);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public DataTable get_booking_etails(string bookingid)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT SUBMODEL_DETAILS.SUBMODEL_NAME, MODEL_TABLE.MODEL_NAME, BOOKING_DETAILS.BOOKING_ID, BOOKING_DETAILS.BALANCE_AMOUNT, BOOKING_DETAILS.AMOUNT,BOOKING_DETAILS.BOOKING_DATE, TYPE_DETAILS.TYPE_NAME, PRICE_DETAILS.EXPECTED_DAYS, COLOR_DETAILS.COLOR_NAME,MODEL_TABLE.MODEL_PICTURE, SUBMODEL_DETAILS.PICTURE,BOOKING_DETAILS.STATUS,BOOKING_DETAILS.ISSUE_DATE FROM BOOKING_DETAILS INNER JOIN MODEL_TABLE ON BOOKING_DETAILS.MODEL_ID = MODEL_TABLE.MODEL_ID INNER JOIN SUBMODEL_DETAILS ON BOOKING_DETAILS.SUBMODEL_ID = SUBMODEL_DETAILS.SUBMODEL_ID INNER JOIN TYPE_DETAILS ON SUBMODEL_DETAILS.TYPE_ID = TYPE_DETAILS.TYPE_ID INNER JOIN PRICE_DETAILS ON MODEL_TABLE.MODEL_ID = PRICE_DETAILS.MODEL_ID AND SUBMODEL_DETAILS.SUBMODEL_ID = PRICE_DETAILS.SUBMODEL_ID AND BOOKING_DETAILS.COLOR_ID = PRICE_DETAILS.COLOR_ID INNER JOIN COLOR_DETAILS ON PRICE_DETAILS.COLOR_ID = COLOR_DETAILS.COLOR_ID AND BOOKING_DETAILS.COLOR_ID = COLOR_DETAILS.COLOR_ID WHERE(BOOKING_DETAILS.BOOKING_ID = @bookingid)", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@bookingid", bookingid);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public DataTable get_posted_ads(string userid)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT * FROM AD_POSTING WHERE USER_ID=@userid", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@userid", userid);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public void ad_delete(string adid)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM AD_POSTING WHERE AD_ID=@adid", sqlcon);
            cmd.Parameters.AddWithValue("@adid", adid);
            cmd.ExecuteNonQuery();
        }
        public DataTable get_new_modeldetails()
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                //Adpt = new SqlDataAdapter("select * from MODEL_TABLE", sqlcon);
                Adpt = new SqlDataAdapter("SELECT DISTINCT MODEL_TABLE.MODEL_NAME, MODEL_TABLE.MODEL_ID,MODEL_TABLE.MODEL_PICTURE FROM MODEL_TABLE INNER JOIN SUBMODEL_DETAILS ON MODEL_TABLE.MODEL_ID = SUBMODEL_DETAILS.MODEL_ID INNER JOIN PRICE_DETAILS ON MODEL_TABLE.MODEL_ID = PRICE_DETAILS.MODEL_ID INNER JOIN SMFEATURE_DETAILS ON MODEL_TABLE.MODEL_ID = SMFEATURE_DETAILS.MODEL_ID WHERE (MODEL_TABLE.STATUS = 'NEW')", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }

        }
        public DataTable sliderimages()
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from SLIDER_IMAGE", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }

        }

        public DataTable getPaymentDetails()
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from PAYMENT_MASTER", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }

        }
        public void payment_method(string mid,string uid,string bid,string acc_info)
        {
            SqlCommand cmd = new SqlCommand("insert into PAYMENT_METHOD values(@mid,@uid,@bid,@acc_info)", sqlcon);
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@bid", bid);
            cmd.Parameters.AddWithValue("@acc_info", acc_info);
            cmd.ExecuteNonQuery();
        }


        public DataTable getModelPhotos(string mid)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from MODEL_PHOTOS WHERE MODEL_ID=@mid", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@mid", mid);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }

        }
        public DataTable getModelVideo(string mid)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from MODEL_TABLE WHERE MODEL_ID=@mid", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@mid", mid);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }

        }

        public DataTable getCompanyDetails()
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from COMPANY_DETAILS", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }

        }


        public DataTable check1(string email)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT * FROM USER_DETAILS WHERE USER_NAME=@email", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@email", email);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }

        }


    }
}